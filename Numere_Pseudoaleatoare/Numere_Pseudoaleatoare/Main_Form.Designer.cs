﻿namespace Numere_Pseudoaleatoare
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_File = new System.Windows.Forms.Button();
            this.tb_File = new System.Windows.Forms.TextBox();
            this.btn_ClearFile = new System.Windows.Forms.Button();
            this.tb_Main = new System.Windows.Forms.TextBox();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_TestCorelatiiSeriale = new System.Windows.Forms.Button();
            this.btn_DistCar1 = new System.Windows.Forms.Button();
            this.btn_DistCar0 = new System.Windows.Forms.Button();
            this.btn_TestFrecvDiHex = new System.Windows.Forms.Button();
            this.btn_TestFrecvHex = new System.Windows.Forms.Button();
            this.btn_TestFrecvDibiti = new System.Windows.Forms.Button();
            this.btn_TestFrecvBiti = new System.Windows.Forms.Button();
            this.btn_ClearText = new System.Windows.Forms.Button();
            this.chart_Main = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_TestClasa = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_File
            // 
            this.btn_File.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_File.Location = new System.Drawing.Point(12, 293);
            this.btn_File.Name = "btn_File";
            this.btn_File.Size = new System.Drawing.Size(75, 23);
            this.btn_File.TabIndex = 0;
            this.btn_File.Text = "Select File";
            this.btn_File.UseVisualStyleBackColor = true;
            this.btn_File.Click += new System.EventHandler(this.btn_File_Click);
            // 
            // tb_File
            // 
            this.tb_File.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_File.Location = new System.Drawing.Point(93, 295);
            this.tb_File.Name = "tb_File";
            this.tb_File.ReadOnly = true;
            this.tb_File.Size = new System.Drawing.Size(702, 20);
            this.tb_File.TabIndex = 1;
            // 
            // btn_ClearFile
            // 
            this.btn_ClearFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ClearFile.Location = new System.Drawing.Point(801, 295);
            this.btn_ClearFile.Name = "btn_ClearFile";
            this.btn_ClearFile.Size = new System.Drawing.Size(95, 23);
            this.btn_ClearFile.TabIndex = 2;
            this.btn_ClearFile.Text = "Clear Selection";
            this.btn_ClearFile.UseVisualStyleBackColor = true;
            this.btn_ClearFile.Click += new System.EventHandler(this.btn_ClearFile_Click);
            // 
            // tb_Main
            // 
            this.tb_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Main.Location = new System.Drawing.Point(332, 41);
            this.tb_Main.MaxLength = 100000;
            this.tb_Main.Multiline = true;
            this.tb_Main.Name = "tb_Main";
            this.tb_Main.ReadOnly = true;
            this.tb_Main.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_Main.Size = new System.Drawing.Size(289, 248);
            this.tb_Main.TabIndex = 13;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToUseToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("howToUseToolStripMenuItem.Image")));
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.howToUseToolStripMenuItem.Text = "How to use";
            this.howToUseToolStripMenuItem.Click += new System.EventHandler(this.howToUseToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.Control;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1009, 24);
            this.Menu.TabIndex = 14;
            this.Menu.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_TestClasa);
            this.panel1.Controls.Add(this.btn_TestCorelatiiSeriale);
            this.panel1.Controls.Add(this.btn_DistCar1);
            this.panel1.Controls.Add(this.btn_DistCar0);
            this.panel1.Controls.Add(this.btn_TestFrecvDiHex);
            this.panel1.Controls.Add(this.btn_TestFrecvHex);
            this.panel1.Controls.Add(this.btn_TestFrecvDibiti);
            this.panel1.Controls.Add(this.btn_TestFrecvBiti);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 248);
            this.panel1.TabIndex = 15;
            // 
            // btn_TestCorelatiiSeriale
            // 
            this.btn_TestCorelatiiSeriale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TestCorelatiiSeriale.Location = new System.Drawing.Point(159, 127);
            this.btn_TestCorelatiiSeriale.Name = "btn_TestCorelatiiSeriale";
            this.btn_TestCorelatiiSeriale.Size = new System.Drawing.Size(150, 55);
            this.btn_TestCorelatiiSeriale.TabIndex = 7;
            this.btn_TestCorelatiiSeriale.Text = "Test Corelatii Seriale";
            this.btn_TestCorelatiiSeriale.UseVisualStyleBackColor = true;
            this.btn_TestCorelatiiSeriale.Click += new System.EventHandler(this.btn_TestCorelatiiSeriale_Click);
            // 
            // btn_DistCar1
            // 
            this.btn_DistCar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DistCar1.Location = new System.Drawing.Point(159, 64);
            this.btn_DistCar1.Name = "btn_DistCar1";
            this.btn_DistCar1.Size = new System.Drawing.Size(150, 55);
            this.btn_DistCar1.TabIndex = 6;
            this.btn_DistCar1.Text = "Test Distanta Caracter \'1\'";
            this.btn_DistCar1.UseVisualStyleBackColor = true;
            this.btn_DistCar1.Click += new System.EventHandler(this.btn_DistCar1_Click);
            // 
            // btn_DistCar0
            // 
            this.btn_DistCar0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DistCar0.Location = new System.Drawing.Point(159, 3);
            this.btn_DistCar0.Name = "btn_DistCar0";
            this.btn_DistCar0.Size = new System.Drawing.Size(150, 55);
            this.btn_DistCar0.TabIndex = 5;
            this.btn_DistCar0.Text = "Test Distanta Caracter \'0\'";
            this.btn_DistCar0.UseVisualStyleBackColor = true;
            this.btn_DistCar0.Click += new System.EventHandler(this.btn_DistCar0_Click);
            // 
            // btn_TestFrecvDiHex
            // 
            this.btn_TestFrecvDiHex.Location = new System.Drawing.Point(3, 189);
            this.btn_TestFrecvDiHex.Name = "btn_TestFrecvDiHex";
            this.btn_TestFrecvDiHex.Size = new System.Drawing.Size(150, 55);
            this.btn_TestFrecvDiHex.TabIndex = 4;
            this.btn_TestFrecvDiHex.Text = "Test Frecventa Dihexazecimale";
            this.btn_TestFrecvDiHex.UseVisualStyleBackColor = true;
            this.btn_TestFrecvDiHex.Click += new System.EventHandler(this.btn_TestFrecvDihex_Click);
            // 
            // btn_TestFrecvHex
            // 
            this.btn_TestFrecvHex.Location = new System.Drawing.Point(3, 127);
            this.btn_TestFrecvHex.Name = "btn_TestFrecvHex";
            this.btn_TestFrecvHex.Size = new System.Drawing.Size(150, 55);
            this.btn_TestFrecvHex.TabIndex = 3;
            this.btn_TestFrecvHex.Text = "Test Frecventa Hexazecimale";
            this.btn_TestFrecvHex.UseVisualStyleBackColor = true;
            this.btn_TestFrecvHex.Click += new System.EventHandler(this.btn_TestFrecvHex_Click);
            // 
            // btn_TestFrecvDibiti
            // 
            this.btn_TestFrecvDibiti.Location = new System.Drawing.Point(3, 64);
            this.btn_TestFrecvDibiti.Name = "btn_TestFrecvDibiti";
            this.btn_TestFrecvDibiti.Size = new System.Drawing.Size(150, 55);
            this.btn_TestFrecvDibiti.TabIndex = 1;
            this.btn_TestFrecvDibiti.Text = "Test Frecventa Dibiti";
            this.btn_TestFrecvDibiti.UseVisualStyleBackColor = true;
            this.btn_TestFrecvDibiti.Click += new System.EventHandler(this.btn_TestFrecvDibiti_Click);
            // 
            // btn_TestFrecvBiti
            // 
            this.btn_TestFrecvBiti.Location = new System.Drawing.Point(3, 3);
            this.btn_TestFrecvBiti.Name = "btn_TestFrecvBiti";
            this.btn_TestFrecvBiti.Size = new System.Drawing.Size(150, 55);
            this.btn_TestFrecvBiti.TabIndex = 0;
            this.btn_TestFrecvBiti.Text = "Test Frecventa Biti";
            this.btn_TestFrecvBiti.UseVisualStyleBackColor = true;
            this.btn_TestFrecvBiti.Click += new System.EventHandler(this.btn_TestFrecvBiti_Click);
            // 
            // btn_ClearText
            // 
            this.btn_ClearText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ClearText.Location = new System.Drawing.Point(902, 295);
            this.btn_ClearText.Name = "btn_ClearText";
            this.btn_ClearText.Size = new System.Drawing.Size(95, 23);
            this.btn_ClearText.TabIndex = 16;
            this.btn_ClearText.Text = "Clear Text";
            this.btn_ClearText.UseVisualStyleBackColor = true;
            this.btn_ClearText.Click += new System.EventHandler(this.btn_ClearText_Click);
            // 
            // chart_Main
            // 
            this.chart_Main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_Main.BorderlineColor = System.Drawing.Color.DimGray;
            this.chart_Main.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.BorderColor = System.Drawing.Color.Empty;
            chartArea1.Name = "ChartArea1";
            this.chart_Main.ChartAreas.Add(chartArea1);
            this.chart_Main.Location = new System.Drawing.Point(628, 41);
            this.chart_Main.Name = "chart_Main";
            this.chart_Main.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.MarkerBorderColor = System.Drawing.Color.Black;
            series1.Name = "Series_Main";
            this.chart_Main.Series.Add(series1);
            this.chart_Main.Size = new System.Drawing.Size(369, 248);
            this.chart_Main.TabIndex = 17;
            // 
            // btn_TestClasa
            // 
            this.btn_TestClasa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TestClasa.Location = new System.Drawing.Point(159, 188);
            this.btn_TestClasa.Name = "btn_TestClasa";
            this.btn_TestClasa.Size = new System.Drawing.Size(150, 55);
            this.btn_TestClasa.TabIndex = 8;
            this.btn_TestClasa.Text = "Test Clasa";
            this.btn_TestClasa.UseVisualStyleBackColor = true;
            this.btn_TestClasa.Click += new System.EventHandler(this.btn_TestClasa_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 328);
            this.Controls.Add(this.chart_Main);
            this.Controls.Add(this.btn_ClearText);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_Main);
            this.Controls.Add(this.btn_ClearFile);
            this.Controls.Add(this.tb_File);
            this.Controls.Add(this.btn_File);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Name = "Main_Form";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button btn_File;
        private System.Windows.Forms.TextBox tb_File;
        private System.Windows.Forms.Button btn_ClearFile;
        private System.Windows.Forms.TextBox tb_Main;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_TestFrecvBiti;
        private System.Windows.Forms.Button btn_TestFrecvDibiti;
        private System.Windows.Forms.Button btn_TestFrecvHex;
        private System.Windows.Forms.Button btn_TestFrecvDiHex;
        private System.Windows.Forms.Button btn_DistCar1;
        private System.Windows.Forms.Button btn_DistCar0;
        private System.Windows.Forms.Button btn_TestCorelatiiSeriale;
        private System.Windows.Forms.Button btn_ClearText;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Main;
        private System.Windows.Forms.Button btn_TestClasa;
    }
}

