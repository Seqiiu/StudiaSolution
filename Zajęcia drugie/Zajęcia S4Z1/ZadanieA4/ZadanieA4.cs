using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_S4Z1
{
    class ZadanieA4
    {
        public static void Funck()
        {
            Student[] tablicaStudentow = new Student[3];
            tablicaStudentow[0]= new Student("Kasia", "Kaczmarczyk", "kobieta", 2000);
            tablicaStudentow[1]= new Student("Paweł", "Nowak", "Mężczyzna", 1000);
            tablicaStudentow[2]= new Student("Adam", "Kot", "Mężczyzna", 500);

            foreach (var item in tablicaStudentow)
            {
                item.WyslwietlWszystko();
            }
        }
    }
}
