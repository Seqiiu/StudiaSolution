using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_S4Z1
{
    class Stoper
    {
        DateTime czasRozpoczecia;
        DateTime czasZakonczenia;

        public void Start()
        {
            czasRozpoczecia = DateTime.Now;
        }
        public void Stop()
        {
            czasZakonczenia = DateTime.Now;
        }
        public DateTime CzasRozpoczecia { get { return czasRozpoczecia; } }


        public TimeSpan WyswietlCzas()
        {
            TimeSpan diff1 = czasZakonczenia.Subtract(czasRozpoczecia);

            return diff1;
        }
    }
}
