using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numere_Pseudoaleatoare
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Hello Fgt");
            RandomGenerator test = new RandomGenerator();
            int[] nIntarray = test.RandomArray(100);
            int[] nByteAray = test.ConvertToByteArray(nIntarray);
        }

        private void OpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
