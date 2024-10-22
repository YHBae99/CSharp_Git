using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyThread
{
    public partial class Form1 : Form
    {
        private enum enumPlayer
        {
            아이린,
            슬기,
            웬디,
            조이,
            예리,
        }

        // 폼의 위치를 저장할 변수 선언
        int _locationX = 0;
        int _locationY = 0;

        public Form1()
        {
            InitializeComponent();

            _locationX = this.Location.X;
            _locationY = this.Location.Y;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // 폼의 새로운 위치 설정 (현재 위치 + 폼의 너비)
            _locationX = this.Location.X + this.Size.Width;
            _locationY = this.Location.Y;

            for (int i = 0; i < numPlayerCount.Value; i++)
            {
                Play pl = new Play(((enumPlayer)i).ToString()); // 플레이어 객체 생성 (열거형을 문자열로 변환하여 전달)
                pl.Location = new Point(_locationX, _locationY + pl.Height * i);    // 플레이어 폼의 위치 설정
                pl.eventdelMessage += Pl_eventdelMessage;   // 이벤트 핸들러 등록

                pl.Show();

                pl.fThreadStart();
            }


        }

        private int Pl_eventdelMessage(object sender, string strResult)
        {
            if (this.InvokeRequired)
            {

                // UI 스레드에서 안전하게 호출하기 위해 Invoke 사용
                this.Invoke(new Action(delegate ()
                {
                    // sender를 Play 타입으로 캐스팅하여 플레이어 이름과 결과 메시지를 리스트박스에 추가
                    Play oPlayerForm = sender as Play;

                    lboxResult.Items.Add(string.Format("Player : {0}, Text : {1}", oPlayerForm.StrPlayerName, strResult));
                }));

            }

            return 0;
        }
    }
}
