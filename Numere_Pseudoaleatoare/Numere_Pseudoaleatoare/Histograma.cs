using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numere_Pseudoaleatoare
{
    class Histograma
    {
        public List<String> nume;
        public List<double> valoare;

        public Histograma(List<String> nume, List<double> valoare)
        {
            this.nume = new List<string>(nume);
            this.valoare = new List<double>(valoare);
        }

        public Histograma(List<string> nume,List<int> valoare)
        {
            this.nume = new List<string>(nume);
            this.valoare = new List<double>();
            foreach(int x in valoare)
            {
                this.valoare.Add(Convert.ToDouble(x));
            }
        }
    }
}
