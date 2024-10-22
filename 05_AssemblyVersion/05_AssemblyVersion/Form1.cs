using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_AssemblyVersion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 폼이 로드될 때 실행되는 이벤트
        /// </summary>
        private void Title_Load(object sender, EventArgs e)
        {
            // 어셈블리 버전을 가져와서 제목에 표시
            Version oVersion = Assembly.GetEntryAssembly().GetName().Version;
            this.Text = string.Format("{0} Ver.{1}.{2} / Build Time ({3}) - {4}",
                                      "Title 사용하기",
                                      oVersion.Major, oVersion.Minor,
                                      //GetBuildDataTime(oVersion),
                                      GetBuildDataTime(), // 빌드 시간을 가져오는 방법 변경
                                      "프로그램 상태");

            // 빌드 날짜 확인용 메서드 호출
            //GetBuildDataTime(oVersion);
        }

        /// <summary>
        /// 어셈블리의 실제 빌드 시간을 계산하는 메서드
        /// </summary>
        public DateTime GetBuildDataTime()
        {
            // 어셈블리 경로를 가져옴
            string assemblyPath = Assembly.GetEntryAssembly().Location;
            // 파일 정보 가져오기
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(assemblyPath);
            // 파일의 생성 시간을 반환
            return fileInfo.CreationTime;
        }

        ///// <summary>
        ///// 어셈블리 버전 정보를 이용하여 빌드 시간을 계산하는 메서드
        ///// </summary>
        //public DateTime GetBuildDataTime(Version oVersion)
        //{
        //    string strVerstion = oVersion.ToString();

        //    // 날짜 계산 (버전의 세 번째 숫자를 기준으로)
        //    int iDays = Convert.ToInt32(strVerstion.Split('.')[2]);
        //    DateTime refData = new DateTime(2000, 1, 1);  // 기준 날짜
        //    DateTime dtBuildDate = refData.AddDays(iDays);  // 기준 날짜에 일 수 추가

        //    // 초 계산 (버전의 네 번째 숫자를 기준으로)
        //    int iSeconds = Convert.ToInt32(strVerstion.Split('.')[3]);
        //    iSeconds = iSeconds * 2;  // 초를 2배로
        //    dtBuildDate = dtBuildDate.AddSeconds(iSeconds);

        //    // 서머타임(일광 절약 시간제) 적용
        //    DaylightTime daylighttime = TimeZone.CurrentTimeZone.GetDaylightChanges(dtBuildDate.Year);

        //    if (TimeZone.IsDaylightSavingTime(dtBuildDate, daylighttime))
        //    {
        //        dtBuildDate = dtBuildDate.Add(daylighttime.Delta);  // 서머타임 적용 시간 추가
        //    }

        //    return dtBuildDate;  // 빌드 날짜 반환
        //}

        // Dictionary 예제

        // 컨트롤(Button, Label)의 크기 정보를 저장할 Dictionary
        Dictionary<string, Stack<CSize>> oDic = new Dictionary<string, Stack<CSize>>();

        /// <summary>
        /// 버튼 클릭 시 컨트롤의 크기를 확인하는 메서드
        /// </summary>
        private void btnSizeCheck_Click(object sender, EventArgs e)
        {
            fControlSizeRead();  // 컨트롤 크기 읽기
            fControlSizeWrite();  // 컨트롤 크기 출력
        }

        /// <summary>
        /// 그룹박스 내 컨트롤의 크기 정보를 읽어오는 메서드
        /// </summary>
        private void fControlSizeRead()
        {
            oDic.Clear();  // 기존 데이터를 초기화

            // Button 컨트롤 정보를 Dictionary에 저장
            Stack<CSize> sButton = new Stack<CSize>();
            foreach (var item in gboxControl.Controls)
            {
                if (item is Button)  // Button인 경우
                {
                    Button obtn = item as Button;

                    // CSize 객체에 버튼의 이름과 크기 정보를 저장
                    CSize oSize = new CSize();
                    oSize.Name = obtn.Name;
                    oSize.Width = obtn.Width;
                    oSize.Height = obtn.Height;

                    sButton.Push(oSize);  // Stack에 추가
                }
            }
            oDic.Add("BUTTON", sButton);  // Dictionary에 추가

            // Label 컨트롤 정보를 Dictionary에 저장
            Stack<CSize> sLabel = new Stack<CSize>();
            foreach (var item in gboxControl.Controls)
            {
                if (item is Label)  // Label인 경우
                {
                    Label oLabel = item as Label;

                    // CSize 객체에 레이블의 이름과 크기 정보를 저장
                    CSize oSize = new CSize();
                    oSize.Name = oLabel.Name;
                    oSize.Width = oLabel.Width;
                    oSize.Height = oLabel.Height;

                    sLabel.Push(oSize);  // Stack에 추가
                }
            }
            oDic.Add("LABEL", sLabel);  // Dictionary에 추가
        }

        /// <summary>
        /// Dictionary에서 컨트롤의 크기 정보를 읽어와 리스트박스에 출력
        /// </summary>
        private void fControlSizeWrite()
        {
            // Dictionary에서 Button 정보를 가져와 출력
            Stack<CSize> sButton = oDic["BUTTON"];
            foreach (CSize item in sButton)
            {
                string strResult = string.Format("Control : Button, Name : {0}, Size ({1}, {2})",
                                                 item.Name, item.Width, item.Height);
                lboxResult.Items.Add(strResult);  // 리스트박스에 출력
            }

            // Dictionary에서 Label 정보를 가져와 출력
            Stack<CSize> sLabel = oDic["LABEL"];
            foreach (CSize item in sLabel)
            {
                string strResult = string.Format("Control : Label, Name : {0}, Size ({1}, {2})",
                                                 item.Name, item.Width, item.Height);
                lboxResult.Items.Add(strResult);  // 리스트박스에 출력
            }
        }
    }
}
