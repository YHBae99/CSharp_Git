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
    public partial class ucPanel : UserControl
    {
        // 레이블 더블 클릭 이벤트 핸들러 선언
        public event EventHandler eLabelDoubleClickHandler;

        public ucPanel()
        {
            InitializeComponent(); // 사용자 컨트롤 초기화
        }

        // 패널 크기 변경 시 호출되는 이벤트 핸들러
        private void PanelSizeChanged(object sender, EventArgs e)
        {
            // 레이블에 패널의 너비와 높이를 표시
            lblPanel.Text = string.Format("({0},{1})", lblPanel.Width, lblPanel.Height);
        }

        // 레이블 클릭 시 호출되는 이벤트 핸들러
        private void lblPanel_Click(object sender, EventArgs e)
        {
            // 레이블 더블 클릭 이벤트 발생
            eLabelDoubleClickHandler(this, e);
        }
    }
}