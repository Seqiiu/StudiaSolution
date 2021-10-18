using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_drugie
{
    class Rekurencja
    {
        public static int LicznikWywolan { get; set; }
        public static int LicznikWywolanC { get; set; }
        static Rekurencja()
        {
            LicznikWywolan++;
            int k=RazyRazy(5);

            using StreamWriter file = new("WriteLines2.txt", append: true);
            file.WriteLine("Ja?");
        }
        public Rekurencja()
        {
            LicznikWywolanC++;
            using StreamWriter file = new("WriteLines2.txt", append: true);
            file.WriteLine("Kto pierwszy");
        }

        public static int RazyRazy(int n)
        {
            if (n == 2)
            {
                return 1;
            }
            return RazyRazy(n - 1) * 3;

        }
        public int Nazwa()
        {
            return  10;
        }
        public static void IleRazy()
        {
            Console.WriteLine(LicznikWywolan);
            Console.WriteLine(LicznikWywolanC);
        }
    }
}
