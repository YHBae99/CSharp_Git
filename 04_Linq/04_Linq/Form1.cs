using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace _04_Linq
{
    public partial class Form1 : Form
    {
        // DataTable 컬럼 이름 정의
        const string sLEVEL = "LEVEL";         // 적의 레벨을 나타내는 컬럼 이름
        const string sNAME = "NAME";           // 적의 이름을 나타내는 컬럼 이름
        const string sATTRIBUTE = "ATTRIBUTE"; // 적의 속성(요소)를 나타내는 컬럼 이름

        // 정렬 방향을 저장할 변수
        private bool isAscending = true; // true: 오름차순, false: 내림차순

        DataTable dt; // 적 정보를 저장할 DataTable

        // 적의 이름을 정의하는 Enum
        enum EnumName
        {
            슬라임,
            가고일,
            골렘,
            코볼트,
            고블린,
            고스트,
            언데드, 
            노움, 
            드래곤, 
            웜, 
            서큐버스, 
            데빌, 
            만티코어, 
            바실리스트,
        }

        // 적의 속성을 정의하는 Enum
        enum EnumAttribute
        {
            불, 
            물, 
            바람, 
            번개, 
            어둠, 
            빛, 
            땅, 
            나무,
        }

        /// <summary>
        /// 프로그램 진입점 및 Form 생성자
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form이 로드될 때 실행되는 이벤트
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTableCreate();  // DataTable 틀 생성
            EnemyCreate();      // 적 데이터 생성
            ComboBoxCreate();   // ComboBox에 속성 데이터 추가
        }

        /// <summary>
        /// 적 정보 DataTable 틀을 생성하는 함수
        /// </summary>
        private void DataTableCreate()
        {
            dt = new DataTable("Enemy"); // 적 정보 DataTable 생성

            // 컬럼 정의 (레벨, 이름, 속성)
            DataColumn colLevel = new DataColumn(sLEVEL, typeof(int)); // 레벨 (정수형)
            DataColumn colName = new DataColumn(sNAME, typeof(string)); // 이름 (문자열)
            DataColumn colAttribute = new DataColumn(sATTRIBUTE, typeof(string)); // 속성 (문자열)

            // 컬럼을 DataTable에 추가
            dt.Columns.Add(colLevel);
            dt.Columns.Add(colName);
            dt.Columns.Add(colAttribute);
        }

        /// <summary>
        /// 적 정보를 랜덤하게 생성하여 DataTable에 추가하는 함수
        /// </summary>
        private void EnemyCreate()
        {
            Random rd = new Random(); // 랜덤 값을 생성하는 객체

            // EnumName에 정의된 모든 적 이름을 순회
            foreach (EnumName oName in Enum.GetValues(typeof(EnumName)))
            {
                DataRow dr = dt.NewRow(); // 새로운 DataRow 생성

                dr[sLEVEL] = rd.Next(1, 11);  // 1부터 10 사이의 랜덤한 레벨 할당
                dr[sNAME] = oName.ToString(); // 적 이름 할당

                int iEnumLength = Enum.GetValues(typeof(EnumAttribute)).Length;  // EnumAttribute 속성의 개수 가져오기
                int iAttribute = rd.Next(iEnumLength);  // 랜덤한 속성 선택
                dr[sATTRIBUTE] = ((EnumAttribute)iAttribute).ToString(); // 속성 할당

                dt.Rows.Add(dr); // DataRow를 DataTable에 추가
            }

            // DataGridView에 DataTable 바인딩
            dgEnemyTable.DataSource = dt;
        }

        /// <summary>
        /// EnumAttribute 속성을 ComboBox에 추가하는 함수
        /// </summary>
        private void ComboBoxCreate()
        {
            // EnumAttribute의 모든 값을 순회하며 ComboBox에 추가
            foreach (EnumAttribute oAttribute in Enum.GetValues(typeof(EnumAttribute)))
            {
                cboxAttribute.Items.Add(oAttribute);
            }
            cboxAttribute.SelectedIndex = 0; // 기본 선택 값 설정
        }

        ///// <summary>
        ///// 정렬 버튼 클릭 시 실행되는 이벤트
        ///// </summary>
        ///// <param name="sender">클릭된 버튼</param>
        //private void btnSort_Click(object sender, EventArgs e)
        //{
        //    Button oBtn = sender as Button; // 클릭된 버튼 식별

        //    // 현재 DataGridView에 있는 DataTable을 복사
        //    DataTable dtCopy = dgEnemyTable.DataSource as DataTable;

        //    IEnumerable<DataRow> vSortTable = null; // 정렬된 DataRow 컬렉션을 저장할 변수

        //    // 어떤 버튼이 클릭되었는지에 따라 정렬 방법 결정
        //    switch (oBtn.Name)
        //    {
        //        case "btnLevel":
        //            // 레벨 기준 오름차순 정렬
        //            vSortTable = from oRow in dtCopy.AsEnumerable()
        //                         orderby oRow.Field<int>(sLEVEL)
        //                         select oRow;
        //            break;
        //        case "btnName":
        //            // 이름 기준 오름차순 정렬
        //            vSortTable = from oRow in dtCopy.AsEnumerable()
        //                         orderby oRow.Field<string>(sNAME)
        //                         select oRow;
        //            break;
        //        case "btnAttribute":
        //            // 속성 기준 오름차순 정렬
        //            vSortTable = from oRow in dtCopy.AsEnumerable()
        //                         orderby oRow.Field<string>(sATTRIBUTE)
        //                         select oRow;
        //            break;
        //    }

        //    // 정렬된 DataTable로 DataGridView 업데이트
        //    dtCopy = vSortTable.CopyToDataTable();
        //    dgEnemyTable.DataSource = dtCopy;
        //}

        /// <summary>
        /// 정렬 버튼 클릭 시 실행되는 이벤트 (오름차순/내림차순 토글)
        /// </summary>
        /// <param name="sender">클릭된 버튼</param>
        private void btnSort_Click(object sender, EventArgs e)
        {
            Button oBtn = sender as Button; // 클릭된 버튼 식별

            // 현재 DataGridView에 있는 DataTable을 복사
            DataTable dtCopy = dgEnemyTable.DataSource as DataTable;

            IEnumerable<DataRow> vSortTable = null; // 정렬된 DataRow 컬렉션을 저장할 변수

            // 어떤 버튼이 클릭되었는지에 따라 정렬 기준과 방향 결정
            switch (oBtn.Name)
            {
                case "btnLevel":
                    if (isAscending)
                    {
                        // 레벨 기준 오름차순 정렬
                        vSortTable = from oRow in dtCopy.AsEnumerable()
                                     orderby oRow.Field<int>(sLEVEL)
                                     select oRow;
                    }
                    else
                    {
                        // 레벨 기준 내림차순 정렬
                        vSortTable = from oRow in dtCopy.AsEnumerable()
                                     orderby oRow.Field<int>(sLEVEL) descending
                                     select oRow;
                    }
                    break;
                case "btnName":
                    if (isAscending)
                    {
                        // 이름 기준 오름차순 정렬
                        vSortTable = from oRow in dtCopy.AsEnumerable()
                                     orderby oRow.Field<string>(sNAME)
                                     select oRow;
                    }
                    else
                    {
                        // 이름 기준 내림차순 정렬
                        vSortTable = from oRow in dtCopy.AsEnumerable()
                                     orderby oRow.Field<string>(sNAME) descending
                                     select oRow;
                    }
                    break;
                case "btnAttribute":
                    if (isAscending)
                    {
                        // 속성 기준 오름차순 정렬
                        vSortTable = from oRow in dtCopy.AsEnumerable()
                                     orderby oRow.Field<string>(sATTRIBUTE)
                                     select oRow;
                    }
                    else
                    {
                        // 속성 기준 내림차순 정렬
                        vSortTable = from oRow in dtCopy.AsEnumerable()
                                     orderby oRow.Field<string>(sATTRIBUTE) descending
                                     select oRow;
                    }
                    break;
            }

            // 정렬된 DataTable로 DataGridView 업데이트
            dtCopy = vSortTable.CopyToDataTable();
            dgEnemyTable.DataSource = dtCopy;

            // 정렬 방향 토글 (오름차순 ↔ 내림차순)
            isAscending = !isAscending;
        }

        /// <summary>
        /// 필터 버튼 클릭 시 실행되는 이벤트, 속성과 레벨 범위에 따라 데이터를 필터링
        /// </summary>
        private void btnFilter_Click(object sender, EventArgs e)
        {
            // 현재 DataGridView에 있는 DataTable을 복사
            DataTable dtCopy = dgEnemyTable.DataSource as DataTable;

            // 선택된 속성과 레벨 범위에 맞는 데이터 필터링
            IEnumerable<DataRow> vSortTable = from oRow in dtCopy.AsEnumerable()
                                              where oRow.Field<string>(sATTRIBUTE) == cboxAttribute.Text &&
                                              (oRow.Field<int>(sLEVEL) >= nLevelMin.Value && oRow.Field<int>(sLEVEL) <= nLevelMax.Value)
                                              select oRow;

            // 필터링된 데이터가 있으면 DataGridView 업데이트
            if (vSortTable.Count() > 0)
            {
                dtCopy = vSortTable.CopyToDataTable();
                dgEnemyTable.DataSource = dtCopy;
            }
            else
            {
                // 필터 조건에 맞는 데이터가 없을 경우 메시지 출력
                MessageBox.Show("검색 조건에 맞는 Data가 없습니다.");
            }
        }

        /// <summary>
        /// 취소 버튼 클릭 시 실행되는 이벤트, DataGridView를 원래 데이터로 리셋
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // DataGridView를 원래 DataTable로 리셋
            dgEnemyTable.DataSource = dt;
        }
    }
}
