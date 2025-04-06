using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_MemoryAddress
{
    internal class cCopySample : ICloneable
    {
        public int iCopy;   // 값
        public char charCopy;  // 값
        public int[] arrCopy = new int[5];  // 참조
        public cField clsCopy = new cField();   // 참조

        /// <summary>
        /// 얕은복사를 위해 생성
        /// </summary>
        /// <returns></returns>
        public object ShallowCopy()
        {
            return this.MemberwiseClone();
        }

        /// <summary>
        /// Deep Copy
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            cCopySample copy = this.MemberwiseClone() as cCopySample;

            // Array
            copy.arrCopy = new int[5];
            for (int i = 0; i < 5; i++)
            {
                copy.arrCopy[i] = this.arrCopy[i];
            }

            // Class
            copy.clsCopy = new cField();
            copy.clsCopy.iValue = this.clsCopy.iValue;

            return copy;
        }
    }
}
