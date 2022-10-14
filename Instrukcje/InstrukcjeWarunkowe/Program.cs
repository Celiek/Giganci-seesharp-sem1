using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrukcjeWarunkowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zmienna1 = 123;
            int zmienna2 = 0;

            //sprawdzanie czy jedna zmienna jest wieksza od drugiej
            if(zmienna2 > zmienna1)
            {
                Console.WriteLine("zmienna 2 jest wieksza od 1");
            } else {
                Console.WriteLine("zmienna 2 nie jest wieksza od 1 ");
            }

            //sprawdzanie czy jedna zmienna jest mniejsza od drugiej
            if (zmienna2 < zmienna1)
            {
                Console.WriteLine("zmienna 2 jest mniejsza od 1");
            }
            else
            {
                Console.WriteLine("zmienna 2 nie jest mneijsza od 1 ");
            }

            //sprwadzanie czy zmienna 1 jest równa 2
            //znak = to znak przypisania 
            //zmienna równa się 2
            //int a == 2;
            if (zmienna2 == zmienna1)
            {
                Console.WriteLine("zmienna 2 jest wieksza od 1");
            }
            else
            {
                Console.WriteLine("zmienna 2 nie jest wieksza od 1 ");
            }

            //zmienna 1 jest różna od 2

            if( zmienna2 != zmienna1)
            {
                Console.WriteLine("zmienna 2 jest rózna od 1");
            } else
            {
                Console.WriteLine("zmienna 1 jest równa 2");
            }

            int zmienna3 = 10;
            int zmienna4 = 10;

            //sprawdzanie warunków zmiennych and 
            if( (zmienna3 > zmienna4) && (zmienna2 > zmienna1))
            
                Console.WriteLine(
                    "zmienna 3 jest wieksza od 4 i zmienna 2 jest wieksza od 1");
             else
            
                Console.WriteLine(
                   "zmienna 3 jest mniejsza od 4 i zmienna 2 jest mniejsza od 1");
            


            //sprawdzanie warunków zmiennych and 
            if ((zmienna3 > zmienna4) || (zmienna2 > zmienna1))
            {
                Console.WriteLine(
                    "zmienna 3 jest wieksza od 4 i zmienna 2 jest wieksza od 1");
            }
            else
            {
                Console.WriteLine(
                   "zmienna 3 jest mniejsza od 4 i zmienna 2 jest mniejsza od 1");
            }

            //zajecia 4:


            Console.ReadLine();
        }
    }
}
