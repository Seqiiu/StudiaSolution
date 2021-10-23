using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_S4Z1
{
    class PracownikSklepu
    {
        int wysokoscZarobkow;
        string nazwisko, imie, plec,stanowisko;

        public string Nazwisko 
        {
            get
            {
                
                return nazwisko;
            }

        }
        public string Stanowisko 
        {
            get
            {
                return stanowisko;
            }
            set
            {
                stanowisko = value;
            } 
        }

        public PracownikSklepu(int wysokscZarobkow, string imie, string nazwisko, string stanowisko, string plec)
        {
            this.wysokoscZarobkow = wysokscZarobkow;
            this.nazwisko = nazwisko;
            this.imie = imie;
            this.stanowisko = stanowisko;
            this.plec = plec;

        }
        public void IleZarabia()
        {
            if (wysokoscZarobkow <= 2500)
            {
                Console.WriteLine("Zarabia mało");
            }
            else if (wysokoscZarobkow <= 4000)
            {
                Console.WriteLine("Zarabia średnio");
            }
            else
            {
                Console.WriteLine("Zarabia dużo");
            }
        }

    }
}
