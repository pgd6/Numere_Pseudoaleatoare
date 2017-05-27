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

        public void TestSpage2Biti(int[] Sparge2Biti)
        {
            int n00, n11, n01, n10;
            n00 = Sparge2Biti[0];
            n11 = Sparge2Biti[1];
            n01 = Sparge2Biti[2];
            n10 = Sparge2Biti[3];
            int n4 = (n00+n11+n01+n10)/ 4;

            double rezultat = (((n00 - n4) * (n00 - n4)) / n4) + (((n11 - n4) * (n11 - n4)) / n4) + (((n01 - n4) * (n01 - n4)) / n4) + (((n10 - n4) * (n10 - n4)) / n4);

            if(rezultat < 7.815)
                MessageBox.Show("Aleatorism foarte bun");
            if(rezultat >= 7.815 && rezultat < 11.341)
                MessageBox.Show("Aleatorism bun");
            if (rezultat > 11.341)
                MessageBox.Show("Aleatorism nesatisfacator");
        }

        public void TestFrecventaCuOcteti(int[] FrecventaOcteti)
        {
            double rezultat = 0;
            int LungimeaSir = 0;
           
            for (int i = 0; i < FrecventaOcteti.Length; i++)
                LungimeaSir += FrecventaOcteti[i];
            double LungimeaSirPeNrDeCaractere = (double)LungimeaSir / 256;
            for (int i=0;i<FrecventaOcteti.Length;i++)
            {
                if(FrecventaOcteti[i]!=0)
                rezultat += ((FrecventaOcteti[i] - LungimeaSirPeNrDeCaractere) * (FrecventaOcteti[i] - LungimeaSirPeNrDeCaractere)) / LungimeaSirPeNrDeCaractere;
            }
            if (rezultat < 301.128)
                MessageBox.Show("Aleatorism foarte bun");
            if (rezultat >= 301.128 && rezultat < 316.939)
                MessageBox.Show("Aleatorism bun");
            if (rezultat > 316.93)
                MessageBox.Show("Aleatorism nesatisfacator");
        }
        
        public void TestFrecventaCharacterHexa(int[] FrecventaCaracterHexa)
        {
            double rezultat = 0;
            int LungimeaSir = 0;

            for (int i = 0; i < FrecventaCaracterHexa.Length; i++)
                LungimeaSir += FrecventaCaracterHexa[i];
            double LungimeaSirPeNrDeCaractere = (double)LungimeaSir / 16;
            for (int i = 0; i < FrecventaCaracterHexa.Length; i++)
            {
                if (FrecventaCaracterHexa[i] != 0)
                    rezultat += ((FrecventaCaracterHexa[i] - LungimeaSirPeNrDeCaractere) * (FrecventaCaracterHexa[i] - LungimeaSirPeNrDeCaractere)) / LungimeaSirPeNrDeCaractere;
            }
            if (rezultat < 24.996)
                MessageBox.Show("Aleatorism foarte bun");
            if (rezultat >= 24.996 && rezultat < 30.578)
                MessageBox.Show("Aleatorism bun");
            if (rezultat > 30.578)
                MessageBox.Show("Aleatorism nesatisfacator");
        }

    }
}
