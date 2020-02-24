using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryEsercizio1;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero");
            int n = int.Parse(Console.ReadLine());
            bool ris = Calcoli.QuadratoPerfetto(n);
            if (ris)
            {
                Console.WriteLine("E' un quadrato perfetto");
            }
            else
            {
                Console.WriteLine("Non è un quadrato perfetto");
            }
            Console.ReadLine();
        }
    }
}
