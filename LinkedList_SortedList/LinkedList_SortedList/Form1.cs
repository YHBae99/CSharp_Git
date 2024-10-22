using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedList_SortedList
{
    public partial class Form1 : Form
    {
        // SortedList는 날짜(DateTime)를 키로, 문자열(string)을 값으로 하는 일정 관리용 리스트
        SortedList<DateTime, string> slScheduler = new SortedList<DateTime, string>();

        // Dictionary는 날짜(DateTime)를 키로, 문자열(string)을 값으로 가지는 일정 관리용 사전
        //Dictionary<DateTime, string> dScheduler = new Dictionary<DateTime, string>();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// btnScheduler 버튼 클릭 시 실행되는 이벤트 핸들러
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScheduler_Click(object sender, EventArgs e)
        {
            // Linked List 예제 코드
            //LinkedList<string> sLinkTest = new LinkedList<string>();

            //for (int i = 0; i < 10; i++)
            //{
            //    sLinkTest.AddLast(i.ToString());
            //}

            //var findnode = sLinkTest.Find("5");
            //sLinkTest.AddAfter(findnode, "NewValue");

            // 날짜(DateTime) 선택 처리
            DateTime dSetDate = mcScheduler.SelectionStart;

            // slScheduler에 선택한 날짜가 포함되지 않았을 경우 추가
            if (!slScheduler.ContainsKey(dSetDate))
            {
                // 선택한 날짜와 입력한 일정을 추가
                slScheduler.Add(dSetDate, tboxScheduler.Text);

                // 선택한 날짜를 볼드 처리하여 표시
                mcScheduler.AddBoldedDate(dSetDate);
                mcScheduler.UpdateBoldedDates();

                // 리스트 박스에 일정을 추가
                //lboxScheduler.Items.Add(string.Format("{0} : {1}", dSetDate.ToString(), tboxScheduler.Text));
            }

            // 리스트 박스를 초기화한 후 새롭게 추가된 일정 목록을 표시
            lboxScheduler.Items.Clear();

            // slScheduler의 모든 항목을 리스트 박스에 추가
            foreach (KeyValuePair<DateTime, string> oitem in slScheduler)
            {
                lboxScheduler.Items.Add(string.Format("{0} : {1}", oitem.Key.ToString("yyyy-MM-dd"), oitem.Value));
            }
        }

        /// <summary>
        /// 달력 날짜가 변경되었을 때 실행되는 이벤트 핸들러
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mcScheduler_DateChanged(object sender, DateRangeEventArgs e)
        {
            // 선택한 날짜(DateTime) 설정
            DateTime dSetDate = mcScheduler.SelectionStart;

            // slScheduler에 선택한 날짜가 있을 경우 해당 일정 내용을 텍스트 박스에 표시
            if (slScheduler.ContainsKey(dSetDate))
            {
                tboxScheduler.Text = slScheduler[dSetDate];
            }
            // 선택한 날짜에 일정이 없을 경우 텍스트 박스를 비움
            else
            {
                tboxScheduler.Text = string.Empty;
            }
        }
    }
}
