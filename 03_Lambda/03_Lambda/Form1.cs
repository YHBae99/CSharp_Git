using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Lambda
{
    public partial class Form1 : Form
    {
        // 현재 스텝에 대한 정보를 표시하는 Action 델리게이트 선언
        Action _aStepCheck = null;

        /// <summary>
        /// 스텝 진행 상태를 정리하기 위한 enum
        /// </summary>
        enum enumLambdaCase
        {
            식형식_람다식 = 0,  // 식 형식 람다식
            문형식_람다식 = 1,  // 문 형식 람다식
            제네릭_형태의_무명메서드_Func = 2,  // 제네릭 형태의 무명 메서드 (Func)
            제네릭_형태의_무명메서드_Action = 3,  // 제네릭 형태의 무명 메서드 (Action)
            제네릭_형태의인자__반환_예제 = 4  // 제네릭 형태의 인자와 반환 예제 (Sum 함수)
        }

        /// <summary>
        /// 프로그램 시작점, Form 초기화
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form이 처음 로드될 때 호출됨
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            _aStepCheck = () => lblStepCheck.Text = string.Format(" - 다음 Step은 {0}.{1}", iNowStep, ((enumLambdaCase)iNowStep).ToString());  // 람다식으로 등록
            _aStepCheck();  // 다음 Step을 표시하기 위해 Action을 호출

            ButtonColorChange();   // Button 색상을 변경 하는 예제
        }

        /// <summary>
        /// 버튼의 색상을 변경하는 이벤트 핸들러 등록
        /// </summary>
        private void ButtonColorChange()
        {
            // 명시적인 메서드를 사용하여 버튼 색상 변경
            btnColorChange_1.Click += BtnColorChange_1_Click;

            // 무명 메서드를 사용하여 버튼 색상 변경
            btnColorChange_2.Click += delegate (object sender, EventArgs e)
            {
                btnColorChange_2.BackColor = Color.Brown;
            };

            // 람다식을 사용하여 버튼 색상 변경
            btnColorChange_3.Click += (sender, e) => btnColorChange_3.BackColor = Color.Coral;
        }

        /// <summary>
        /// 버튼 클릭 이벤트 핸들러 - btnColorChange_1의 색상 변경
        /// </summary>
        private void BtnColorChange_1_Click(object sender, EventArgs e)
        {
            btnColorChange_1.BackColor = Color.Aqua;
        }

        // 현재 스텝을 저장하는 변수
        int iNowStep = 0;

        // 두 개의 델리게이트 선언: 하나는 int 반환, 하나는 string 반환
        delegate int delIntFunc(int a, int b);
        delegate string delStringFunc();

        /// <summary>
        /// "Next" 버튼 클릭 시 호출 - 현재 스텝에 해당하는 람다식 예제를 실행
        /// </summary>
        private void btnNext_Click(object sender, EventArgs e)
        {
            Lambda(iNowStep);  // 현재 스텝에 맞는 람다식 실행
            iNowStep++;  // 스텝 증가
            _aStepCheck();  // 다음 스텝 정보를 업데이트
        }

        /// <summary>
        /// 각 스텝에 맞는 람다식 예제를 Switch 문으로 정리
        /// </summary>
        private void Lambda(int iCase)
        {
            switch (iCase)
            {
                case (int)enumLambdaCase.식형식_람다식:
                    // 식 형식 람다식 예제 - 두 값을 곱하는 함수
                    delIntFunc dint = (a, b) => a * b;
                    int iRet = dint(4, 5);
                    lboxResult.Items.Add(iRet.ToString());

                    // 식 형식 람다식 예제 - 문자열 반환 함수
                    delStringFunc dString = () => string.Format("Lambda Sample 식형식");
                    string strRet = dString();
                    lboxResult.Items.Add(strRet);

                    break;

                case (int)enumLambdaCase.문형식_람다식:
                    // 문 형식 람다식 예제 - 문자열 반환
                    delStringFunc dstrSeqment = () =>
                    {
                        return string.Format("Lambda Sample 문형식");
                    };
                    string strSeqRet = dstrSeqment();
                    lboxResult.Items.Add(strSeqRet);

                    break;

                case (int)enumLambdaCase.제네릭_형태의_무명메서드_Func:
                    // 제네릭 형태의 무명 메서드 (Func<> 사용) - 두 값을 곱하는 함수
                    Func<int, int, int> fInt = (a, b) => a * b;
                    int fIntRet = fInt(4, 5);
                    lboxResult.Items.Add(fIntRet.ToString());

                    break;

                case (int)enumLambdaCase.제네릭_형태의_무명메서드_Action:
                    // 제네릭 형태의 무명 메서드 (Action<> 사용) - 인자 값을 받아 처리
                    Action<string, string> aString = (a, b) =>
                    {
                        string strText = String.Format("인자 값 {0}와 {1}을 받았습니다.", a, b);
                        lboxResult.Items.Add(strText);
                    };
                    aString("시간", "금");

                    break;

                case (int)enumLambdaCase.제네릭_형태의인자__반환_예제:
                    // 배열의 Sum 함수 - 인자 값을 람다식으로 처리
                    int[] iGroup = { 1, 3, 5, 7, 9 };
                    int iNumSum = iGroup.Sum(x => x);
                    lboxResult.Items.Add(iNumSum.ToString());

                    // 문자열 배열의 길이를 합산하는 예제
                    string[] strGroup = { "XXX", "TTTT", "YYY" };
                    int ilengthSum = strGroup.Sum(x => x.Length);
                    lboxResult.Items.Add(ilengthSum.ToString());

                    break;

                default:
                    break;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lboxResult.Items.Clear();

            btnColorChange_1.BackColor = DefaultBackColor;
            btnColorChange_2.BackColor = DefaultBackColor;
            btnColorChange_3.BackColor = DefaultBackColor;

            iNowStep = 0;
            _aStepCheck();
        }
    }
}
