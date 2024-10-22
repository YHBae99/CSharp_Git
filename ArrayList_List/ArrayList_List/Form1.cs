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

namespace ArrayList_List
{
    public partial class Form1 : Form
    {
        // 선택된 음식 항목을 문자열로 지정할 리스트
        List<string> _strList = new List<string>();

        //ArrayList _arList = new ArrayList();

        public Form1()
        {
            InitializeComponent();

            // DataGridView에 열을 추가
            //dgViewList.Columns.Add("dgVlue", "Value");
        }

        /// <summary>
        /// Pickturebox 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbox_Click(object sender, EventArgs e)
        {
            PictureBox pBox = sender as PictureBox;

            string strSelectText = string.Empty;

            // 클릭된 PictureBox에 따라 텍스트 설정
            switch (pBox.Name)
            {
                case "pbox1":
                    strSelectText = "cake";
                    break;
                case "pbox2":
                    strSelectText = "burger";
                    break ;
                case "pbox3":
                    strSelectText = "pizza";
                    break;
                case "pbox4":
                    strSelectText = "ice";
                    break;
            }
            // 선택된 항목 텍스트를 리스트에 추가
            _strList.Add(strSelectText);

            // UI 표시 레이블 업데이트
            fUIDisplay();

            //DataGridView 표시 업데이트
            fDataGridViewDisplay();
        }

        /// <summary>
        /// 각 항목의 개수로 UI 레이블을 업데이트하는 메서드
        /// </summary>
        private void fUIDisplay()
        {
            int iCake = 0;
            int iBurger = 0;
            int iPizza  = 0;
            int iIce = 0;

            // 리스트에서 각 항목의 이벤트 발생 횟수 계산
            foreach (string oitem in _strList)
            {
                switch (oitem)
                {
                    case "cake":
                        iCake++;
                        break;
                    case "burger":
                        iBurger++;
                        break;
                    case "pizza":
                        iPizza++;
                        break;
                    case "ice":
                        iIce++;
                        break;
                }
            }
            lblPick1.Text = iCake.ToString();
            lblPick2.Text = iBurger.ToString();
            lblPick3.Text = iPizza.ToString();
            lblPick4.Text = iIce.ToString();

            lblTotalCount.Text = _strList.Count.ToString();
        }

        /// <summary>
        /// 리스트를 DataGridView에 표시하는 메서드
        /// </summary>
        private void fDataGridViewDisplay()
        {
            dgViewList.DataSource = _strList.Select(x => new { Value = x }).ToList();
            //dgViewList.Rows.Clear();

            //foreach (string oitem in _strList)
            //{
            //    dgViewList.Rows.Add(oitem);
            //}

            foreach (DataGridViewRow oRow in dgViewList.Rows)
            {
                oRow.HeaderCell.Value = oRow.Index.ToString();
            }
            dgViewList.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
