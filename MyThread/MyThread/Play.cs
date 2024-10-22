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

namespace MyThread
{
    public partial class Play : Form
    {
        // 메시지를 전달하기 위한 델리게이트 및 이벤트 정의
        public delegate int delMessage(object sender, string strResult);
        public event delMessage eventdelMessage;

        // 플레이어 이름을 저장하는 문자열 변수
        string _strPlayerName = string.Empty;
        public string StrPlayerName { get => _strPlayerName; set => _strPlayerName = value; }

        
        Thread _thread = null;  // 스레드 객체
        bool _stopRequested = false;  // 스레드를 중지하기 위한 플래그

        public Play()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 플레이어 이름을 매개변수로 받는 생성자
        /// </summary>
        /// <param name="strPlayerName"></param>
        public Play(string strPlayerName) : this()
        {
            lblPlayerName.Text = StrPlayerName = strPlayerName;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _stopRequested = true; // 스레드 중지 요청
        }

        /// <summary>
        /// 스레드 시작 메서드
        /// </summary>
        public void fThreadStart()
        {
            _stopRequested = false; // 스레드 시작 시 중지 요청 초기화
            _thread = new Thread(Run);  // 새로운 스레드 생성, Run 실행
            _thread.Start();
        }

        /// <summary>
        /// 스레드 실행 메서드
        /// </summary>
        private void Run()
        {
            int ivar = 0;
            Random rd = new Random();

            // 프로그레스 바가 100이 되거나 중지 요청이 있을 때까지 반복
            while (pbarPlayer.Value < 100 && !_stopRequested)
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(delegate ()
                    {
                        ivar = rd.Next(1, 11); // 1부터 10 사이의 랜덤 값 생성

                        if (pbarPlayer.Value + ivar > 100)
                        {
                            pbarPlayer.Value = 100; // 프로그레스 바 최대값 설정
                        }
                        else
                        {
                            pbarPlayer.Value += ivar; // 프로그레스 바 값 증가
                        }

                        lblProcess.Text = string.Format("진행 상황 표시 : {0}%", pbarPlayer.Value); // 진행 상황 업데이트
                        this.Refresh(); // 폼 갱신
                    }));

                    Thread.Sleep(300); // 300밀리초 대기
                }
            }

            if (_stopRequested)
            {
                eventdelMessage?.Invoke(this, "포기했습니다.");
            }
            else
            {
                eventdelMessage?.Invoke(this, "완주!! (Thread Complete)");
            }
        }
    }
}
