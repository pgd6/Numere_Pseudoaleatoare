namespace Numere_Pseudoaleatoare
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
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_File = new System.Windows.Forms.Button();
            this.tb_File = new System.Windows.Forms.TextBox();
            this.btn_ClearFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog_FileOk);
            // 
            // btn_File
            // 
            this.btn_File.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_File.Location = new System.Drawing.Point(12, 298);
            this.btn_File.Name = "btn_File";
            this.btn_File.Size = new System.Drawing.Size(75, 23);
            this.btn_File.TabIndex = 0;
            this.btn_File.Text = "Select File";
            this.btn_File.UseVisualStyleBackColor = true;
            this.btn_File.Click += new System.EventHandler(this.btn_File_Click);
            // 
            // tb_File
            // 
            this.tb_File.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_File.Location = new System.Drawing.Point(93, 300);
            this.tb_File.Name = "tb_File";
            this.tb_File.ReadOnly = true;
            this.tb_File.Size = new System.Drawing.Size(315, 20);
            this.tb_File.TabIndex = 1;
            this.tb_File.TextChanged += new System.EventHandler(this.tb_File_TextChanged);
            // 
            // btn_ClearFile
            // 
            this.btn_ClearFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ClearFile.Location = new System.Drawing.Point(414, 298);
            this.btn_ClearFile.Name = "btn_ClearFile";
            this.btn_ClearFile.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearFile.TabIndex = 2;
            this.btn_ClearFile.Text = "Clear File";
            this.btn_ClearFile.UseVisualStyleBackColor = true;
            this.btn_ClearFile.Click += new System.EventHandler(this.btn_ClearFile_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 333);
            this.Controls.Add(this.btn_ClearFile);
            this.Controls.Add(this.tb_File);
            this.Controls.Add(this.btn_File);
            this.Name = "Main_Form";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button btn_File;
        private System.Windows.Forms.TextBox tb_File;
        private System.Windows.Forms.Button btn_ClearFile;
    }
}

