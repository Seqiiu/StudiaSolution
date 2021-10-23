using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_S4Z1
{
    class ZadanieD3
    {
        public static void Funck()
        {
            var tab = new double[8];
            var losowa = new Random();
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = losowa.NextDouble();
            }

            var sposrtowiec = new Sportowiec("Adamczyk", "Kręgle", 5);
            var sposrtowiec1 = new Sportowiec("Adamczyk", "Kręgle", tab);

            sposrtowiec.WyswietlDane();
            //sposrtowiec1.WyswietlDane();

            sposrtowiec.WyswietlWynik(2);
            sposrtowiec.WyswietlWynik(2);
            sposrtowiec1.WyswietlWynik(9);
        }
    }
}
