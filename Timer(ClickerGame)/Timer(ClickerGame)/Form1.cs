﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_ClickerGame_
{
    public partial class Form1 : Form
    {
        private double iTick = 0;
        private double iTotal = 0;

        private int i1Add = 1;
        private int i1Level = 1;

        private int i3Add = 3;
        private int i3Level = 1;

        private int i50Add = 50;
        private int i50Level = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer oTimer = new Timer();
            oTimer.Enabled = true;
            oTimer.Interval = 50;
            oTimer.Tick += OTimer_Tick;
            oTimer.Start();

        }

        /// <summary>
        /// 타이머에서 호출 할 Evnet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OTimer_Tick(object sender, EventArgs e)
        {
            iTick = i1Add + i3Add + i50Level;
            iTotal = iTotal + iTick;

            lblTickPoint.Text = string.Format("{0} (1:{1}), (3:{2}), (50:{3})", iTick.ToString(), i1Level.ToString(), i3Level.ToString(), i50Level.ToString());
            lblTotal.Text = iTotal.ToString();
        }

        /// <summary>
        /// Button을 Click 했을 경우 발생하는 Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button obtn = sender as Button; // 받아온 sender를 Button 형으로 변환

            switch (obtn.Name)
            {
                case "btn1add":
                    if (iTotal > 100)
                    {
                        iTotal = iTotal - 100;
                        i1Level++;
                        i1Add = 1* i1Level;
                    }
                    break;
                case "btn3add":
                    if (iTotal > 300)
                    {
                        iTotal = iTotal - 300;
                        i3Level++;
                        i3Add = 3 * i3Level;
                    }
                    break;
                case "btn50add":
                    if (iTotal > 5000)
                    {
                        iTotal = iTotal - 5000;
                        i50Level++;
                        i50Add = 50 * i50Level;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
