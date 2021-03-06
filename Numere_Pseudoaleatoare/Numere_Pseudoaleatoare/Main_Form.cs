﻿using System;
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
            //int[] nIntArray = RandomGenerator.RandomArray(100);
            //int[] nByteArray = RandomGenerator.ConvertToBitArray(nIntArray);
            //string[] sHexArray = RandomGenerator.ConvertToHex(nIntArray);
            //int[] nFrecventaHex = RandomGenerator.FrecventaHex(sHexArray);
            //string sStringArray = RandomGenerator.Frecventa(nByteArray);
            //int[] nNumarAparitii = RandomGenerator.NumarDe0si1(sStringArray);
            //int[] nSpargeIn2Biti = RandomGenerator.SpargInDoiBiti(sStringArray);
            //int[] nFrecventaCaracterHex = RandomGenerator.FrecventaDihex(sHexArray);
            //int[] nMatriceCorelatiiSeriale = RandomGenerator.MatriceCorelatiiSeriale(sStringArray);
            //TesteAleatorism.TestFrecventaDihex(nFrecventaCaracterHex);
            //TesteAleatorism.TestFrecventaHex(nFrecventaHex);
            //TesteAleatorism.TestCorealtiiSeriale(nMatriceCorelatiiSeriale, nSpargeIn2Biti);
            //TesteAleatorism.TestFrecventaBiti(nNumarAparitii);
            //TesteAleatorism.TestSpage2Biti(nSpargeIn2Biti);
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

        private void btn_ClearFile_Click(object sender, EventArgs e)
        {
            tb_File.Text = String.Empty;
            OpenFileDialog = new OpenFileDialog();
            Program.fileString = String.Empty;
            Program.fileInt = new int[0];

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

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1) Selectati un fisier care contine numere, orice alte caractere vor fi tratate ca spatiu \r\n\r\n" + "2) Rulati testele \r\n", "Help", MessageBoxButtons.OK);
        }

        private void InitializeFileString(String str)
        {
            str = Regex.Replace(str, "[^0-9]", " ");
            str = Regex.Replace(str, @"\s{2,}", " ").TrimEnd().TrimStart();
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
            Program.fileInt = new int[numbers.Count];
            for (int i = 0; i < numbers.Count; ++i)
            {
                Program.fileInt[i] = numbers[i];
            }

            foreach (int tmpInt in numbers)
            {
                tmpStringBuilder.Append(Program.GetIntBinaryString(tmpInt));
            }
            successful = true;
            return tmpStringBuilder.ToString();
        }

        private void btn_TestFrecvBiti_Click(object sender, EventArgs e)
        {
            tb_Main.Text += ((Button)sender).Text + "\r\n";
            String bitString = GetBitString(out bool successful);
            if (successful)
            {
                tb_Main.Text += TesteAleatorism.TestBiti(RandomGenerator.NumarDe0si1(bitString),out Histograma hist);

                chart_Main.Series["Series_Main"].Points.Clear();
                for (int i = 0; i < hist.nume.Count; ++i)
                {
                    chart_Main.Series["Series_Main"].Points.AddXY(hist.nume[i].ToString(), hist.valoare[i]);
                }
            }
            else
            {
                tb_Main.Text += "Eroare! Verificati daca a fost deschis un fisier!";
            }

            tb_Main.Text += "\r\n\r\n";
        }

        private void btn_TestFrecvDibiti_Click(object sender, EventArgs e)
        {
            tb_Main.Text += ((Button)sender).Text + "\r\n";
            String bitString = GetBitString(out bool successful);
            if (successful)
            {
                tb_Main.Text += TesteAleatorism.TestDibiti(RandomGenerator.SpargInDoiBiti(bitString),out Histograma hist);

                chart_Main.Series["Series_Main"].Points.Clear();
                for (int i = 0; i < hist.nume.Count; ++i)
                {
                    chart_Main.Series["Series_Main"].Points.AddXY(hist.nume[i].ToString(), hist.valoare[i]);
                }
            }
            else
            {
                tb_Main.Text += "Eroare! Verificati daca a fost deschis un fisier!";
            }

            tb_Main.Text += "\r\n\r\n";
        }

        private void btn_TestFrecvHex_Click(object sender, EventArgs e)
        {
            tb_Main.Text += ((Button)sender).Text + "\r\n";
            String bitString = GetBitString(out bool successful);
            if (successful)
            {
                tb_Main.Text += TesteAleatorism.TestFrecventaHex(RandomGenerator.FrecventaHex(RandomGenerator.ConvertToHex(Program.fileInt)),out Histograma hist);

                chart_Main.Series["Series_Main"].Points.Clear();
            }
            else
            {
                tb_Main.Text += "Eroare! Verificati daca a fost deschis un fisier!";
            }

            tb_Main.Text += "\r\n\r\n";
        }

        private void btn_TestFrecvDihex_Click(object sender, EventArgs e)
        {
            tb_Main.Text += ((Button)sender).Text + "\r\n";
            String bitString = GetBitString(out bool successful);
            if (successful)
            {
                tb_Main.Text += TesteAleatorism.TestFrecventaDihex(RandomGenerator.FrecventaDihex(RandomGenerator.ConvertToHex(Program.fileInt)),out Histograma hist);

                chart_Main.Series["Series_Main"].Points.Clear();
            }
            else
            {
                tb_Main.Text += "Eroare! Verificati daca a fost deschis un fisier!";
            }

            tb_Main.Text += "\r\n\r\n";
        }

        private void btn_DistCar0_Click(object sender, EventArgs e)
        {
            tb_Main.Text += ((Button)sender).Text + "\r\n";
            String bitString = GetBitString(out bool successful);
            if (successful)
            {
                tb_Main.Text += TesteAleatorism.DistantaCaractere(bitString, '0', out Histograma hist);

                chart_Main.Series["Series_Main"].Points.Clear();
                for (int i = 1; i < hist.nume.Count; ++i)
                {
                    chart_Main.Series["Series_Main"].Points.AddXY(hist.nume[i].ToString(), hist.valoare[i]);
                }
            }
            else
            {
                tb_Main.Text += "Eroare! Verificati daca a fost deschis un fisier!";
            }

            tb_Main.Text += "\r\n\r\n";
        }

        private void btn_DistCar1_Click(object sender, EventArgs e)
        {
            tb_Main.Text += ((Button)sender).Text + "\r\n";
            String bitString = GetBitString(out bool successful);
            TipAleatorism tip = TipAleatorism.Eroare;
            if (successful)
            {
                tb_Main.Text += TesteAleatorism.DistantaCaractere(bitString, '1',out Histograma hist);

                chart_Main.Series["Series_Main"].Points.Clear();
                for (int i = 1; i < hist.nume.Count; ++i)
                {
                    chart_Main.Series["Series_Main"].Points.AddXY(hist.nume[i].ToString(), hist.valoare[i]);
                }
            }
            else
            {
                tb_Main.Text += "Eroare! Verificati daca a fost deschis un fisier!";
            }

            tb_Main.Text += "\r\n\r\n";
        }

        private void btn_TestCorelatiiSeriale_Click(object sender, EventArgs e)
        {
            tb_Main.Text += ((Button)sender).Text + "\r\n";
            String bitString = GetBitString(out bool successful);
            if (successful)
            {
                tb_Main.Text += TesteAleatorism.TestCorealtiiSeriale(RandomGenerator.MatriceCorelatiiSeriale(bitString), RandomGenerator.SpargInDoiBiti(bitString));

                chart_Main.Series["Series_Main"].Points.Clear();
            }
            else
            {
                tb_Main.Text += "Eroare! Verificati daca a fost deschis un fisier!";
            }

            tb_Main.Text += "\r\n\r\n";
        }

        private void btn_TestClasa_Click(object sender, EventArgs e)
        {
            tb_Main.Text += ((Button)sender).Text + "\r\n";
            String bitString = GetBitString(out bool successful);
            if (successful)
            {
                tb_Main.Text += TesteAleatorism.TestClasa(bitString,out Histograma hist);

                chart_Main.Series["Series_Main"].Points.Clear();
                for(int i=0;i<hist.nume.Count;++i)
                {
                    chart_Main.Series["Series_Main"].Points.AddXY(hist.nume[i].ToString(), hist.valoare[i]);
                }
            }
            else
            {
                tb_Main.Text += "Eroare! Verificati daca a fost deschis un fisier!";
            }

            tb_Main.Text += "\r\n\r\n";
        }

        private void btn_ClearText_Click(object sender, EventArgs e)
        {
            tb_Main.Text = String.Empty;
            chart_Main.Series["Series_Main"].Points.Clear();
        }
    }
}
