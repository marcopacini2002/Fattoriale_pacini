using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class CalcoliCombinatori
    {
        static public long Fattoriale(long num)
        {
            long fatto = 1;

            for (int i = 1; i <= num; i++)
            {
                fatto = fatto * i;
            }

            return fatto;
        }
    }
}