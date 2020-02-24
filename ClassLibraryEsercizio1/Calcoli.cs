using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEsercizio1
{
    public class Calcoli
    {
        public static bool QuadratoPerfetto (int b)
        {
            for (int i = 1; i <= b; i++)
            {
                int q = i * i;
                if (q == b)
                    return true;
                if (q > b)
                    return false;
            }
            return false;
        }
    }
}
