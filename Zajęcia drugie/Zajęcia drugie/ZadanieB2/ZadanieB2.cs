using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_drugie
{
    class ZadanieB2
    {
        public static void Funck()
        {
            Budynek[] tablicaBudynkow = new Budynek[3];
            tablicaBudynkow[0] = new Budynek(5, 1992, 20, 200);
            tablicaBudynkow[1] = new Budynek(6, 1999, 25, 230);
            tablicaBudynkow[2] = new Budynek(4, 2002, 15, 100);

            Budynek.ObliczSrednia(tablicaBudynkow);
            Budynek.ObliczSrednia(tablicaBudynkow[0],3.4f);
            Console.ReadKey();
        }
    }
}
