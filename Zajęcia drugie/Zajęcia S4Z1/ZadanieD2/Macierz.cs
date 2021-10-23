using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_S4Z1
{
    class Macierz
    {
        int[,] macierz;

        public Macierz(int[,] macierz)
        {
            this.macierz = macierz;
        }

        private bool czykwadratowa()
        {
            if (this.macierz.GetLength(0) == this.macierz.GetLength(1))
            {
                return true;
            }
            return false;
        }

        //Liczy wyznacznik tylko z macierzy 2x2 
        public int ObliczWyznacznik()
        {
            if (czykwadratowa())
            {
                int[,] tab = this.macierz;

                return tab[0, 0] * tab[1, 1] - tab[1, 0] * tab[0, 1];
            }
            return 0;
        }
        public bool SprawdzCzyJednostkowa()
        {
            //Sprawdzenie czy macirz jest kwadratowa 
            if (czykwadratowa())
            {
                int[,] tab = this.macierz;
                //Sprawdzenie czy na głownej lini są same jedynki 
                for (int i = 0; i < tab.GetLength(0); i++)
                {
                    if (tab[i, i] != 1)
                    {
                        return false;
                    }
                }
                //Sprawdzenie czy pozsotałe miejsca sa zerami
                for (int i = 0; i < tab.GetLength(0); i++)
                {
                    for (int j = 0; j < tab.GetLength(1); j++)
                    {
                        if (i == j)
                        {

                        }
                        else if (tab[i, j] != 0)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            return false;
        }
    }
}
