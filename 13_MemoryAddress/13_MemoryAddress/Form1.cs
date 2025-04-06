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
    public partial class Form1 : Form
    {
        cCopySample cOrg;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 원본 데이터
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrigin_Click(object sender, EventArgs e)
        {
            cOrg = new cCopySample();
            cOrg.iCopy = int.Parse(tboxInt.Text);
            cOrg.charCopy = char.Parse(tboxChar.Text);
            cOrg.arrCopy = new int[] { int.Parse(tboxIntArray.Text), 0, 0, 0, 0 };
            cOrg.clsCopy.iValue = int.Parse(tboxClassNumber.Text);

            lblOriginData.Text = $"{cOrg.iCopy}, {cOrg.charCopy}, [{String.Join(",", cOrg.arrCopy)}], {cOrg.clsCopy.iValue}";
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (rdoEqual.Checked)
            {
                gbox.Text = "a = b";
                fEqual();
            }
            else if (rdoSallowCopy.Checked)
            {
                gbox.Text = "Shallow Copy";
                fShallowCopy();
            }
            else if (rdoDeepCopy.Checked)
            {
                gbox.Text = "Deep Copy";
                fDeepCopy();
            }
        }

        public void fEqual()
        {
            cCopySample cOrgRef = cOrg;   // 참조
            fCopy(cOrgRef);
        }

        public void fShallowCopy()
        {
            cCopySample cShallow = (cCopySample)cOrg.ShallowCopy();   // 얕은복사
            fCopy(cShallow);
        }

        public void fDeepCopy()
        {
            cCopySample cDeep = (cCopySample)cOrg.Clone();   // 깊은복사
            fCopy(cDeep);
        }



        private void fCopy(cCopySample cData)
        {
            cData.iCopy = int.Parse(tboxInt.Text);
            cData.charCopy = char.Parse(tboxChar.Text);
            cData.arrCopy[0] = int.Parse(tboxIntArray.Text);
            cData.clsCopy.iValue = int.Parse(tboxClassNumber.Text);

            lblCopyData.Text = $"{cData.iCopy}, {cData.charCopy}, [{String.Join(",", cData.arrCopy)}], {cData.clsCopy.iValue}";

            // 변경 후 Org Data
            lblOrgData.Text = $"{cOrg.iCopy}, {cOrg.charCopy}, [{String.Join(",", cOrg.arrCopy)}], {cOrg.clsCopy.iValue}";

            unsafe
            {
                #region Origin
                // Int
                fixed (int* p = &cOrg.iCopy)
                {
                    ucOrg1.StrName = "Int";
                    ucOrg1.StrAddress = ((long)p).ToString();
                    ucOrg1.StrValue = (*p).ToString();
                }

                // Char
                fixed (char* p = &cOrg.charCopy)
                {
                    ucOrg2.StrName = "Char";
                    ucOrg2.StrAddress = ((long)p).ToString();
                    ucOrg2.StrValue = (*p).ToString();
                }

                // Array
                fixed (int* p = &cOrg.arrCopy[0])
                {
                    ucOrg3.StrName = "Array";
                    ucOrg3.StrAddress = ((long)p).ToString();
                    ucOrg3.StrValue = (*p).ToString();
                }

                // Class
                fixed (int* p = &cOrg.clsCopy.iValue)
                {
                    ucOrg4.StrName = "Class";
                    ucOrg4.StrAddress = ((long)p).ToString();
                    ucOrg4.StrValue = (*p).ToString();
                }
                #endregion

                #region Copy
                // Int
                fixed (int* p = &cData.iCopy)
                {
                    ucCopy1.StrName = "Int";
                    ucCopy1.StrAddress = ((long)p).ToString();
                    ucCopy1.StrValue = (*p).ToString();
                }

                // Char
                fixed (char* p = &cData.charCopy)
                {
                    ucCopy2.StrName = "Char";
                    ucCopy2.StrAddress = ((long)p).ToString();
                    ucCopy2.StrValue = (*p).ToString();
                }

                // Array
                fixed (int* p = &cData.arrCopy[0])
                {
                    ucCopy3.StrName = "Array";
                    ucCopy3.StrAddress = ((long)p).ToString();
                    ucCopy3.StrValue = (*p).ToString();
                }

                // Class
                fixed (int* p = &cData.clsCopy.iValue)
                {
                    ucCopy4.StrName = "Class";
                    ucCopy4.StrAddress = ((long)p).ToString();
                    ucCopy4.StrValue = (*p).ToString();
                }
                #endregion

            }

        }
    }
}