using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_S4Z1
{
    class ZadanieA3
    {
        public static void Funck()
        {
            var morderca = new Przestestepca(new DateTime(2016, 05, 24), 5);
            morderca.SprawdzCzyZakonczyl();
            var zlodziej = new Przestestepca(new DateTime(2021, 10, 1), 2);
            zlodziej.SprawdzCzyZakonczyl();
        }
    }
}
