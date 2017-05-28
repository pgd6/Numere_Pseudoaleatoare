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
            else if (Rezultat >= 3.841 && Rezultat < 6.635)
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
            else if (rezultat >= 7.815 && rezultat < 11.341)
            {
                return TipAleatorism.Bun;
            }
            return TipAleatorism.Nesatisfacator;
        }

        public static TipAleatorism TestFrecventaCuOcteti(int[] FrecventaOcteti)
        {
            double rezultat = 0;
            int LungimeaSir = 0;

            for (int i = 0; i < FrecventaOcteti.Length; i++)
                LungimeaSir += FrecventaOcteti[i];
            double LungimeaSirPeNrDeCaractere = (double)LungimeaSir / 256;
            for (int i = 0; i < FrecventaOcteti.Length; i++)
            {
                if (FrecventaOcteti[i] != 0)
                    rezultat += ((FrecventaOcteti[i] - LungimeaSirPeNrDeCaractere) * (FrecventaOcteti[i] - LungimeaSirPeNrDeCaractere)) / LungimeaSirPeNrDeCaractere;
            }
            if (rezultat < 301.128)
            {
                return TipAleatorism.Foarte_Bun;
            }
            else if (rezultat >= 301.128 && rezultat < 316.939)
            {
                return TipAleatorism.Bun;
            }
            return TipAleatorism.Nesatisfacator;
        }

        public static TipAleatorism TestFrecventaCharacterHexa(int[] FrecventaCaracterHexa)
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
            {
                return TipAleatorism.Foarte_Bun;
            }
            else if (rezultat >= 24.996 && rezultat < 30.578)
            {
                return TipAleatorism.Bun;
            }
            return TipAleatorism.Nesatisfacator;
        }

        public static TipAleatorism DistantaCaractere(String sir, char caracter)
        {
            double rezultat = 0;
            int numarTotalMarks = 0;
            int[] numarAparitii = new int[11];
            double[] numarNormalizatMarks = new double[11];
            double[] probabilitate = new double[11];

            int distanta = 0;
            foreach (char c in sir)
            {
                if (c == caracter)
                {
                    if (distanta > 10)
                    {
                        distanta = 10;
                    }
                    ++numarAparitii[distanta];
                    distanta = 0;
                }
                else
                {
                    ++distanta;
                }
            }

            for (int i = 1; i < 11; ++i)
            {
                probabilitate[i] = 1f / Math.Pow(2, i);
                numarTotalMarks += numarAparitii[i];
            }

            // Total gap number
            for (int i = 1; i < 11; ++i)
            {
                numarNormalizatMarks[i] = numarTotalMarks * probabilitate[i];
            }

            for (int i=1;i<11;++i)
            {
                double sumI = Math.Pow(numarAparitii[i] - numarNormalizatMarks[i], 2) / numarNormalizatMarks[i];
                
                // If sumI wasn't divided by 0
                if (!double.IsNaN(sumI))
                {
                    rezultat += sumI;
                }
            }


            if (rezultat < 16.919)
            {
                return TipAleatorism.Foarte_Bun;
            }
            else if (rezultat >= 16.919 && rezultat < 21.666)
            {
                return TipAleatorism.Bun;
            }
            return TipAleatorism.Nesatisfacator;

        }


    }
}
