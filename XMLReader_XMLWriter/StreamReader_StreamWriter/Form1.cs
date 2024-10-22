using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XMLReader_XMLWriter;

namespace StreamReader_StreamWriter
{
    public partial class Form1 : Form
    {

        CXMLControl _XML = new CXMLControl();
        Dictionary<string, string> _dDate = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfigSet_Click(object sender, EventArgs e)
        {
            string strEnter = "\r\n";

            string strText = tboxData.Text;
            bool bChecked = cboxData.Checked;
            int iNumber = (int)numData.Value;

            StringBuilder sb = new StringBuilder();
            sb.Append(strText + strEnter);
            sb.Append(bChecked.ToString() + strEnter);
            sb.Append(iNumber.ToString());

            tboxConfigData.Text = sb.ToString();

            _dDate.Clear();

            _dDate.Add(CXMLControl._TEXT_DATA, strText);
            _dDate.Add(CXMLControl._CBOX_DATA, bChecked.ToString());
            _dDate.Add(CXMLControl._NUMBER_DATA, iNumber.ToString());
        }

        private void btnConfigRead_Click(object sender, EventArgs e)
        {
            //string[] strConfig = tboxConfigData.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            //tboxData.Text = strConfig[0];
            //cboxData.Checked = bool.Parse(strConfig[1]);
            //numData.Value = int.Parse(strConfig[2]);

            tboxData.Text = _dDate[CXMLControl._TEXT_DATA];
            cboxData.Checked = bool.Parse(_dDate[CXMLControl._CBOX_DATA]);
            numData.Value = int.Parse(_dDate[CXMLControl._NUMBER_DATA]);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;

            OFDialog.InitialDirectory = Application.StartupPath;
            OFDialog.FileName = "*.xml";
            OFDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";

            StringBuilder sb = new StringBuilder();

            if (OFDialog.ShowDialog() == DialogResult.OK)
            {
                strFilePath = OFDialog.FileName;
                sb.Append(File.ReadAllText(strFilePath));
                tboxConfigData.Text = sb.ToString();

                _dDate.Clear();
                _dDate = _XML.fXML_Reader(strFilePath);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;

            SFDialog.InitialDirectory = Application.StartupPath;
            SFDialog.FileName = "*.xml";
            SFDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";

            if (SFDialog.ShowDialog() == DialogResult.OK)
            {
                strFilePath = SFDialog.FileName;
                File.WriteAllText(strFilePath, tboxConfigData.Text);
            }
            _XML.fXML_Writer(strFilePath, _dDate);
        }
    }
}
