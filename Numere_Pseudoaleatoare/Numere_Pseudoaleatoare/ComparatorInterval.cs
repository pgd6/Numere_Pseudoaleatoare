using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numere_Pseudoaleatoare
{
    class ComparatorInterval
    {
        public double param1;
        public double param2;

        public ComparatorInterval(double param1, double param2)
        {
            this.param1 = param1;
            this.param2 = param2;
        }

        ComparatorInterval(double[] param)
        {
            this.param1 = param[0];
            this.param2 = param[1];
        }

        public override string ToString()
        {
            return "Intervale: \r\n" + "rezultat <" + param1 + " => " + TipAleatorism.Foarte_Bun.ToString() + "\r\n" + param1 + " >= rezultat < " + param2 + " => " + TipAleatorism.Bun.ToString() + "\r\n" + "rezultat >= " + param2 + " => " + TipAleatorism.Nesatisfacator.ToString();
        }

        public TipAleatorism ToTipAleatorism(double rezultat)
        {
            if (rezultat < param1)
            {
                return TipAleatorism.Foarte_Bun;
            }
            else if (rezultat >= param1 && rezultat < param2)
            {
                return TipAleatorism.Bun;
            }
            return TipAleatorism.Nesatisfacator;
        }

        public TipAleatorism ToTipAleatorism(float rezultat)
        {
            if (rezultat < param1)
            {
                return TipAleatorism.Foarte_Bun;
            }
            else if (rezultat >= param1 && rezultat < param2)
            {
                return TipAleatorism.Bun;
            }
            return TipAleatorism.Nesatisfacator;
        }

        public TipAleatorism ToTipAleatorism(int rezultat)
        {
            if (rezultat < param1)
            {
                return TipAleatorism.Foarte_Bun;
            }
            else if (rezultat >= param1 && rezultat < param2)
            {
                return TipAleatorism.Bun;
            }
            return TipAleatorism.Nesatisfacator;
        }
    }
}
