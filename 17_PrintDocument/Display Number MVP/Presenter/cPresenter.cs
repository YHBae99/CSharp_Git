using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Display_Number_MVP
{
    class cPresenter
    {
        #region 전역변수

        readonly iView view;  // Presenter에서 연결 할 View
        readonly iModel model;   // Presenter에서 연결 할 Model

        private bool bLoopState = false;  // Thread 동작 상태 관리

        #endregion


        #region 생성자

        public cPresenter(iView view, iModel model)
        {
            this.view = view;
            this.model = model;
        }

        #endregion


        #region 화면 호출 function

        /// <summary>
        /// Thread 시작 Logic
        /// </summary>
        public void fThreadStart()
        {
            Thread tr = new Thread(fThreadMain);
            tr.Start();
        }

        /// <summary>
        /// Thread 상태 동작으로 변경
        /// </summary>
        /// <param name="tStatus"></param>
        public void fThreadRelease(bool tStatus)
        {
            view.ThreadStatus = bLoopState = tStatus;
        }

        /// <summary>
        /// Thread 상태 대기로 변경
        /// </summary>
        /// <param name="tStatus"></param>
        public void fThreadStop(bool tStatus)
        {
            view.ThreadStatus = bLoopState = tStatus;
        }

        /// <summary>
        /// 계산 결과 값 초기화 (Model 호출)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void fReset(object sender, EventArgs e)
        {
            model.fReset();

            view.Number = model.dNumber.ToString();
            view.NumberString = model.strNumberString;
        }

        #endregion


        #region Presenter Inner function
        
        /// <summary>
        /// 숫자 계산 (Model 호출)
        /// </summary>
        private void fDisplayData()
        {
            model.fNumberCal(TryGetDoubleNumber(view.Number), TryGetDoubleNumber(view.Multiple));

            view.Number = model.dNumber.ToString();
            view.NumberString = model.strNumberString;
        }

        /// <summary>
        /// Thread 동작 상태 관리
        /// </summary>
        private void fThreadMain()
        {
            while (true)
            {
                if (bLoopState)
                {
                    fDisplayData();
                }
                Thread.Sleep(TryGetIntNumber(view.ThreadTime));  // Thread 대기 Time
            }
        }

        /// <summary>
        /// String to Double
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private double TryGetDoubleNumber(string input)
        {
            return double.TryParse(input, out double res) ? res : 0;
        }

        /// <summary>
        /// String to Int
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private int TryGetIntNumber(string input)
        {
            return int.TryParse(input, out int res) ? res : 0;
        }

        #endregion

    }
}
