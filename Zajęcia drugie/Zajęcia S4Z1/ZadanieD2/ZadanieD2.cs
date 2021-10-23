using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_S4Z1
{
    class ZadanieD2
    {
        public static void Funck()
        {
            int[,] tablica = new int[2, 2] { { 2, 3 }, { 5, 9 } };
            int[,] tablica1 = new int[1, 1] { {1} };
            int[,] tablica2 = new int[3, 3] { { 1, 0, 0 }, { 0, 1, 0 },{ 0,0,1} };



            Macierz macierz = new Macierz(tablica);
            Macierz macierz1 = new Macierz(tablica1);
            Macierz macierz2 = new Macierz(tablica2);

            Console.WriteLine(macierz.ObliczWyznacznik());

            Console.WriteLine(macierz.SprawdzCzyJednostkowa());
            Console.WriteLine(macierz1.SprawdzCzyJednostkowa());
            Console.WriteLine(macierz2.SprawdzCzyJednostkowa());

        }
    }
}

