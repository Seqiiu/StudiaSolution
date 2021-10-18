using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_S4Z1
{
    class ZadanieA1
    {
        public static void Funck()
        {
            var punktJeden = new Punkt(3,0);
            var punktDwa = new Punkt(10,10);

            //Odległość od środka współrzędnych 
            Console.WriteLine(punktJeden.ObliczOdleglosc()); 

            //Odległość punktu od punktu
            Console.WriteLine(Punkt.ObliczOdleglosc(punktJeden,punktDwa));

            //Odległość punktu od prostej
            Console.WriteLine(punktJeden.ObliczOdleglosc(-2, 1, 5));
        }
    }
}
