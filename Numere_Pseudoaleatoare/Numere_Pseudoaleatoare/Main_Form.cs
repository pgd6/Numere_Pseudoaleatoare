using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            string[] sHexArray = GeneratorRandom.ConvertToHex(nIntArray);
            int[] nFrecventaHex = GeneratorRandom.FrecventaHex(sHexArray);
            string sStringArray = GeneratorRandom.Frecventa(nByteArray);
            int[] nNumarAparitii = GeneratorRandom.NumarDe0si1(sStringArray);
            int[] nSpargeIn2Biti = GeneratorRandom.SpargInDoiBiti(sStringArray);
            int[] nFrecventaCaracterHex = GeneratorRandom.FrecventaCaracterHex(sHexArray);
            TesteAleatorism.TestFrecventaCharacterHexa(nFrecventaCaracterHex);
            TesteAleatorism.TestFrecventaCuOcteti(nFrecventaHex);
            // TesteAleatorism.TestFrecventaBiti(nNumarAparitii);
            //  TesteAleatorism.TestSpage2Biti(nSpargeIn2Biti);
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

                InitializeFileString(sr.ReadToEnd().ToString());

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
            Program.fileString = String.Empty;

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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Student: George-Dan PRODAN \r\n" + "Profesor Coordonator: Lect. Univ. Dr. Dan-Laurentiu GRECU \r\n\r\n" + "Universitatea \"Titu Maiorescu\" Bucuresti \r\n" + "Sesiunea Iunie/Iulie 2017", "About", MessageBoxButtons.OK);
        }

        private void InitializeFileString(String str)
        {
            str = Regex.Replace(str, "[^0-9]", " ");
            str = Regex.Replace(str, @"\s{2,}", " ").TrimEnd();
            Program.fileString = str;
        }

        private String GetBitString(out bool successful)
        {
            successful = false;

            if (Program.fileString.Equals(string.Empty))
            {
                return null;
            }

            StringBuilder tmpStringBuilder = new StringBuilder();

            List<String> stringNumbers = new List<String>(Program.fileString.Split(new char[] { ' ' }));
            List<int> numbers = new List<int>(stringNumbers.Count);
            foreach (String str in stringNumbers)
            {
                numbers.Add(int.Parse(str));
            }

            foreach (int tmpInt in numbers)
            {
                tmpStringBuilder.Append(Program.GetIntBinaryString(tmpInt));
            }

            return tmpStringBuilder.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool successful;
            GetBitString(out successful);
        }

    }
}
