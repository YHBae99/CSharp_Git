using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel; // Excel COM Interop 사용
using System.Runtime.InteropServices; // Marshal 클래스 사용 (COM 객체 해제)
using System.Data.OleDb; // OLEDB 사용
using System.IO; // File I/O 사용

namespace _09_Excel_Export
{
    /// <summary>
    /// DataTable 데이터를 Excel 파일로 내보내는 기능을 제공함. (COM, OLEDB, CSV 지원)
    /// </summary>
    internal class Excelexport
    {
        /// <summary>
        /// Excel 내보내기 방식을 정의함.
        /// </summary>
        public enum enExportType
        {
            /// <summary>
            /// Excel COM Interop API 사용 (Excel 설치 필요)
            /// </summary>
            EXCEL_COM,
            /// <summary>
            /// OLEDB 사용 (ACE OLEDB Provider 설치 필요)
            /// </summary>
            OLEDB_EXCEL,
            /// <summary>
            /// CSV 파일로 저장 (Excel에서 열 수 있음)
            /// </summary>
            CSV_STREAM,
        }

        /// <summary>
        /// DataTable 데이터를 지정된 방식과 경로로 내보냄
        /// </summary>
        /// <param name="SaveFilePath">저장할 파일 경로</param>
        /// <param name="dt">내보낼 데이터 테이블</param>
        /// <param name="ExportType">내보내기 방식</param>
        /// <returns>성공 또는 실패 메시지</returns>
        public string ExcelExport(string SaveFilePath, DataTable dt, enExportType ExportType)
        {
            string strRet = null;

            switch (ExportType)
            {
                case enExportType.EXCEL_COM:
                    strRet = SaveExcel_COMAPI(SaveFilePath, dt);
                    break;
                case enExportType.OLEDB_EXCEL:
                    strRet = SaveExcel_OLEDB(SaveFilePath, dt);
                    break;
                case enExportType.CSV_STREAM:
                    strRet = SaveExcel_CSV(SaveFilePath, dt);
                    break;
                default:
                    strRet = "Code에서 Export Type이 잘못 지정 되었음.";
                    break;
            }

            return strRet;
        }

        #region Excel Com API 사용
        /// <summary>
        /// Excel COM Interop API를 사용하여 DataTable을 Excel 파일로 저장함. (Excel 설치 필요)
        /// </summary>
        private string SaveExcel_COMAPI(string SaveFilePath, DataTable dt)
        {
            string strRet = null;
            Excel.Application excelApp = null;
            Excel.Workbook wb = null;
            Excel.Worksheet ws = null;

            try
            {
                excelApp = new Excel.Application();
                wb = excelApp.Workbooks.Add();
                ws = wb.Worksheets.get_Item(1) as Excel.Worksheet;

                // DataTable 데이터를 워크시트에 쓰기 (1-based index)
                int iRow = 1;
                foreach (DataRow dr in dt.Rows)
                {
                    int iColumn = 1;
                    foreach (var vitem in dr.ItemArray)
                    {
                        ws.Cells[iRow, iColumn] = vitem;
                        iColumn++;
                    }
                    iRow++;
                }

                // 엑셀 파일 저장 및 종료
                wb.SaveAs(SaveFilePath, Excel.XlFileFormat.xlWorkbookNormal); // .xls 형식
                wb.Close(true);
                excelApp.Quit();

                strRet = "Excel Export Success!!!";
            }
            catch (Exception ex)
            {
                strRet = $"Excel Export Failed : {ex.ToString()}";
            }
            finally
            {
                // COM 객체는 반드시 명시적으로 해제해야 메모리 누수 및 프로세스 좀비를 방지할 수 있음.
                ReleaseExcelObject(ws);
                ReleaseExcelObject(wb);
                ReleaseExcelObject(excelApp);
            }
            return strRet;
        }

        /// <summary>
        /// COM 객체를 안전하게 해제함.
        /// </summary>
        private void ReleaseExcelObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch (Exception ex)
            {
                obj = null;
                System.Diagnostics.Debug.WriteLine("Error releasing COM object: " + ex.ToString());
            }
            finally
            {
                GC.Collect(); // COM Interop 시 명시적 GC 호출이 도움이 될 수 있음 (신중히 사용)
            }
        }
        #endregion

        #region OleDB 사용
        /// <summary>
        /// OLEDB를 사용하여 DataTable을 Excel 파일로 저장함. (ACE OLEDB Provider 필요)
        /// </summary>
        private string SaveExcel_OLEDB(string FilePath, DataTable dt)
        {
            try
            {
                // Excel 파일용 OLEDB 연결 문자열 (HDR=YES: 첫 행을 헤더로 사용)
                string ExcelOleDbConnectionStringTemplate = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=YES\";";
                // DataTable 구조 기반으로 Excel 시트 생성 SQL 생성
                string createTableWithHeaderScript = GenerateCreateTableCommand(dt);

                using (var conn = new OleDbConnection(String.Format(ExcelOleDbConnectionStringTemplate, FilePath)))
                {
                    conn.Open();

                    // 시트(테이블) 생성
                    OleDbCommand cmd = new OleDbCommand(createTableWithHeaderScript, conn);
                    cmd.ExecuteNonQuery();

                    // 데이터 행 추가
                    foreach (DataRow dataExportRow in dt.Rows)
                    {
                        AddNewRow(conn, dataExportRow);
                    }
                }
                return "Excel Export Success!!!";
            }
            catch (Exception ex)
            {
                return $"Excel Export Failed : {ex.ToString()}";
            }
        }

