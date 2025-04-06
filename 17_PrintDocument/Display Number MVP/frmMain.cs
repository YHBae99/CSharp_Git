using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Display_Number_MVP
{
    public partial class frmMain : Form, iView
    {

        #region 전역변수

        cPresenter cPre;  //Presenter Logic

        /// <summary>
        /// View 속성들
        /// </summary>
        public string ThreadTime  // Thread 주기 전달
        {
            get => tboxThreadTime.Text;
        }
        public string Multiple  // Number 배율 전달
        {
            get => tboxMultiple.Text;
        }
        public bool ThreadStatus  // Thread 상태 표시 (Thread Invoke 추가)
        {
            set
            {
                this.Invoke(new Action(delegate ()
                {
                    lblThreadStatus.Text = value.ToString();
                }));
            }
        }
        public string Number   // 대상 숫자 전달 및 결과 값 표시 (Thread Invoke 추가)
        {
            get => lblNumber.Text;
            set
            {
                this.Invoke(new Action(delegate ()
                {
                    lblNumber.Text = value;
                }));
            }
        }
        public string NumberString    // 대상 숫자 계산 후 문자 값 표시 (Thread Invoke 추가)
        {
            set
            {
                this.Invoke(new Action(delegate ()
                {
                    lblNumberString.Text = value;
                }));
            }
        }

        #endregion


        #region 진입점

        public frmMain()
        {
            InitializeComponent();
        }

        #endregion


        #region Form Event

        /// <summary>
        /// Form Load Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            cPre = new cPresenter(this, new cModel());  // 시작 시 Presenter 생성
            cPre.fThreadStart();  // 시작 시 Thread는 시작해 놓고 상태로 관리
        }

        /// <summary>
        /// Button Start Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            cPre.fThreadRelease(true);  // Thread 상태 : True (Presenter에서만 처리)
        }

        /// <summary>
        /// Button Stop Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            cPre.fThreadStop(false);   // Thread 상태 : False (Presenter에서만 처리)
        }

        /// <summary>
        /// Button Reset Eevent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            cPre.fReset(this, e);   // 결과 값 초기화 (Model 에서 처리)
        }

        #endregion

    }
}
