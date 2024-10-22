using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashTable_Dictionary
{
    public partial class Form1 : Form
    {
        enum enBossName
        {
            보검,
            신혜,
            해인,
            보영,
        }

        enum enClassName
        {
            진,
            정국,
            RM,
            지민,
            제이홉,
            뷔,
            슈가,

            은비,
            사쿠라,
            혜원,
            예나,
            채연,
            채원,
            민주,
            히토미,
            유리,
            유진,
            원영,
            나코,
        }

        //List<string> _strList = new List<string>();   
        //ArrayList _arList = new ArrayList();   // ArrayList

        // 플레이어 수를 저장
        int iPlayerCount = 0;

        // HashTable의 경우 Type을 선언하지 않고 사용
        Hashtable _ht = new Hashtable();

        // Dictionary의 경우 Type을 선언하여 사용
        Dictionary<string, string> _dic = new Dictionary<string, string>();   

        public Form1()
        {
            InitializeComponent();

            // 시작 시 DataGridView의 Column을 지정
            //dgviewList.Columns.Add("dgKey", "Key");
            //dgviewList.Columns.Add("dgValue", "Value");
        }


        /// <summary>
        /// PictureBox 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbox_Click(object sender, EventArgs e)
        {
            PictureBox pbox = sender as PictureBox;

            string strSelectText = string.Empty;

            switch (pbox.Name)
            {
                case "pbox1":
                    strSelectText = enBossName.보검.ToString();
                    break;
                case "pbox2":
                    strSelectText = enBossName.신혜.ToString();
                    break;
                case "pbox3":
                    strSelectText = enBossName.해인.ToString();
                    break;
                case "pbox4":
                    strSelectText = enBossName.보영.ToString();
                    break;
            }

            //_strList.Add(strSelectText);
            //_arList.Add(strSelectText);


            // 진행하는 인원이 마지막 인원이 아닐 경우

            int iTotalCount = Enum.GetValues(typeof(enClassName)).Length;

            if (iTotalCount > iPlayerCount)
            {
                enClassName enName = (enClassName)iPlayerCount;

                _dic.Add(enName.ToString(), strSelectText);

                fUIDisplay(iTotalCount, enName.ToString());

                iPlayerCount++; // 다음 사람으로 이동

            }
            else
            {
                lblPlayerName.Text = "투표를 완료 하였습니다."; // 투표 완료 메시지 표시
            }
            //pbox1.Image = DictionaryTest.Properties.Resources._13;  /picturebox 이미지 수정 예시
        }

        private void fUIDisplay(int iTotalCount, string strPlayerName)
        {
            int i보검 = 0;
            int i신혜 = 0;
            int i해인 = 0;
            int i보영 = 0;

            // Dictionary의 값을 순회하며 각 항목의 개수를 카운트
            foreach (string oitem in _dic.Values)
            {
                switch (oitem)
                {
                    case "보검":
                        i보검++;
                        break;
                    case "신혜":
                        i신혜++;
                        break;
                    case "해인":
                        i해인++;
                        break;
                    case "보영":
                        i보영++;
                        break;
                }
            }

            lblPick1.Text = i보검.ToString();
            lblPick2.Text = i신혜.ToString();
            lblPick3.Text = i해인.ToString();
            lblPick4.Text = i보영.ToString();

            //lblTotalCount.Text = _strList.Count.ToString();

            // 총 인원 수와 현재 진행 중인 인원 수 표시 (+1은 배열이 0부터 시작하기 때문)
            lblTotalCount.Text = String.Format("{0} / {1}", iPlayerCount + 1, iTotalCount);
            lblPlayerName.Text = strPlayerName; // 현재 플레이어 이름 표시

            fDataGridViewDisplay(); // DataGridView 업데이트 호출
        }



        private void fDataGridViewDisplay()
        {
            // Dictionary의 내용을 DataGridView에 표시하도록 DataSource 설정
            dgviewList.DataSource = _dic.ToArray();

            //dgviewList.Rows.Clear();

            //// List의 값을 DataGridView에 표시
            //foreach (KeyValuePair<string, string> oitem in _dic)
            //{
            //    //dgviewList.Rows.Add(oitem);
            //    dgviewList.Rows.Add(oitem.Key, oitem.Value);
            //}

            // DataGridView의 Row Header에 인덱스를 적어줌
            foreach (DataGridViewRow oRow in dgviewList.Rows)
            {
                oRow.HeaderCell.Value = oRow.Index.ToString();
            }

            dgviewList.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
