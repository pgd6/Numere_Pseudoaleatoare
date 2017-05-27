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

    }
}
