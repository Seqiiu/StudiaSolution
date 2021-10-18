using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_drugie
{
    class ZadanieB5
    {
        public static void Funck()
        {
            Console.WriteLine(Rekurencja.RazyRazy(5));
            Console.WriteLine(Rekurencja.RazyRazy(30));
            Rekurencja.IleRazy();

            var k = new Rekurencja();
            k.Nazwa();
            Rekurencja.IleRazy();
            var C = new Rekurencja();
            C.Nazwa();
            Rekurencja.IleRazy();


        }
    }
}
