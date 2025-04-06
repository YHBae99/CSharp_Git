using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_Test
{
    public partial class fInnerMain : Form, iCommon 
    {
        
        public fInnerMain()
        {
            InitializeComponent();
        }

        private void fInnerMain_Load(object sender, EventArgs e)
        {
            fInit();
        }


        #region Interface 구현
        public string strfrmName {
            get
            {
                return this.Text;
            }
            set 
            {
                this.Text = value;
            } 
        }

        public void fColorChage(Color color)
        {
            lblInnerMain.BackColor = color;
        }

        public void fInit()
        {
            lblInnerMain.Text = $"{this.Text} Call";
        }
        #endregion

        
    }
}
