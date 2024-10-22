using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FartialClass
{
    public partial class Form1 : Form
    {
        CData _Data = new CData();
        private double totalPrice = 0.0;

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Form1 을 로드 하는 시점에 ComboBox에 Data 입력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // 물건 List
            EnumItem[] enumItemList = (EnumItem[])Enum.GetValues(typeof(EnumItem));
            // 할인율 List
            EnumRate[] enumRateList = (EnumRate[])Enum.GetValues(typeof(EnumRate));

            foreach (EnumItem enumItem in enumItemList)
            {
                cBoxItem.Items.Add(enumItem.ToString());
            }

            foreach (EnumRate enumRate in enumRateList)
            {
                cBoxRate.Items.Add(enumRate.ToString());
            }

        }

        /// <summary>
        /// 담기 버튼을 click 하였을 경우 cData Class에 Form setting 된 값을 넣어주고 계산
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _Data.fDataResult();

            _Data.StrItem = cBoxItem.Text;
            _Data.iRate = (int)Enum.Parse(typeof(EnumRate),cBoxRate.Text);
            _Data.ICount = (int)numCount.Value;

            if (!string.IsNullOrEmpty(_Data.StrErrorName))
            {
                tboxErrorMsg.Text = _Data.StrErrorName;
                return;
            }

            double dPrice = _Data.fItemPrice();
            lboxItem.Items.Add(_Data.fResult(dPrice));

            totalPrice += dPrice;
            tboxResult.Text = dPrice.ToString() + "원";
            tboxResult2.Text = "총 " + totalPrice.ToString() + "원";

        }

        private void btnResset_Click(object sender, EventArgs e)
        {
            // 데이터 초기화
            _Data.fDataResult();
            tboxResult.Text = string.Empty;
            tboxResult2.Text = string.Empty;
            tboxErrorMsg.Text = string.Empty;
            totalPrice = 0.0;
            lboxItem.Items.Clear();
        }
    }
}
