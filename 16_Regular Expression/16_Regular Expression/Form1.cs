using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_Regular_Expression
{
    public partial class Form1 : Form
    {
        DataTable _dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegTableSetting();  // 화면 초기화 진행 시 DataTable에 정규식 값을 세팅해 줌 (DB와 연동하면 사용자가 등록해서 사용해도 될듯)
        }


        /// <summary>
        /// Check Button을 Click 했을 때 선택 된 Radio Button에 따른 정규식 비교
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDataCheck_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(lblData.Text);

            if (rdoMatch.Checked)
            {
                Match mData = regex.Match(tboxCheckData.Text);

                if (mData.Success)
                {
                    int iPosition = mData.Index;
                    string sValue = mData.Value.ToString();
                    lblResult.Text = "OK";
                    lblErrorMessage.Text = $"[{iPosition}]위치에서 [{sValue}]값을 찾았습니다.";
                }
                else
                {
                    lblResult.Text = "NG";
                    lblErrorMessage.Text = "정규식과 일치하는 Data가 없습니다.";
                }
            }
            else if (rdoIsMatch.Checked)
            {
                // 정규식에 지정된 문자가 있는지 확인
                if (regex.IsMatch(tboxCheckData.Text))
                {
                    lblResult.Text = "OK";
                    lblErrorMessage.Text = "사용 가능 합니다.";
                }
                else
                {
                    lblResult.Text = "NG";
                    lblErrorMessage.Text = $"[{tboxCheckData.Text}]는 사용 할 수 없는 형식 입니다. ▶ 사용 가능 예제 : {lblSample.Text}";
                }
            }
            else if (rdoSplit.Checked)
            {
                string[] sData = regex.Split(tboxCheckData.Text);
                string sResult = string.Join(" ", sData);

                if (sResult != "")
                {
                    lblResult.Text = "OK";
                    lblErrorMessage.Text = $"결과 : {sResult}";
                }
                else
                {
                    lblResult.Text = "NG";
                    lblErrorMessage.Text = "정규식과 일치하는 Data가 없습니다.";
                }
            }
            else if (rdoReplace.Checked)
            {
                string sData = regex.Replace(tboxCheckData.Text, tboxReplace.Text);

                if (sData != "")
                {
                    lblResult.Text = "OK";
                    lblErrorMessage.Text = $"결과 : {sData}";
                }
                else
                {
                    lblResult.Text = "NG";
                    lblErrorMessage.Text = "정규식과 일치하는 Data가 없습니다.";
                }

            }
        }


        /// <summary>
        /// 참고용 Data Table 생성
        /// </summary>
        private void RegTableSetting()
        {
            _dt = new DataTable("regexTable");

            //DataColumn 생성
            DataColumn colregName = new DataColumn("Name", typeof(string));
            DataColumn colregData = new DataColumn("Data", typeof(string));
            DataColumn colregSample = new DataColumn("Sample", typeof(string));

            //생성된 Column을 DataTable에 Add
            _dt.Columns.Add(colregName);
            _dt.Columns.Add(colregData);
            _dt.Columns.Add(colregSample);

            // 생성된 Table에 Row 작성
            _dt.Rows.Add(regexDataRow(_dt.NewRow(), "ETC_문자열체크", @"List<\w+>", @"List<변수> 가 있는지를 비교"));
            _dt.Rows.Add(regexDataRow(_dt.NewRow(), "ETC_지정문자", @"(D|d)ori", @"Dori, dori를 찾음"));
            _dt.Rows.Add(regexDataRow(_dt.NewRow(), "ETC_문자만", @"\D+", "12 54 78 5 9"));
            _dt.Rows.Add(regexDataRow(_dt.NewRow(), "IsMatch_전화번호", @"^01[01678]-[0-9]{4}-[0-9]{4}$", "000-0000-0000"));
            _dt.Rows.Add(regexDataRow(_dt.NewRow(), "IsMatch_이름(한글3자리)", @"^[가-힣]{3}$", "홍길동"));
            _dt.Rows.Add(regexDataRow(_dt.NewRow(), "IsMatch_숫자만", @"^[0-9]", "1234567890"));
            _dt.Rows.Add(regexDataRow(_dt.NewRow(), "IsMatch_영어만", @"^[a-zA-Z]", "abcdEFGH"));
            _dt.Rows.Add(regexDataRow(_dt.NewRow(), "IsMatch_URL주소", @"(http|https)://([\w-]+\.)+[\w-]+(/[\w-./?%&=]*)?", "https://cwkcw.tistory.com/"));
            _dt.Rows.Add(regexDataRow(_dt.NewRow(), "IsMatch_주민등록번호", @"[0-9][0-9][01][0-9][0123][0-9]-[1234][0-9]{6}", "000000-1000000"));
            _dt.Rows.Add(regexDataRow(_dt.NewRow(), "IsMatch_특수문자제외", @"^[a-zA-Z0-9ㄱ-힣]*$", "abcd가나다라1234"));

            dgRegex.DataSource = _dt;
            dgRegex.AutoResizeColumns();

        }


        /// <summary>
        /// Data Row 생성
        /// </summary>
        /// <param name="dr"></param>
        /// <param name="sName"></param>
        /// <param name="sData"></param>
        /// <param name="sSample"></param>
        /// <returns></returns>
        private DataRow regexDataRow(DataRow dr, string sName, string sData, string sSample)
        {
            cboxRegexName.Items.Add(sName); // ComboBox Setting

            dr["Name"] = sName;
            dr["Data"] = sData;
            dr["Sample"] = sSample;

            return dr;
        }


        /// <summary>
        /// cbox 값이 변경 될 경우 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboxRegexName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow[] dRow = _dt.Select($"Name = '{cboxRegexName.SelectedItem}'");

            lblData.Text = dRow[0]["Data"].ToString();
            lblSample.Text = dRow[0]["Sample"].ToString();
        }

    }
}
