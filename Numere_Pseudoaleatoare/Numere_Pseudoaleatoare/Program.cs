using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numere_Pseudoaleatoare
{
    static class Program
    {
        public static String fileString = String.Empty;
        public static int[] fileInt;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_Form());
        }

        public static String GetIntBinaryString(int n)
        {
            char[] b = new char[32];
            int pos = 31;
            int i = 0;

            while (i < 32)
            {
                if ((n & (1 << i)) != 0)
                {
                    b[pos] = '1';
                }
                else
                {
                    b[pos] = '0';
                }
                pos--;
                i++;
            }
            char[] a = new char[8];
            for (int j = 24; j < 32; ++j)
            {
                a[j - 24] = b[j];
            }
            return new string(a);
        }

        public static int Combinari(int n, int k)
        {

            double result = 1.0;

            for (int i = 0; i < k; i++)
            {
                result *= (double)(n - i) / (i + 1.0);
            }

            return (int) result;
        }
    }
}
