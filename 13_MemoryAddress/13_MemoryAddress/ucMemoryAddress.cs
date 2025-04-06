using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_MemoryAddress
{
    public partial class ucMemoryAddress : UserControl
    {
        string _strName = "Name";
        string _strAddress = "-";
        string _strValue = "-";


        public ucMemoryAddress()
        {
            InitializeComponent();
        }

        public string StrName { get => _strName; set => lblName.Text = _strName = value; }
        public string StrAddress { get => _strAddress; set => lblAddress.Text = _strAddress = value; }
        public string StrValue { get => _strValue; set => lblValue.Text = _strValue = value; }
    }
}
