﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numere_Pseudoaleatoare
{
    class RandomGenerator
    {

        public static int[] RandomArray(int nLength)
        {
            Random randomNumber = new Random();
            int[] nRandomArray = new int[nLength];
            for (int i = 0; i < nLength; i++)
            {
                nRandomArray[i] = randomNumber.Next(0, 256);
            }
            return nRandomArray;
        }

        public static int[] ConvertToBitArray(int[] nIntArray)
        {
            int[] nByteArray = new int[nIntArray.Length];
            for (int i = 0; i < nIntArray.Length; i++)
            {
                nByteArray[i] = Convert.ToInt32(Convert.ToString(nIntArray[i], 2));
            }
            return nByteArray;
        }

        public static string[] ConvertToHex(int[] nIntArray)
        {
            string[] sHexArray = new string[nIntArray.Length];
            for (int i = 0; i < nIntArray.Length; i++)
            {
                sHexArray[i] = nIntArray[i].ToString("X");
            }
            return sHexArray;
        }

        public static int[] FrecventaHex(string[] sHexArray)
        {
            int[] sFrecventaHex = new int[256];
            for (int i = 0; i < sHexArray.Length; i++)
            {
                int pozitie = int.Parse(sHexArray[i], NumberStyles.HexNumber);
                pozitie = pozitie % 255;
                sFrecventaHex[pozitie]++;
            }
            return sFrecventaHex;
        }

        public static string Frecventa(int[] nByteArray)
        {
            string sFrecventa = null;
            for (int i = 0; i < nByteArray.Length; i++)
            {
                sFrecventa += Convert.ToString(nByteArray[i]);
            }
            return sFrecventa;
        }

        public static string ConvertStringArrayToString(string[] array)
        {
            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {
                builder.Append(value + ".");
            }
            return builder.ToString();
        }

        public static int[] FrecventaDihex(string[] HexArray)
        {
            string sHexArray = ConvertStringArrayToString(HexArray);
            char[] cHexArray = sHexArray.ToCharArray();
            int[] FrecventaCaracterHex = new int[16];
            for (int i = 0; i < cHexArray.Length; i++)
            {
                if (cHexArray[i] == '0')
                    FrecventaCaracterHex[0]++;
                if (cHexArray[i] == '1')
                    FrecventaCaracterHex[1]++;
                if (cHexArray[i] == '2')
                    FrecventaCaracterHex[2]++;
                if (cHexArray[i] == '3')
                    FrecventaCaracterHex[3]++;
                if (cHexArray[i] == '4')
                    FrecventaCaracterHex[4]++;
                if (cHexArray[i] == '5')
                    FrecventaCaracterHex[5]++;
                if (cHexArray[i] == '5')
                    FrecventaCaracterHex[5]++;
                if (cHexArray[i] == '6')
                    FrecventaCaracterHex[6]++;
                if (cHexArray[i] == '7')
                    FrecventaCaracterHex[7]++;
                if (cHexArray[i] == '8')
                    FrecventaCaracterHex[8]++;
                if (cHexArray[i] == '9')
                    FrecventaCaracterHex[9]++;
                if (cHexArray[i] == 'A')
                    FrecventaCaracterHex[10]++;
                if (cHexArray[i] == 'B')
                    FrecventaCaracterHex[11]++;
                if (cHexArray[i] == 'C')
                    FrecventaCaracterHex[12]++;
                if (cHexArray[i] == 'D')
                    FrecventaCaracterHex[13]++;
                if (cHexArray[i] == 'E')
                    FrecventaCaracterHex[14]++;
                if (cHexArray[i] == 'F')
                    FrecventaCaracterHex[15]++;
            }
            return FrecventaCaracterHex;
        }

        public static int[] NumarDe0si1(string sFrecventa)
        {
            int[] nNumara0si1 = new int[2];
            char[] cCharArray = sFrecventa.ToCharArray();
            for (int i = 0; i < sFrecventa.Length; i++)
            {
                if (cCharArray[i] == '0')
                    nNumara0si1[0]++;
                else
                    nNumara0si1[1]++;
            }
            return nNumara0si1;
        }

        public static int[] SpargInDoiBiti(string sFrecventa)
        {
            int nLungimeFrecventa = sFrecventa.Length;
            int[] nSpargInDoiBiti = new int[4]; // 0= 00 1=11 2=01 3=10
            char[] cCharArray = sFrecventa.ToCharArray();
            if (sFrecventa.Length % 2 != 0)
                nLungimeFrecventa = sFrecventa.Length - 1;
            for (int i = 0; i < nLungimeFrecventa; i = i + 2)
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

        public static String StringRepeater(String str, int num)
        {
            StringBuilder tmpStr = new StringBuilder();
            for (int i = 0; i < num; i++)
            {
                tmpStr.Append(str);
            }
            return tmpStr.ToString();
        }

        public static int[] MatriceCorelatiiSeriale(string sStringBinar) // 01 00 - 0  si 10 11 - 1  Sparge in modu asta si dupa face suma de 1 si de 0
        {
            char[] cCharArray = sStringBinar.ToCharArray();
            int nLungimeMatrice = sStringBinar.Length;
            int[] nMatriceCorelatiiSeriale = new int[2];
            if (sStringBinar.Length % 2 != 0)
                nLungimeMatrice = sStringBinar.Length - 1;
            for (int i = 0; i < nLungimeMatrice; i = i + 2)
            {
                string s = Convert.ToString(cCharArray[i]) + Convert.ToString(cCharArray[i + 1]);
                if (s == "00" || s == "01")
                    nMatriceCorelatiiSeriale[0]++;
                else
                if (s == "11" || s == "10")
                    nMatriceCorelatiiSeriale[1]++;
            }
            return nMatriceCorelatiiSeriale;
        }
    }
}
