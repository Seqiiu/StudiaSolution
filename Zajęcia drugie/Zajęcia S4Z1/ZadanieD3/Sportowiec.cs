using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_S4Z1
{
    class Sportowiec
    {
        string nazwisko, dyscyplina;
        double[] tablicaWynikow;

        public Sportowiec(string nazwisko, string dyscyplina, int liczba)
        {
            this.nazwisko = nazwisko;
            this.dyscyplina = dyscyplina;
            this.tablicaWynikow = new double[liczba];
            if (tablicaWynikow!=default && tablicaWynikow!=null)
            {
                PrzypiosanieLiczb(liczba);
            }
        }
        public Sportowiec(string nazwisko, string dyscyplina, double[] tab)
        {
            this.nazwisko = nazwisko;
            this.dyscyplina = dyscyplina;
            this.tablicaWynikow = tab;
        }
        private void PrzypiosanieLiczb(int liczba)
        {
            var losowa = new Random();
            for (int i = 0; i < liczba; i++)
            {
                tablicaWynikow[i] = losowa.NextDouble();
            }
        }
        public void WyswietlDane()
        {
            foreach (var item in this.tablicaWynikow)
            {
                Console.WriteLine(item);
            }
        }
        public double WyswietlWynik(int m)
        {
            try
            {
                return this.tablicaWynikow[m];
            }
            catch (IndexOutOfRangeException e)  
            {
                Console.WriteLine(e.Message);
                throw new ArgumentOutOfRangeException("Nie ma takiego wyniku");
                
            }
        }
    }
}
