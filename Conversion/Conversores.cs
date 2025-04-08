using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    public class Conversores
    {
        public static double cParaF(double C)
        {
            return (C * 1.8 + 32);

        }
        public static double CParaK(double C)
        {
            return (C + 273.15);

        }
        public static double FParaC(double F)
        {
            return (F - 32) * 5 / 9;
        }
        public static double FParaK(double F)
        {
            return (F - 32) * 5 / 9 + 273.15;
        }
        public static double KParaC(double K)
        {
            return (K - 273.15);
        }
        public static double KParaF(double K)
        {
            return (K - 273.15) * 9 / 5 + 32;
        }

    }
}
