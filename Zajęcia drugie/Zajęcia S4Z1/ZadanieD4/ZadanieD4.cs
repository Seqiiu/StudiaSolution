using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_S4Z1
{
    class ZadanieD4
    {
        public static void Funck()
        {
            var stoper = new Stoper();

            stoper.Start();
            double k=0;
            do
            {
                k =k+ 0.2;
            } while (k<50000000);
            stoper.Stop();

            Console.WriteLine(stoper.WyswietlCzas());
            Console.WriteLine(stoper.CzasRozpoczecia);
        }
    }
}
