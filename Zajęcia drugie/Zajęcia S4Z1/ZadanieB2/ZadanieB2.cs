using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_S4Z1
{
    class ZadanieB2
    {
        public static void Funck()
        {
            //Wykorzystanie z ZadaniaA1 Klasy Punkt

            var punktJeden = new Punkt(3, 0);
            var punktDwa = new Punkt(10, 10);

            //Odległość punktu od punktu
            Console.WriteLine(Punkt.Odcinek(punktJeden, punktDwa));
        }
    }
}
