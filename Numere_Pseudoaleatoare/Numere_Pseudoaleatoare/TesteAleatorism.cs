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

        public void TestFrecventaBiti(int[] Frecventa)
        {
            int n = Frecventa[0] + Frecventa[1];
            double Rezultat = (((Frecventa[0] - (n/2)) * (Frecventa[0] - (n/2)))/(n/2)) + (((Frecventa[1] - (n/2)) * (Frecventa[1] - (n/2)))/(n/2)) ;
            if(Rezultat < 3.841)
                MessageBox.Show("Aleatorism foarte bun");
            if(Rezultat >= 3.841 && Rezultat < 6.635)
                MessageBox.Show("Aleatorism bun");
            if(Rezultat > 6.635)
                MessageBox.Show("Aleatorism nesatisfacator");
        }

    }
}
