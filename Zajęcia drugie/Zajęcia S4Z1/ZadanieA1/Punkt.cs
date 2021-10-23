using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_S4Z1
{
    class Punkt
    {
        double x, y;
        public Punkt(double a, double b)
        {
            x = a;
            y = b;
        }


        public double ObliczOdleglosc()
        {
            return Math.Sqrt((x * x) + (y * y));
        }

        public static double Odcinek(Punkt punkt,Punkt punkt1)
        {


            return Math.Sqrt(((punkt.x - punkt1.x)*(punkt.x - punkt1.x)) + ((punkt.y - punkt1.y)*(punkt.y - punkt1.y)));
        }

        public double ObliczOdleglosc(double a, double b, double c)
        {
            double gura = Math.Abs(x * a + y * b + c);
            double dul = Math.Sqrt(x + y);
            return gura/dul;
        }
    }
}
