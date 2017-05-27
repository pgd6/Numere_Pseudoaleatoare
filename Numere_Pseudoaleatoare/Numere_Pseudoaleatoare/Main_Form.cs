using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            btn_ClearFile_Toggle(false);
            RandomGenerator GeneratorRandom = new RandomGenerator();
            TesteAleatorism TesteAleatorism = new TesteAleatorism();
            int[] nIntArray = GeneratorRandom.RandomArray(100);
            int[] nByteArray = GeneratorRandom.ConvertToByteArray(nIntArray);
            string sStringArray = GeneratorRandom.Frecventa(nByteArray);
            int[] nNumarAparitii = GeneratorRandom.NumarDe0si1(sStringArray);
            TesteAleatorism.TestFrecventaBiti(nNumarAparitii);
        }

        private void OpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btn_File_Click(object sender, EventArgs e)
        {
            // Set the File Picker to the current directory.
            OpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();

            // Attempts to show the file dialog.
            if (OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // If successful do things.
                System.IO.StreamReader sr = new System.IO.StreamReader(OpenFileDialog.FileName);

                tb_File.Text = OpenFileDialog.FileName;

                btn_ClearFile_Toggle(true);

                sr.Close();
            }
        }

        private void tb_File_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ClearFile_Click(object sender, EventArgs e)
        {
            tb_File.Text = String.Empty;
            OpenFileDialog = new OpenFileDialog();

            btn_ClearFile_Toggle(false);
        }

        private void btn_ClearFile_Toggle(bool state)
        {
            btn_ClearFile.ForeColor = Color.White;

            if (state == true)
            {
                btn_ClearFile.BackColor = Color.DarkGreen;
            }
            else
            {
                btn_ClearFile.BackColor = Color.LightPink;
            }
            btn_ClearFile.Enabled = state;
        }
    }
}
