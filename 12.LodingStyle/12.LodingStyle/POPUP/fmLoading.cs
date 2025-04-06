using _12.LodingStyle.cGlobal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12.LodingStyle.POPUP
{
    public partial class fmLoading : Form
    {
        System.Windows.Forms.Timer _tm;

        public fmLoading()
        {
            InitializeComponent();
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            pALL.Controls.Add(cGlobalValue.uGlobal);

            _tm = new System.Windows.Forms.Timer();
            _tm.Interval = 100;
            _tm.Tick += _tm_Tick;
            _tm.Start();
        }

        private void _tm_Tick(object sender, EventArgs e)
        {
            bool bEndCheck = false;
            int iPer = pBar.Value;

            Random rd = new Random();

            iPer = iPer + rd.Next(5);

            if (iPer > 100)
            {
                iPer = 100;
                bEndCheck = true;
            }

            pBar.Value = iPer;
            lblNow.Text = iPer.ToString();

            if (bEndCheck) _tm.Stop();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pALL.Controls.Clear();

            this.Close();
        }
    }
}
