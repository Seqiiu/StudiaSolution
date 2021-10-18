using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_S4Z1
{
    class Pracownik
    {
        DateTime rokZatrudnienia;
        string imie, nazwisko;

        public Pracownik(DateTime rok, string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokZatrudnienia = rok;
        }

        public int IlePracuje()
        {
            return DateTime.Now.Year - rokZatrudnienia.Year;
        }

        public void WyswietlDane()
        {
            var lata = IlePracuje();
            string odmiana = "Lat";
            if (lata == 1)
            {
                odmiana = "Rok";
            }
            if (lata <= 0)
            {
                Console.WriteLine($"Imię: {imie}, Nazwisko: {nazwisko}, Za osoba jeszcze nie prauje roku");
            }
            else
            {
                Console.WriteLine($"Imię: {imie}, Nazwisko: {nazwisko}, Pracuje już {lata} {odmiana} ");
            }

        }

    }
}
