using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_drugie.ZadanieB2
{
    class Budynek
    {
        private int LbMieszkan, LbPienter;

        public int LbMieszkancow { get; set; }
        public int Rokbudowy { get; }

        public Budynek(int Lb1,int Lb2,int Lb3,int Lb4)
        {
            LbMieszkan = Lb3;
            LbPienter = Lb1;
            LbMieszkancow = Lb4;
            Rokbudowy = Lb2;
        }

        public static void ObliczSrednia(Budynek[] tablicaBudynkow)
        {
            for (int i = 0; i < tablicaBudynkow.Length; i++)
            {
                Console.WriteLine(tablicaBudynkow[i].LbMieszkancow / tablicaBudynkow[i].LbMieszkan);
            }

        }
        //static void ObliczSrednia(Budynek budynek, float oplataSmieci)
        //{

        //    Console.WriteLine($"{budynek.LbMieszkan / budynek.LbMieszkancow * oplataSmieci} zł");
        //}
    }
}