        /// <summary>
        /// OLEDB 연결을 통해 Excel 시트에 행(DataRow)을 추가함.
        /// </summary>
        private static void AddNewRow(OleDbConnection conn, DataRow dataRow)
        {
            string insertCmd = GenerateInsertRowCommand(dataRow); // INSERT SQL 생성
            using (OleDbCommand cmd = new OleDbCommand(insertCmd, conn))
            {
                AddParametersWithValue(cmd, dataRow); // 파라미터 추가 및 값 설정
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// DataRow 구조 기반으로 파라미터화된 INSERT SQL 명령을 생성함.
        /// </summary>
        private static string GenerateInsertRowCommand(DataRow dataRow)
        {
            var stringBuilder = new StringBuilder();
            var columns = dataRow.Table.Columns.Cast<DataColumn>().ToList();
            // 컬럼명과 파라미터 생성
            var columnNamesCommaSeparated = string.Join(",", columns.Select(x => $"[{x.ColumnName}]"));
            var questionmarkCommaSeparated = string.Join(",", columns.Select(x => "?"));

            stringBuilder.AppendFormat("INSERT INTO [{0}] (", dataRow.Table.TableName);
            stringBuilder.Append(columnNamesCommaSeparated);
            stringBuilder.Append(") VALUES(");
            stringBuilder.Append(questionmarkCommaSeparated);
            stringBuilder.Append(")");
            return stringBuilder.ToString();
        }

        /// <summary>
        /// OleDbCommand에 DataRow의 값을 파라미터로 추가함 (타입 고려).
        /// </summary>
        private static void AddParametersWithValue(OleDbCommand cmd, DataRow dataRow)
        {
            var paramNumber = 1;
            for (int i = 0; i <= dataRow.Table.Columns.Count - 1; i++)
            {
                object value = dataRow[i];
                OleDbParameter parameter = cmd.Parameters.AddWithValue("@p" + paramNumber, value == DBNull.Value ? null : value);

                // 숫자 타입 처리 (Excel 형식 호환성)
                if (value is decimal || value is double)
                {
                    parameter.OleDbType = OleDbType.Double; // 또는 OleDbType.Currency for decimal
                }
                else if (value is int || value is long)
                {
                    parameter.OleDbType = OleDbType.Integer;
                }
                else if (value is DateTime)
                {
                    parameter.OleDbType = OleDbType.Date;
                }
                // 문자열은 기본 AddWithValue 동작에 맡김

                paramNumber++;
            }
        }

        /// <summary>
        /// DataTable 구조를 기반으로 OLEDB용 CREATE TABLE SQL 명령을 생성함.
        /// </summary>
        private string GenerateCreateTableCommand(DataTable tableDefinition)
        {
            StringBuilder stringBuilder = new StringBuilder();
            bool firstCol = true;

            stringBuilder.AppendFormat("CREATE TABLE [{0}] (", tableDefinition.TableName);

            foreach (DataColumn tableColumn in tableDefinition.Columns)
            {
                if (!firstCol) stringBuilder.Append(", ");
                firstCol = false;

                // DataTable 타입을 OLEDB 타입으로 매핑
                string columnDataType = "MEMO"; // 기본: 긴 텍스트
                switch (tableColumn.DataType.Name)
                {
                    case "Int32": case "Int64": columnDataType = "INTEGER"; break;
                    case "Decimal": case "Double": columnDataType = "NUMBER"; break; // 또는 CURRENCY
                    case "DateTime": columnDataType = "DATETIME"; break;
                        // case "Boolean": columnDataType = "BIT"; break; // 필요한 경우 추가
                }
                stringBuilder.AppendFormat("[{0}] {1}", tableColumn.ColumnName, columnDataType);
            }
            stringBuilder.Append(")");
            return stringBuilder.ToString();
        }
        #endregion

        #region CSV
        /// <summary>
        /// DataTable 데이터를 CSV 파일로 저장함.
        /// </summary>
        private string SaveExcel_CSV(string FilePath, DataTable dt)
        {
            try
            {
                var lines = new List<string>();

                // 헤더 생성 (필드 이스케이프 처리 포함)
                string[] columnNames = dt.Columns.Cast<DataColumn>()
                                           .Select(column => EscapeCsvField(column.ColumnName))
                                           .ToArray();
                lines.Add(string.Join(",", columnNames));

                // 데이터 라인 생성 (각 필드 이스케이프 처리 포함)
                var valueLines = dt.AsEnumerable()
                                   .Select(row => string.Join(",", row.ItemArray.Select(field => EscapeCsvField(field))));
                lines.AddRange(valueLines);

                // 파일 쓰기 (UTF-8 with BOM: Excel에서 한글 깨짐 방지 및 자동 인식에 유리)
                File.WriteAllLines(FilePath, lines, new UTF8Encoding(true));
                return "Excel Export Success!!!";
            }
            catch (Exception ex)
            {
                return $"Excel Export Failed : {ex.ToString()}";
            }
        }

        /// <summary>
        /// CSV 필드 값의 특수 문자(쉼표, 큰따옴표, 줄바꿈)를 이스케이프 처리함.
        /// </summary>
        private string EscapeCsvField(object field)
        {
            if (field == null || field == DBNull.Value) return "";
            string stringField = field.ToString();
            // 필드에 쉼표, 큰따옴표, 줄바꿈이 포함되면 큰따옴표로 감싸고 내부 큰따옴표는 2개로 변경
            if (stringField.Contains(",") || stringField.Contains("\"") || stringField.Contains("\n") || stringField.Contains("\r"))
            {
                return $"\"{stringField.Replace("\"", "\"\"")}\"";
            }
            return stringField;
        }
        #endregion
    }
}