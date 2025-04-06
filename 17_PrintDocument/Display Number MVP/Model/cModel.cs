using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_Number_MVP
{
    class cModel : iModel
    {
        #region Model Interface 구현

        public double dNumber { get; set; }  // 숫자
        public string strNumberString { get; set; }  // 문자형 숫자

        /// <summary>
        /// 계산 function (배율 계산 후 문자형 숫자로 변환은 내부 function 사용)
        /// </summary>
        /// <param name="dOrgNumber"></param>
        /// <param name="dMultiple"></param>
        public void fNumberCal(double dOrgNumber, double dMultiple)
        {
            dNumber = dOrgNumber * dMultiple;
            strNumberString = fDoubleToStringNumber(dNumber);  // Inner function
        }

        /// <summary>
        /// 초기화 function
        /// </summary>
        public void fReset()
        {
            dNumber = 1;
            strNumberString = "1";
        }

        #endregion


        #region Inner function (기존 WPF Logic 그대로 사용 : https://cwkcw.tistory.com/74)

        /// <summary>
        /// 숫자를 문자형 숫자로 변환
        /// </summary>
        /// <param name="dNumber"></param>
        /// <returns></returns>
        private string fDoubleToStringNumber(double dNumber)
        {
            string sResult = string.Empty;
            string sNumber = string.Empty;
            string sDigit = string.Empty;

            string[] sNumberList = (dNumber.ToString()).Split('+');

            double dKeepNumber = 0;

            if (sNumberList.Length < 2)
            {
                double dRMV_Decimal = Math.Truncate(dNumber);

                if (dRMV_Decimal.ToString().Length < 4)
                {
                    dKeepNumber = dRMV_Decimal;
                }
                else
                {
                    dKeepNumber = double.Parse(dRMV_Decimal.ToString().Substring(0, 4));
                }
                sNumber = string.Format("{0:n0}", dKeepNumber);

                if (Enum.IsDefined(typeof(enumNumber), dRMV_Decimal.ToString().Length))
                {
                    sDigit = ((enumNumber)dRMV_Decimal.ToString().Length).ToString().Replace("num_", "");
                }
            }
            else
            {
                dKeepNumber = double.Parse(sNumberList[0].ToString().Replace("E", "")) * 1000;
                sNumber = string.Format("{0:n0}", dKeepNumber);
                sDigit = ((enumNumber)int.Parse(sNumberList[1]) + 1).ToString().Replace("num_", "");
            }

            sResult = String.Format("{0}{1}", sNumber, sDigit);

            return sResult;

        }

        #endregion

    }
}
