using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTable_DataSet
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            bool bCheckIsTable = false;

            if (ds.Tables.Contains(cboxRegClass.Text))
            {
                bCheckIsTable = true;
            }

            DataTable dt = null;

            if (!bCheckIsTable)
            {
                dt = new DataTable(cboxRegClass.Text);

                DataColumn colName = new DataColumn("NAME", typeof(string));
                DataColumn colSex = new DataColumn("SEX", typeof(string));
                DataColumn colRef = new DataColumn("REF", typeof(string));

                dt.Columns.Add(colName);
                dt.Columns.Add(colSex);
                dt.Columns.Add(colRef);
            }
            else
            {
                dt = ds.Tables[cboxRegClass.Text];
            }

            DataRow row = dt.NewRow();
            row["NAME"] = tboxRegName.Text;

            if (rdoRegSexFemale.Checked)
            {
                row["SEX"] = "여자";
            }
            else if (rdoRegSexMale.Checked)
            {
                row["SEX"] = "남자";
            }
            row["REF"] = tboxRegRef.Text;

            if (bCheckIsTable)
            {
                ds.Tables[cboxRegClass.Text].Rows.Add(row);
            }
            else
            {
                dt.Rows.Add(row);
                ds.Tables.Add(dt);
            }
            cboxViewClass_SelectedIndexChanged(this, null);
        }

        private void btnViewDataDel_Click(object sender, EventArgs e)
        {
            // 선택된 행이 있는지 확인
            if (dgViewInfo.SelectedRows.Count > 0)
            {
                int iSelectRow = dgViewInfo.SelectedRows[0].Index;

                // 선택된 행의 인덱스가 유효한지 확인
                if (iSelectRow >= 0 && iSelectRow < ds.Tables[cboxViewClass.Text].Rows.Count)
                {
                    ds.Tables[cboxViewClass.Text].Rows.RemoveAt(iSelectRow);
                    cboxViewClass_SelectedIndexChanged(this, null);
                }
            }
            else
            {
                MessageBox.Show("삭제할 행을 선택하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void btnViewDataDel_Click(object sender, EventArgs e)
        //{
        //    int iSelectRow = dgViewInfo.SelectedRows[0].Index;
        //    ds.Tables[cboxViewClass.Text].Rows.RemoveAt(iSelectRow);

        //    cboxViewClass_SelectedIndexChanged(this, null);
        //}

        private void cboxViewClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgViewInfo.DataSource = ds.Tables[cboxViewClass.Text];


            // DatagridView Cell 정렬 및 Number를 적용
            foreach (DataGridViewRow oRow in dgViewInfo.Rows)
            {
                oRow.HeaderCell.Value = oRow.Index.ToString();
            }
            dgViewInfo.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tboxRegName.Text))
            {
                foreach (DataRow oitem in ds.Tables[cboxRegClass.Text].Rows)
                {
                    if (oitem["NAME"].Equals(tboxRegName.Text))
                    {
                        if (rdoRegSexFemale.Checked)
                        {
                            oitem["SEX"] = "여자";
                        }
                        else if (rdoRegSexMale.Checked)
                        {
                            oitem["SEX"] = "남자";
                        }
                    }
                    cboxViewClass_SelectedIndexChanged(this, null);
                }
            }
        }
    }
}
