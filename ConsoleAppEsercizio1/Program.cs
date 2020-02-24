using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEsercizio1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=1; i < 100; i++)
            {
                if(i % 2 == 0)
                {
                    Console.Write($" {i} ");
                    if( i!= 100)
                    {
                        Console.Write($" , ");
                    }
                }
            }
            Console.WriteLine();
            int n;
            do
            {
                Console.WriteLine("Inserisci un numero");
                n = int.Parse(Console.ReadLine());

            } while (n != 0);

            Console.ReadLine();
            int a;
            do
            {
                Console.WriteLine("Inserisci un numero");
                a = int.Parse(Console.ReadLine());

            } while (a < 0);
            if(a % 2 == 0)
            {
                Console.WriteLine("Il numero è pari");
            }
            else
            {
                Console.WriteLine("Il numero è dispari");
            }
            Console.ReadLine();
        }
    }
}
