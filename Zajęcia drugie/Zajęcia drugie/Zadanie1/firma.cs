using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_drugie.Zadanie1
{
    class firma
    {
        public string NazwaFirmy { get; set; }
        public int LiczbaPracownikow { get; set; }
        public int RokZalozenia { get; set; }
        public firma()
        {

        }

        public void WyswietlWszystko(List<firma> Listafirmy)
        {
            foreach (var item in Listafirmy)
            {
                Console.WriteLine($"{item.NazwaFirmy} {item.LiczbaPracownikow} {item.RokZalozenia}");
            }
        }
    }
}
