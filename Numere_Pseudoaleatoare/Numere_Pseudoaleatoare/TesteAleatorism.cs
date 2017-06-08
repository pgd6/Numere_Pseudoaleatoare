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
        public static String TestBiti(int[] Frecventa, out Histograma hist)
        {
            ComparatorInterval CI = new ComparatorInterval(3.841, 6.635);
            String concluzie = String.Empty;
            int n = Frecventa[0] + Frecventa[1];
            double rezultat = (((Frecventa[0] - (n / 2)) * (Frecventa[0] - (n / 2))) / (n / 2)) + (((Frecventa[1] - (n / 2)) * (Frecventa[1] - (n / 2))) / (n / 2));

            concluzie += CI.ToString() + "\r\n\r\n";
            concluzie += "Rezultat: " + rezultat + " => " + CI.ToTipAleatorism(rezultat).ToString()+ "\r\n";

            List<String> histNume = new List<string>();
            for (int i = 0; i <= 1; ++i)
            {
                histNume.Add(i.ToString());
            }
            List<int> histVal = new List<int>(Frecventa);
            hist = new Histograma(histNume, histVal);

            return concluzie;
        }

        public static String TestDibiti(int[] Sparge2Biti,out Histograma hist)
        {
            ComparatorInterval CI = new ComparatorInterval(301.128, 316.939);
            String concluzie = String.Empty;
            int n00, n11, n01, n10;
            n00 = Sparge2Biti[0];
            n11 = Sparge2Biti[1];
            n01 = Sparge2Biti[2];
            n10 = Sparge2Biti[3];
            int n4 = (n00 + n11 + n01 + n10) / 4;

            double rezultat = (((n00 - n4) * (n00 - n4)) / n4) + (((n11 - n4) * (n11 - n4)) / n4) + (((n01 - n4) * (n01 - n4)) / n4) + (((n10 - n4) * (n10 - n4)) / n4);

            concluzie += CI.ToString() + "\r\n\r\n";
            concluzie += "Rezultat: " + rezultat + " => " + CI.ToTipAleatorism(rezultat).ToString() + "\r\n";

            List<String> histNume = new List<String>();
            histNume.Add("00");
            histNume.Add("11");
            histNume.Add("01");
            histNume.Add("10");

            List<int> histVal = new List<int>(Sparge2Biti);
            hist = new Histograma(histNume, histVal);

            return concluzie;
        }

        public static String TestFrecventaHex(int[] FrecventaOcteti,out Histograma hist)
        {
            ComparatorInterval CI = new ComparatorInterval(301.128, 316.939);
            String concluzie = String.Empty;
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

            concluzie += CI.ToString() + "\r\n\r\n";
            concluzie += "Rezultat: " + rezultat + " => " + CI.ToTipAleatorism(rezultat).ToString() + "\r\n";

            List<String> histNume = new List<string>();
            for (int i = 0; i <= 15; ++i)
            {
                histNume.Add(i.ToString());
            }
            List<int> histVal = new List<int>(FrecventaOcteti);
            hist = new Histograma(histNume, histVal);

            return concluzie;
        }

        public static String TestFrecventaDihex(int[] FrecventaCaracterHexa,out Histograma hist)
        {
            ComparatorInterval CI = new ComparatorInterval(24.996, 30.578);
            String concluzie = String.Empty;
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

            concluzie += CI.ToString() + "\r\n\r\n";
            concluzie += "Rezultat: " + rezultat + " => " + CI.ToTipAleatorism(rezultat).ToString() + "\r\n";

            List<String> histNume = new List<string>();
            for (int i = 0; i <= 1; ++i)
            {
                histNume.Add(i.ToString());
            }
            List<int> histVal = new List<int>(FrecventaCaracterHexa);
            hist = new Histograma(histNume, histVal);

            return concluzie;
        }

        public static String DistantaCaractere(String sir, char caracter, out Histograma hist)
        {
            ComparatorInterval CI = new ComparatorInterval(16.919, 21.666);
            String concluzie = String.Empty;
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

            for (int i = 1; i < 11; ++i)
            {
                double sumI = Math.Pow(numarAparitii[i] - numarNormalizatMarks[i], 2) / numarNormalizatMarks[i];

                // If sumI wasn't divided by 0
                if (!double.IsNaN(sumI))
                {
                    rezultat += sumI;
                }
            }

            concluzie += CI.ToString() + "\r\n\r\n";
            concluzie += "Rezultat: " + rezultat + " => " + CI.ToTipAleatorism(rezultat).ToString() + "\r\n";

            List<String> histNume = new List<string>();
            for (int i = 0; i <= 9; ++i)
            {
                histNume.Add(i.ToString());
            }
            histNume.Add(">9");
            List<int> histVal = new List<int>(numarAparitii);
            hist = new Histograma(histNume, histVal);

            return concluzie;
        }

        public static String TestCorealtiiSeriale(int[] nMatriceCorelatiiSeriale, int[] nij)
        {
            ComparatorInterval CI = new ComparatorInterval(5.991, 9.210);
            String concluzie = String.Empty;
            int n = nMatriceCorelatiiSeriale[0] + nMatriceCorelatiiSeriale[1];
            double nPe2 = (double)n / 2;
            double nPe4 = (double)n / 4;
            double patruPeN = 4 / (double)n;
            double doiPeN = 2 / (double)n;
            double rezultat;
            double suma1 = 0, suma2 = 0;
            for (int i = 0; i <= 1; i++)
            {
                suma2 += (nMatriceCorelatiiSeriale[i] - nPe2) * (nMatriceCorelatiiSeriale[i] - nPe2);
            }
            for (int i = 0; i < 4; i++)
            {
                suma1 += (nij[i] - nPe4) * (nij[i] - nPe4);
            }
            rezultat = (patruPeN * suma1) - (doiPeN * suma2);

            concluzie += CI.ToString() + "\r\n\r\n";
            concluzie += "Rezultat: " + rezultat + " => " + CI.ToTipAleatorism(rezultat).ToString() + "\r\n";

            return concluzie;
        }

        public static String TestClasa(String bitString, out Histograma hist)
        {
            ComparatorInterval CI = new ComparatorInterval(15.507, 20.09);
            String concluzie = String.Empty;
            int[] clasa = new int[9];
            for(int i=0;i<bitString.Length/8;++i)
            {
                int nr = 0;
                for(int j=i*8;j<(i+1)*8;++j)
                {
                    if(bitString[j]=='1')
                    {
                        ++nr;
                    }
                }
                ++clasa[nr];
            }

            double rezultat = 0;
            for(int i=0;i<=8;++i)
            {
                double ms_real = bitString.Length / 8;
                double temp = ms_real * Program.Combinari(8, i) / 256;
                rezultat += Math.Pow((clasa[i] - temp), 2) / temp;
            }

            concluzie += CI.ToString() + "\r\n\r\n";
            concluzie += "Rezultat: " + rezultat + "=>" + CI.ToTipAleatorism(rezultat).ToString();

            List<String> histNume = new List<string>();
            for (int i = 0; i <= 8; ++i)
            {
                histNume.Add(i.ToString());
            }
            List<int> histVal = new List<int>(clasa);
            hist = new Histograma(histNume, histVal);

            return concluzie;
        }
    }
}
