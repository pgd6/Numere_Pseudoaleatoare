using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numere_Pseudoaleatoare
{
    class RandomGenerator
    {
        Random randomNumber = new Random();

        public int[] RandomArray(int nLength)
        {
            int[] nRandomArray = new int[nLength];
            for(int i=0;i<nLength-1;i++)
            {
                nRandomArray[i] = randomNumber.Next(0,256);
            }
            return nRandomArray;
        }

        public int[] ConvertToByteArray(int[] nIntArray)
        {
            int[] nByteArray = new int[nIntArray.Length];
            for(int i=0;i<nIntArray.Length;i++)
            {
                nByteArray[i] = Convert.ToInt32(Convert.ToString(nIntArray[i], 2));
            }
            return nByteArray;
        }

        public string Frecventa(int[] nByteArray)
        {
            string sFrecventa = null;
            for (int i = 0; i < nByteArray.Length; i++)
            {
                sFrecventa += Convert.ToString(nByteArray[i]);
            }
            return sFrecventa;
        }

        public int[] NumarDe0si1 (string sFrecventa)
        {
            int[] nNumara0si1 = new int[2];
            char[] cCharArray = sFrecventa.ToCharArray();
            for(int i=0;i<sFrecventa.Length;i++)
            {
                if (cCharArray[i] == '0')
                    nNumara0si1[0]++;
                else
                    nNumara0si1[1]++;
            }
            return nNumara0si1;
        }

        public int[] SpargInDoiBiti(string sFrecventa)
        {
            int nLungimeFrecventa = sFrecventa.Length;
            int[] nSpargInDoiBiti = new int[4]; // 0= 00 1=11 2=01 3=10
            char[] cCharArray = sFrecventa.ToCharArray();
            if (sFrecventa.Length % 2 != 0)
                nLungimeFrecventa = sFrecventa.Length - 1;
            for(int i=0;i<nLungimeFrecventa; i=i+2)
            {
                string s = Convert.ToString(cCharArray[i]) + Convert.ToString(cCharArray[i + 1]);
                if (s == "00")
                    nSpargInDoiBiti[0]++;
                else
                if (s == "11")
                    nSpargInDoiBiti[1]++;
                else
                if (s == "01")
                    nSpargInDoiBiti[2]++;
                else
                if (s == "10")
                    nSpargInDoiBiti[3]++;
            }
            return nSpargInDoiBiti;
        }

    }
}
