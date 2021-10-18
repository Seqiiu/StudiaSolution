using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_S4Z1
{
    class ZadanieA2
    {
        public static void Funck()
        {
            var rokUrodzenia = new DateTime(2010,10,30);

            var Pracownik1 = new Pracownik(rokUrodzenia, "Adam", "Kowalski");
            Pracownik1.IlePracuje();

            Pracownik1.WyswietlDane();
        }
    }
}
