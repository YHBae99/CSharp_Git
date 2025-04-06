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

namespace _15_Parallel_T
{
    public partial class Form1 : Form
    {
        #region Enum
        /// <summary>
        /// Case문 관련 enum
        /// </summary>
        enum enCase
        {
            nfor,
            pfor,
            pforeach,
            pfunction,
        }
        #endregion



        #region 
        private int _iThreadSleepTime = 10;  // Thread Sleep

        private int _iforStart = 0;   // for Start
        private int _iforCount = 100;  // for Count

        DateTime sTime;  // Thread 시작 시간을 가져오기 위함 Function
        #endregion



        public Form1()
        {
            InitializeComponent();
        }



        #region Event 

        /// <summary>
        /// 일반 For 문
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnfor_Click(object sender, EventArgs e)
        {
            pThread(enCase.nfor);
        }


        /// <summary>
        /// Parallel For 문
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPararallfor_Click(object sender, EventArgs e)
        {
            pThread(enCase.pfor);  // UI에서 바로 작업 할 경우 Event와 Parallel문의 경우 충돌이 발생 할 확률이 크기 때문에 별도 Thread를 구성해서 동작 하도록 함
        }


        /// <summary>
        /// Parallel Foreach 문
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParallelforeach_Click(object sender, EventArgs e)
        {
            pThread(enCase.pforeach);
        }


        /// <summary>
        /// Parallel function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParallelFunction_Click(object sender, EventArgs e)
        {
            pThread(enCase.pfunction);
        }

        #endregion



        #region Main Thread 

        private void pThread(enCase eCase)
        {
            sTime = DateTime.Now;
            Log(lboxPlayTime, enLogLevel.Info, $"Thread Start");

            Thread tCase;

            switch (eCase)
            {
                case enCase.nfor:
                    tCase = new Thread(fnfor);
                    tCase.Start();
                    break;
                case enCase.pfor:
                    tCase = new Thread(fpfor);
                    tCase.Start();
                    break;
                case enCase.pforeach:
                    tCase = new Thread(fpforeach);
                    tCase.Start();
                    break;
                case enCase.pfunction:
                    tCase = new Thread(fpfunction);
                    tCase.Start();
                    break;
                default:
                    break;
            }
        }

        #endregion



        #region innerfunction

        /// <summary>
        /// 일반 for 문
        /// </summary>
        private void fnfor()
        {
            for (int i = _iforStart; i < _iforCount; i++)
            {
                Log(enLogLevel.Info, $"for : {i}");
                Thread.Sleep(_iThreadSleepTime);
            }

            DateTime eTime = DateTime.Now;
            Log(lboxPlayTime, enLogLevel.Info, $"Thread End : {eTime - sTime}");
        }


        /// <summary>
        /// Parallel for 문 (여러 형태로 사용 가능)
        /// </summary>
        private void fpfor()
        {
            int iTotal = 0;

            // 람다식
            Parallel.For(_iforStart, _iforCount, i =>
            {
                //Log(enLogLevel.Info, $"pfor(람다) : {iTotal} + {i} = {iTotal = iTotal + i}");  // 순서를 보장하지 않음
                Log(enLogLevel.Info, $"pfor(람다) : {i}");
                Thread.Sleep(_iThreadSleepTime);
            });

            DateTime eTime = DateTime.Now;
            Log(lboxPlayTime, enLogLevel.Info, $"Thread End : {eTime - sTime}");
        }


        /// <summary>
        /// Parallel foreach 문 (배열 선언 후 사용)
        /// </summary>
        private void fpforeach()
        {
            //List<int> iList = (Enumerable.Repeat(i++, 10)).ToList<int>();   // 선언 하면서 같은 수로 초기화 하는 법
            List<int> iList = (Enumerable.Range(_iforStart, _iforCount)).ToList<int>();   // 선언 하면서 순차적으로 값을 넣는 법

            Parallel.ForEach(iList, i =>
            {
                Log(enLogLevel.Info, $"pforeach(람다) : {i}");
                Thread.Sleep(_iThreadSleepTime);
            });

            DateTime eTime = DateTime.Now;

            Log(lboxPlayTime, enLogLevel.Info, $"Thread End : {eTime - sTime}");
        }


        /// <summary>
        /// parallel function (다중 함수 호출)
        /// </summary>
        private void fpfunction()
        {
            Parallel.Invoke(
                fpfor,
                fpforeach
            );
        }

        #endregion



        #region Log Viewer 

        // Log Level을 지정 할 Enum (44강 Tree View 참조)
        enum enLogLevel
        {
            Info,
            Warning,
            Error,
        }

        private void Log(enLogLevel eLevel, string LogDesc)
        {
            this.Invoke(new Action(delegate ()
            {
                DateTime dTime = DateTime.Now;
                string LogInfo = $"{dTime:yyyy-MM-dd hh:mm:ss.fff} [{eLevel.ToString()}] {LogDesc}";
                lboxLog.Items.Insert(0, LogInfo);
                Refresh();
            }));
        }

        //private void Log(DateTime dTime, enLogLevel eLevel, string LogDesc)
        //{
        //    this.Invoke(new Action(delegate ()
        //    {
        //        string LogInfo = $"{dTime:yyyy-MM-dd hh:mm:ss.fff} [{eLevel.ToString()}] {LogDesc}";
        //        lboxLog.Items.Insert(0, LogInfo);
        //    }));
        //}

        /// <summary>
        /// List Box Control 추가
        /// </summary>
        /// <param name="lbox"></param>
        /// <param name="eLevel"></param>
        /// <param name="LogDesc"></param>
        private void Log(ListBox lbox, enLogLevel eLevel, string LogDesc)
        {
            this.Invoke(new Action(delegate ()
            {
                DateTime dTime = DateTime.Now;
                string LogInfo = $"{dTime:yyyy-MM-dd hh:mm:ss.fff} [{eLevel.ToString()}] {LogDesc}";
                lbox.Items.Insert(0, LogInfo);
            }));
        }

        #endregion

    }
}
