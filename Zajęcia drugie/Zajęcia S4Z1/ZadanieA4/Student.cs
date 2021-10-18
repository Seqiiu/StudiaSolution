using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_S4Z1
{
    class Student
    {
        string imie, nazwisko, plec;
        int wysokoscStypendium;
        public Student(string imie, string nazwisko,string plec,int wysokoscStypendium)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.plec = plec;
            this.wysokoscStypendium = wysokoscStypendium;
        }
        public void WyslwietlWszystko()
        {
            Console.WriteLine($"Imie: {imie} Nazwisko: {nazwisko} Płeć: {plec} Wysokość stypendium: {wysokoscStypendium}");
        }
    }
}
