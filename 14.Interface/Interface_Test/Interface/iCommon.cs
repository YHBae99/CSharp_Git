using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Test
{
    interface iCommon
    {
        /// <summary>
        /// From Name을 작성
        /// </summary>
        string strfrmName { get; set; }   

        /// <summary>
        /// 초기화 시 호출 한 Form Name
        /// </summary>
        void fInit();

        /// <summary>
        /// 선택 색상을 기준으로 테마 변경
        /// </summary>
        /// <param name="color">변경 할 색상</param>
        void fColorChage(Color color);
    }
}
