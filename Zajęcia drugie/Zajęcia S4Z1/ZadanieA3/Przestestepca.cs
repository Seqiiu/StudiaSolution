using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_S4Z1
{
    class Przestestepca
    {
        DateTime dataRozpoczecia;
        DateTime dataZakonczenia;
        int wymiarKary;
        public Przestestepca(DateTime dataRozpoczecia, int wymiarKary)
        {
            this.dataRozpoczecia = dataRozpoczecia;
            this.wymiarKary = wymiarKary;
        }
        public void SprawdzCzyZakonczyl()
        {
            int x = wymiarKary;
            dataZakonczenia = dataRozpoczecia.AddMonths(x);


            if (dataZakonczenia.Date> DateTime.Now.Date)
            {
                Console.WriteLine("Przestępca nadal odbywa karę");
                Console.WriteLine($"Do końca kary zostało: {dataZakonczenia.Date - DateTime.Now.Date} dni");
            }
            else
            {
                Console.WriteLine("Przestępca opuścił już więzienie");
                Console.WriteLine($"Jest już na wolności: {DateTime.Now.Date - dataZakonczenia.Date} dni");
            }
        }
    }
}
