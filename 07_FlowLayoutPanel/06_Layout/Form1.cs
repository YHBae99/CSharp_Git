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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ucCMenu 이벤트 등록
            ucCMenu.eColorAction += UcCMenu_eColorAction;

            // ucPanel 이벤트 등록
            ucPanelTop.eLabelDoubleClickHandler += UcPanel_eLabelDoubleClickHandler;
            ucPanelCenter1.eLabelDoubleClickHandler += UcPanel_eLabelDoubleClickHandler;
            ucPanelCenter2.eLabelDoubleClickHandler += UcPanel_eLabelDoubleClickHandler;
            ucPanelRight.eLabelDoubleClickHandler += UcPanel_eLabelDoubleClickHandler;
        }

        /// <summary>
        /// ucCMenu 이벤트 함수
        /// </summary>
        /// <param name="arg1">버튼 객체</param>
        /// <param name="arg2">색상 객체</param>
        private void UcCMenu_eColorAction(Button arg1, Color arg2)
        {
            string strPanelNeme = string.Empty;

            // 버튼 이름에 따라 패널의 배경색 변경 및 패널 이름 설정
            switch (arg1.Name)
            {
                case "btn1":
                    ucPanelTop.BackColor = arg2;
                    strPanelNeme = "Panel Top";
                    break;
                case "btn2":
                    ucPanelCenter1.BackColor = arg2;
                    strPanelNeme = "Panel Center1";
                    break;
                case "btn3":
                    ucPanelCenter2.BackColor = arg2;
                    strPanelNeme = "Panel Center2";
                    break;
                case "btn4":
                    ucPanelRight.BackColor = arg2;
                    strPanelNeme = "Panel Right";
                    break;
                default:
                    break;
            }

            // 로그 리스트에 결과 추가
            string strResult = string.Format("선택 : {0}, {1}의 색상을 {2}로 변경", arg1.Name, strPanelNeme, arg2.ToString());
            lboxLog.Items.Add(strResult);
        }

        /// <summary>
        /// ucPanel 이벤트 함수
        /// </summary>
        /// <param name="sender">이벤트 발생 객체</param>
        /// <param name="e">이벤트 인자</param>
        private void UcPanel_eLabelDoubleClickHandler(object sender, EventArgs e)
        {
            // 패널 더블 클릭 시 색상 변경 및 로그 추가
            string strResult = ucCMenu.fButtonColorChange((ucPanel)sender);
            lboxLog.Items.Add(strResult);
        }
    }
}
