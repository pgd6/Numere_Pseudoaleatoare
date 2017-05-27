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
            int[] nRandomArray = new int[nLength-1];
            for(int i=0;i<nLength-1;i++)
            {
                nRandomArray[i] = randomNumber.Next(0,byte.MaxValue);
            }
            return nRandomArray;
        }

        public int[] ConvertToByteArray(int[] nIntArray)
        {
            int[] bByteArray = new int[nIntArray.Length];
            for(int i=0;i<nIntArray.Length;i++)
            {
                bByteArray[i] = Convert.ToInt32(Convert.ToString(nIntArray[i],2));
            }
            return bByteArray;
        }
    }
}
