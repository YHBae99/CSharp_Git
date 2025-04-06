using _18_UnitConvertLib;

namespace UnitConverterApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        #region Button Event
        /// <summary>
        /// Form Load Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            rdoLength.Checked = true;
        }

        /// <summary>
        /// 변환 진행
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExecute_Click(object sender, EventArgs e)
        {
            double dValue = 0.0;
            double dResult = 0.0;

            if (!double.TryParse(tboxValue.Text, out dValue))
            {
                Log(enLogLevel.Error, $"Double 형태로 변환 할 수 없는 값 입니다. ({tboxValue.Text})");
                return;
            }

            if (rdoLength.Checked)
            {
                CunitConvert.enLength eMethodType = fStringtoLength(cboxType.Text);

                dResult = CunitConvert.ConvertLength(eMethodType, dValue);
            }
            else if (rdoWeight.Checked)
            {
                CunitConvert.enWeight eMethodType = fStringtoWeight(cboxType.Text);

                dResult = CunitConvert.ConvertWeight(eMethodType, dValue);
            }
            else if (rdoTemperature.Checked)
            {
                CunitConvert.enTemperature eMethodType = fStringtoTemperature(cboxType.Text);

                dResult = CunitConvert.ConvertTemperature(eMethodType, dValue);
            }

            tboxResult.Text = dResult.ToString("0.###");  // 소수 3자리 까지 자리수 지정
            Log(enLogLevel.Info_L1, $"{cboxType.Text} : 의 변환 결과는 기존[{tboxValue.Text}] > 변환[{tboxResult.Text}] 입니다.");
        }

        #endregion


        #region 길이 변환 관련 내용
        /// <summary>
        /// Radio Button Change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoLength_CheckedChanged(object sender, EventArgs e)
        {
            cboxType.Items.Clear();

            foreach (CunitConvert.enLength oMethodType in Enum.GetValues(typeof(CunitConvert.enLength)))   // ※15강 캡슐화에서 사용
            {
                cboxType.Items.Add(oMethodType.ToString());
            }
            cboxType.SelectedIndex = 0;
            Log(enLogLevel.Info_L1, $"({cboxType.Text})을 선택 하였습니다.");
        }

        /// <summary>
        /// String to Enum 관련 Validation
        /// </summary>
        /// <param name="enType"></param>
        /// <returns></returns>
        private CunitConvert.enLength fStringtoLength(string enType)
        {
            CunitConvert.enLength eMethodType;

            if (!Enum.TryParse<CunitConvert.enLength>(enType, out eMethodType))
            {
                Log(enLogLevel.Error, $"Combox에 없는 값은 사용 할 수 없음 ({enType})");
            }

            return eMethodType;
        }

        #endregion


        #region 무게 변환 관련 내용
        /// <summary>
        /// Radio Button Change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoWeight_CheckedChanged(object sender, EventArgs e)
        {
            cboxType.Items.Clear();

            foreach (CunitConvert.enWeight oMethodType in Enum.GetValues(typeof(CunitConvert.enWeight)))   // ※15강 캡슐화에서 사용
            {
                cboxType.Items.Add(oMethodType.ToString());
            }
            cboxType.SelectedIndex = 0;
            Log(enLogLevel.Info_L1, $"({cboxType.Text})을 선택 하였습니다.");
        }

        /// <summary>
        /// String to Enum 관련 Validation
        /// </summary>
        /// <param name="enType"></param>
        /// <returns></returns>
        private CunitConvert.enWeight fStringtoWeight(string enType)
        {
            CunitConvert.enWeight eMethodType;

            if (!Enum.TryParse<CunitConvert.enWeight>(enType, out eMethodType))
            {
                Log(enLogLevel.Error, $"Combox에 없는 값은 사용 할 수 없음 ({enType})");
            }

            return eMethodType;
        }

        #endregion


        #region 온도 변환 관련 내용
        /// <summary>
        /// Radio Button Change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoTemperature_CheckedChanged(object sender, EventArgs e)
        {
            cboxType.Items.Clear();

            foreach (CunitConvert.enTemperature oMethodType in Enum.GetValues(typeof(CunitConvert.enTemperature)))   // ※15강 캡슐화에서 사용
            {
                cboxType.Items.Add(oMethodType.ToString());
            }
            cboxType.SelectedIndex = 0;
            Log(enLogLevel.Info_L1, $"({cboxType.Text})을 선택 하였습니다.");
        }

        /// <summary>
        /// String to Enum 관련 Validation
        /// </summary>
        /// <param name="enType"></param>
        /// <returns></returns>
        private CunitConvert.enTemperature fStringtoTemperature(string enType)
        {
            CunitConvert.enTemperature eMethodType;

            if (!Enum.TryParse<CunitConvert.enTemperature>(enType, out eMethodType))
            {
                Log(enLogLevel.Error, $"Combox에 없는 값은 사용 할 수 없음 ({enType})");
            }

            return eMethodType;
        }

        #endregion


        #region Log Viewer  

        int iMaxListCount = 12;

        // Log Level을 지정 할 Enum
        enum enLogLevel
        {
            Info_L1,
            Info_L2,
            Info_L3,
            Warning,
            Error,
        }

        private void Log(enLogLevel eLevel, string LogDesc)
        {
            this.Invoke(new Action(delegate ()
            {
                if (lboxLog.Items.Count >= iMaxListCount)
                {
                    lboxLog.Items.RemoveAt(iMaxListCount - 1);
                }

                DateTime dTime = DateTime.Now;
                string LogInfo = $"{dTime:yyyy-MM-dd hh:mm:ss.fff} [{eLevel.ToString()}] {LogDesc}";
                lboxLog.Items.Insert(0, LogInfo);
            }));
        }

        private void Log(DateTime dTime, enLogLevel eLevel, string LogDesc)
        {
            this.Invoke(new Action(delegate ()
            {
                if (lboxLog.Items.Count >= iMaxListCount)
                {
                    lboxLog.Items.RemoveAt(iMaxListCount - 1);
                }

                string LogInfo = $"{dTime:yyyy-MM-dd hh:mm:ss.fff} [{eLevel.ToString()}] {LogDesc}";
                lboxLog.Items.Insert(0, LogInfo);
            }));
        }

        #endregion


    }
}