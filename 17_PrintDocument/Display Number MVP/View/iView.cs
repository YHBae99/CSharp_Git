using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_Number_MVP
{
    interface iView
    {
        string ThreadTime { get; }  // 속도
        string Multiple { get; }  // 배율
        bool ThreadStatus { set; }  // Thread 동작 상태
        string Number { set; get; }   // 숫자
        string NumberString {  set; }   //문자형 변환
    }
}
