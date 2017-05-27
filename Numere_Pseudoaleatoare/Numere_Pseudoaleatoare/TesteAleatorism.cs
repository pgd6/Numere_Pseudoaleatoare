using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numere_Pseudoaleatoare
{
    class TesteAleatorism
    {

        public static TipAleatorism TestFrecventaBiti(int[] Frecventa)
        {
            int n = Frecventa[0] + Frecventa[1];
            double Rezultat = (((Frecventa[0] - (n / 2)) * (Frecventa[0] - (n / 2))) / (n / 2)) + (((Frecventa[1] - (n / 2)) * (Frecventa[1] - (n / 2))) / (n / 2));
            if (Rezultat < 3.841)
            {
                return TipAleatorism.Foarte_Bun;
            }
            else
            if (Rezultat >= 3.841 && Rezultat < 6.635)
            {
                return TipAleatorism.Bun;
            }
            return TipAleatorism.Nesatisfacator;
        }

        public static TipAleatorism TestSparge2Biti(int[] Sparge2Biti)
        {
            int n00, n11, n01, n10;
            n00 = Sparge2Biti[0];
            n11 = Sparge2Biti[1];
            n01 = Sparge2Biti[2];
            n10 = Sparge2Biti[3];
            int n4 = (n00 + n11 + n01 + n10) / 4;

            double rezultat = (((n00 - n4) * (n00 - n4)) / n4) + (((n11 - n4) * (n11 - n4)) / n4) + (((n01 - n4) * (n01 - n4)) / n4) + (((n10 - n4) * (n10 - n4)) / n4);

            if (rezultat < 7.815)
            {
                return TipAleatorism.Foarte_Bun;
            }
            else
            if (rezultat >= 7.815 && rezultat < 11.341)
            {
                return TipAleatorism.Bun;
            }
            return TipAleatorism.Nesatisfacator;
        }

    }
}
