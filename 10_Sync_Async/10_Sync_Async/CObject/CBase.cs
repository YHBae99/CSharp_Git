using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _10_Sync_Async.CObject
{
    class CBase
    {
        public string strName;  // 이름
        protected Pen _Pen;     // 펜
        protected SolidBrush _Brush; // 브러쉬

        /// <summary>
        /// 생성자
        /// </summary>
        public CBase()
        {
            _Pen = new Pen(Color.Aqua);
        }
    }
}
