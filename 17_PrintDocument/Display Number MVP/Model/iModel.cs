using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_Number_MVP
{
    interface iModel
    {
        double dNumber { get; set; }  // 숫자
        string strNumberString { get; set; }   // 문자형 숫자
        void fNumberCal(double dNumber, double dMultiple);   // 계산 function
        void fReset();   // 초기화 function

    }
}
