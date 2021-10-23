using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_drugie
{
    public static class ZadanieA1
    {
        public static void StartFirma()
        {
            List<firma> Listafirmy = new List<firma>();

            string InformacjaOdUrzytkownika = string.Empty;
            do
            {
                InformacjaOdUrzytkownika = Console.ReadLine();
                if (InformacjaOdUrzytkownika == "t" || InformacjaOdUrzytkownika == "T")
                {
                    Console.WriteLine("Podaj dane Fimry (Nazwa , Ilość pracowników, Rok założenia");
                    string[] dane = Console.ReadLine().Split();
                    Listafirmy.Add(
                        new firma
                        {
                            NazwaFirmy = dane[0],
                            LiczbaPracownikow = int.Parse(dane[1]),
                            RokZalozenia = int.Parse(dane[2]),
                        });
                    Console.WriteLine("Czy chcesz wprowadzić kolejego pracownika? t/n");
                }
            } while (InformacjaOdUrzytkownika != "n" && InformacjaOdUrzytkownika !="N");
            firma firma = new firma();
            firma.WyswietlWszystko(Listafirmy);        
        }
    }
}
