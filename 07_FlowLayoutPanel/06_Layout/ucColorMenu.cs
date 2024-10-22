using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_Layout
{
    public partial class ucColorMenu : UserControl
    {
        // 1) Delegate Event 선언
        public delegate void delColorSender(object oSender, Color oColor);
        public event delColorSender eColorSender;

        // 2) 기본 EventHandler
        public event EventHandler oColorEventHandler;

        // 3) 제네릭 형태의 delegate 사용
        public event Action<Button, Color> eColorAction;


        public ucColorMenu()
        {
            InitializeComponent(); // 컨트롤 초기화
        }


        /// <summary>
        /// 컨트롤 로드 이벤트
        /// </summary>
        /// <param name="sender">이벤트 발생 객체</param>
        /// <param name="e">이벤트 인자</param>
        private void ucColorMenu_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 5; i++)
            {
                Button obtn = new Button();

                obtn.Name = "btn" + i; // 버튼 이름 설정
                obtn.Text = string.Format("P{0} 색상 변경", i); // 버튼 텍스트 설정
                obtn.BackColor = Color.Gray; // 버튼 배경색 설정
                obtn.Margin = new Padding(10, 20, 0, 0); // 버튼 여백 설정
                obtn.Size = new Size(100, 30); // 버튼 크기 설정
                obtn.Click += Obtn_Click; // 버튼 클릭 이벤트 핸들러 등록

                flpMenu.Controls.Add(obtn); // 메뉴에 버튼 추가
            }
        }

        /// <summary>
        /// 버튼 클릭 이벤트 함수
        /// </summary>
        /// <param name="sender">이벤트 발생 객체</param>
        /// <param name="e">이벤트 인자</param>
        private void Obtn_Click(object sender, EventArgs e)
        {
            eColorAction((Button)sender, pColor.BackColor);    // 제네릭 형태의 delegate 사용하여 색상 변경 이벤트 발생시킴
        }


        /// <summary>
        /// PColor 클릭 이벤트 함수
        /// </summary>
        /// <param name="sender">이벤트 발생 객체</param>
        /// <param name="e">이벤트 인자</param>
        private void pColor_Click(object sender, EventArgs e)
        {
            DialogResult dRet = cDialogColor.ShowDialog();  // ColorDialog를 불러서 선택한 뒤 결과 값까지 받아 옴

            if (dRet == DialogResult.OK)   // 결과 값이 정상일 때 선택된 Color를 Panel에 적용함
            {
                pColor.BackColor = cDialogColor.Color;
            }
        }



        /// <summary>
        /// 외부에서 Color Button의 색상을 변경하기 위한 Public Function
        /// </summary>
        /// <param name="oPanel">패널 객체</param>
        /// <returns>결과 문자열</returns>
        public string fButtonColorChange(ucPanel oPanel)
        {
            string strResult = string.Empty;
            string strbtnName = string.Empty;

            switch (oPanel.Name)
            {
                case "ucPanelTop":
                    strbtnName = "btn1";
                    break;
                case "ucPanelCenter1":
                    strbtnName = "btn2";
                    break;
                case "ucPanelCenter2":
                    strbtnName = "btn3";
                    break;
                case "ucPanelRight":
                    strbtnName = "btn4";
                    break;
                default:
                    break;
            }

            strResult = fBtnSearch(strbtnName, oPanel.BackColor, oPanel.Name);
            return strResult;
        }


        /// <summary>
        /// FlowLayoutPanel에서 원하는 Control을 찾아오기 위한 함수
        /// </summary>
        /// <param name="strButtonName">버튼 이름</param>
        /// <param name="oColor">색상 객체</param>
        /// <param name="strPanelName">패널 이름</param>
        /// <returns>결과 문자열</returns>
        private string fBtnSearch(string strButtonName, Color oColor, string strPanelName)
        {
            string strResult = string.Empty;

            foreach (var oitem in flpMenu.Controls)
            {
                if (oitem is Button)
                {
                    Button obtn = oitem as Button;

                    if (obtn.Name.Equals(strButtonName))
                    {
                        obtn.BackColor = oColor;
                        strResult = string.Format("{0} Panel DoubleClick, {1}의 색상을 {2}로 변경", strPanelName, strButtonName, oColor.ToString());
                        return strResult;
                    }
                }
            }

            return null;
        }

    }
}
