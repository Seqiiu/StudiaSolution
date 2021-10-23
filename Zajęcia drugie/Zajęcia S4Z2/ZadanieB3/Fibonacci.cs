using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_drugie
{
    class Fibonacci
    {

        public static int ObliczNtyElement(int n)
        {
            if (n==0)
            {
                return 0;
            }
            if (n==1)
            {
                return 1;
            }
            return ObliczNtyElement(n - 2) + ObliczNtyElement(n-1);
        }
        
        public static void WyswietlNelementow(byte n)
        {
            do
            {
                Console.WriteLine(ObliczNtyElement(n));
                n--;
            } while (n != 0) ;
        }
        public static void WyswietlInformacje()
        {

            Console.WriteLine("\nCiąg Fibonacciego - ciąg liczb naturalnych określony rekurencyjnie w sposób następujący: Zerowy wyraz jest równy 0, pierwszy jest równy 1, każdy następny jest sumą dwóch poprzednich.");
        }
    }
}
