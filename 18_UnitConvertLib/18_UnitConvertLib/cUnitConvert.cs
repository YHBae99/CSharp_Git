namespace _18_UnitConvertLib
{
    public class CunitConvert
    {
        #region 길이 변환
        // 길이 변환 (Meter(미터), Kilometer(킬로미터), Mile(마일))
        public enum enLength
        {
            MeterToKilometer = 1,
            MeterToMile,
            KilometerToMeter = 11,
            KilometerToMile,
            MileToMeter = 21,
            MileToKilometer,
        }

        /// <summary>
        /// 길이 변환 Logic (Meter, Kilometer, Mile)
        /// </summary>
        /// <param name="changeType">변환 Type</param>
        /// <param name="value">변환 할 값</param>
        /// <returns></returns>
        public static double ConvertLength(enLength changeType, double value)
        {

            double result = 0;

            switch (changeType)
            {
                case enLength.MeterToKilometer:
                    result = value / 1000;
                    break;
                case enLength.MeterToMile:
                    result = value / 1609.34;
                    break;
                case enLength.KilometerToMeter:
                    result = value * 1000;
                    break;
                case enLength.KilometerToMile:
                    result = value * 0.621371;
                    break;
                case enLength.MileToMeter:
                    result = value * 1609.34;
                    break;
                case enLength.MileToKilometer:
                    result = value / 0.621371;
                    break;
                default:
                    break;
            }

            return result;

        }
        #endregion


        #region 무게 변환
        // 무게 변환 (Gram(그램), Kilogram(킬로그램), Pound(파운드))
        public enum enWeight
        {
            GramToKilogram = 1,
            GramToPound,
            KilogramToGram = 11,
            KilogramToPound,
            PoundToGram = 21,
            PoundToKilogram,
        }


        /// <summary>
        /// 무게 변환 Logic (Gram, Kilogram, Pound)
        /// </summary>
        /// <param name="changeType">변환 Type</param>
        /// <param name="value">변환 할 값</param>
        /// <returns></returns>
        public static double ConvertWeight(enWeight changeType, double value)
        {
            double result = 0;

            switch (changeType)
            {
                case enWeight.GramToKilogram:
                    result = value / 1000;
                    break;
                case enWeight.GramToPound:
                    result = value / 453.592;
                    break;
                case enWeight.KilogramToGram:
                    result = value * 1000;
                    break;
                case enWeight.KilogramToPound:
                    result = value * 2.20462;
                    break;
                case enWeight.PoundToGram:
                    result = value * 453.592;
                    break;
                case enWeight.PoundToKilogram:
                    result = value / 2.20462;
                    break;
                default:
                    break;
            }

            return result;

        }
        #endregion


        #region 온도 변환
        // 온도 변환 (Celsius(섭씨), Fahrenheit(화씨))
        public enum enTemperature
        {
            CelsiusToFahrenheit = 1,
            FahrenheitToCelsius,
        }

        /// <summary>
        /// 온도 변환 Logic (Celsius, Fahrenheit)
        /// </summary>
        /// <param name="changeType">변환 Type</param>
        /// <param name="value">변환 할 값</param>
        public static double ConvertTemperature(enTemperature changeType, double value)
        {
            double result = 0;

            switch (changeType)
            {
                case enTemperature.CelsiusToFahrenheit:
                    result = (value * 9 / 5) + 32;
                    break;
                case enTemperature.FahrenheitToCelsius:
                    result = (value - 32) * 5 / 9;
                    break;
                default:
                    break;
            }

            return result;

        }
        #endregion


        #region 칵테일 도수 계산

        #endregion
    }
}
