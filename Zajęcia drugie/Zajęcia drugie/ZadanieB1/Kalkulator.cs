using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_drugie.ZadanieB1
{
    static class Kalkulator
    {
        public static void Dodaj(double a, double b)
        {
            Console.WriteLine(a+b);
        }
        public static void Odejmij(double a, double b)
        {
            Console.WriteLine(a - b);
        }
        public static void Podziel(double a, double b)
        {
            Console.WriteLine(a / b);
        }
        public static void Pomnoz(double a, double b)
        {
            Console.WriteLine(a * b);
        }
        public static void Potenga(double a, double b)
        {
            double wynik=1;
            for (int i = 0; i < b; i++)
            {
                wynik *= a;
            }
            Console.WriteLine(wynik);
        }
    }
}
