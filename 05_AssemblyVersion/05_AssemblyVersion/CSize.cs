using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_AssemblyVersion
{
    /// <summary>
    /// 컨트롤 크기 정보를 저장하는 클래스
    /// </summary>
    internal class CSize
    {
        // 이름, 너비, 높이를 저장할 프로퍼티
        string _Name = string.Empty;
        public string Name { get => _Name; set => _Name = value; }

        int _Width = 0;
        public int Width { get => _Width; set => _Width = value; }

        int _Height = 0;
        public int Height { get => _Height; set => _Height = value; }
    }
}
