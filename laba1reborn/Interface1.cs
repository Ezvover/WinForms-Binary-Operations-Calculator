using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1reborn
{
    internal interface ICalculate
    {
        public int CalculateBinary(int number);

        public int CalculateOctal(int number);

        public int CalculateDecimal(int number);

        public string CalculateHex(int number);

    }
}
