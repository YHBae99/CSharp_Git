using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FartialClass
{
    /// <summary>
    /// 변수
    /// </summary>
    partial class CData
    {
        private double _dTotalPrice = 0.0;  // 클래스의 내부 필드 (총 가격을 저장하는 필드)
        public double DTotalPrice  // 프로퍼티: 외부에서 이 필드에 접근할 수 있도록 만듦
        {
            get { return _dTotalPrice; }  // _dTotalPrice의 값을 반환
            set { _dTotalPrice = value; }  // 외부에서 값을 설정할 때 _dTotalPrice에 저장
        }


        private string _strItem = string.Empty;  // 내부에서만 접근 가능한 필드, 초기값은 빈 문자열
        public string StrItem  // public set-only 프로퍼티 (get은 없음)
        {
            set
            {
                if (string.IsNullOrEmpty(value)) // value의 값이 Null 이나 Empty 일 경우 _strErrorName의 값을 반환
                {
                    _strErrorName = "물건이 선택되지 않았습니다.";
                }
                else
                {
                    _strItem = value;
                }
            }
        }

        private int _iRate = 0;
        public int iRate
        {
            set
            {
                if (value > 20)
                {
                    _strErrorName = "관리자만 가능한 할인 입니다.";
                }
                else
                {
                    _iRate = value;
                }
            }
        }

        private int _iCount = 0;
        public int ICount
        {
            set
            {
                if (value > 5)
                {
                    _strErrorName = "물품을 5개 이상 살 수 없습니다.";
                }
                else if (value == 0)
                {
                    _strErrorName = "물품의 개수가 0개 입니다.";
                }
                else
                {
                    _iCount = value;
                }
            }
        }

        private string _strErrorName = string.Empty;
        public string StrErrorName
        {
            get { return _strErrorName; }
        }
    }

    /// <summary>
    /// 수식 계산
    /// </summary>
    partial class CData
    {
        public double fItemPrice()
        {
            double dPrice = 0;
            int iItemPrice = 0;

            if (string.IsNullOrEmpty(_strErrorName))
            {
                iItemPrice = (int)Enum.Parse(typeof(EnumItem), _strItem);

                dPrice = iItemPrice - Math.Round((double)iItemPrice * (double)_iRate / 100, 2);
            }
            return dPrice * _iCount;
        }
    }

    /// <summary>
    /// 문자열
    /// </summary>
    partial class CData 
    {
        public string fResult(double dPrice)
        {
            if (_iRate == 0)
            {
                return string.Format("{0} x {1} : {2}원", _strItem, _iCount, dPrice);
            }
            else
            {
                return string.Format("{0} x {1} : {2}원 (할인율 : {3}%", _strItem, _iCount, dPrice, _iRate);
            }
        }

        /// <summary>
        /// 내부 변수값들을 초기화 
        /// </summary>
        public void fDataResult()
        {
            _strErrorName = string.Empty ;
            _iCount = 0 ;
            _iRate = 0 ;
            _strItem = string.Empty ;
        }
    }
}
