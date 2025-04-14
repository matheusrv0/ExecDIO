using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry { 
    public class CalculoFiguras
    {
        public static double CalcularAreaTriangulo(double baseT, double alturaT)
        {
            double areaTringulo = (baseT * alturaT) / 2;
            return areaTringulo;
        }
        public static double CalcularPerimetroTriangulo(double aT, double bT, double cT)
        {

            double perimetroTriangulo = (aT + bT + cT);
            return perimetroTriangulo;
        }
        public static double CalcularAreaRetangulo(double baseR, double altR)
        {
            double areaRetangulo = (baseR * altR);
            return areaRetangulo;

        }
        public static double CalcularPerimetroRetangulo(double basePR, double altPR)
        {
            double perimetroRetangulo = (basePR + altPR) * 2;
            return perimetroRetangulo;
        }

    }
}
