using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_S4Z1
{
    
    class Walec
    {
        double wysokosc, promien;

        double pi = Math.PI;

        public double Wysokosc 
        {
            get
            {
                return wysokosc;
            }
        }
        public double Promien
        {
            get
            {
                return promien;
            }
        }

        public Walec(double wysokosc, double promien)
        {
            this.wysokosc = wysokosc;
            this.promien = promien;
        }
        public double ObliczPolePodstawy(Walec walec)
        {
            return pi * promien * promien;
        }
        public double ObliczObjetosc(Walec walec)
        {
            return ObliczPolePodstawy(walec) * wysokosc;
        }
    }
}
