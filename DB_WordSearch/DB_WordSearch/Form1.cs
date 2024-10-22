using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_WordSearch
{
    public partial class Form1 : Form
    {
        // OleDb 연결 객체 선언
        System.Data.OleDb.OleDbConnection _conn;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 데이터베이스 연결 메서드
        /// </summary>
        /// <param name="strDBPath"></param>
        private void DBConnect(string strDBPath)
        {
            // DataAdapter는 Connection을 자동으로 처리하기 때문에 conn.Open()이 필요 없음
            string connStr = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={strDBPath}";
            _conn = new OleDbConnection(connStr);

            // Voca 테이블에서 모든 데이터를 선택하는 쿼리
            string Query = $@"SELECT * 
                              FROM Voca";

            // 쿼리 실행 메서드 호출
            QueryExeCute(Query);
        }

        /// <summary>
        /// 쿼리 실행 메서드
        /// </summary>
        /// <param name="Query"></param>
        private void QueryExeCute(string Query)
        {
            // 쿼리 결과를 저장할 DataSet 객체 생성
            DataSet ds = new DataSet();

            // OleDbDataAdapter를 사용하여 쿼리 실행 및 결과 저장
            System.Data.OleDb.OleDbDataAdapter adp = new OleDbDataAdapter(Query, _conn);
            adp.Fill(ds);  // DataSet에 결과를 채움

            // 가져온 데이터를 DataGridView 컨트롤에 바인딩
            dgData.DataSource = ds.Tables[0];
        }

        /// <summary>
        /// OpenFileDialog를 사용하여 데이터베이스 파일을 선택하는 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDBLoad_Click(object sender, EventArgs e)
        {
            // OpenFileDialog의 초기 경로를 프로그램 실행 파일 위치로 설정
            OFDialog.InitialDirectory = Application.StartupPath;
            OFDialog.FileName = "*.mdb";  // 기본 파일명 설정
            OFDialog.Filter = "db files (*.mdb)|*.mdb|All files (*.*)|*.*";  // 파일 필터 설정

            // 사용자가 파일을 선택했을 경우
            if (OFDialog.ShowDialog() == DialogResult.OK)
            {
                // 선택한 파일 경로를 텍스트 박스에 표시
                tboxPath.Text = OFDialog.FileName;

                // 선택한 파일로 데이터베이스 연결
                DBConnect(tboxPath.Text);
            }
        }

        /// <summary>
        /// 사용자가 입력한 쿼리를 실행하는 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExe_Click(object sender, EventArgs e)
        {
            QueryExeCute(tboxQuery.Text);  // 텍스트 박스에 입력된 쿼리를 실행
        }

        /// <summary>
        /// 미리 정의된 쿼리를 텍스트 박스에 표시하는 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEx_Click(object sender, EventArgs e)
        {
            // 클릭된 버튼 객체
            Button obtn = (Button)sender;

            // 실행할 쿼리 변수 선언
            String strQuery = null;

            // 버튼 이름에 따라 다른 쿼리 설정
            switch (obtn.Name)
            {
                case "btnEx1":
                    strQuery = $@"SELECT * 
FROM Voca";  // 모든 데이터를 가져오는 쿼리
                    break;
                case "btnEx2":
                    strQuery = $@"SELECT * 
FROM Voca 
WHERE 단어 LIKE ""%a%""";  // 단어에 'a'가 포함된 데이터를 검색하는 쿼리
                    break;
                case "btnEx3":
                    strQuery = $@"SELECT* 
FROM Voca 
ORDER BY ID DESC";  // ID를 기준으로 내림차순 정렬하는 쿼리
                    break;
                default:
                    break;
            }

            // 선택한 쿼리를 텍스트 박스에 표시
            tboxQuery.Text = strQuery;
        }
    }
}
