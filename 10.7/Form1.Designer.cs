﻿namespace _10._7
{
    partial class Form1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnKasta = new System.Windows.Forms.Button();
            this.tbxResultat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKasta
            // 
            this.btnKasta.Location = new System.Drawing.Point(276, 143);
            this.btnKasta.Name = "btnKasta";
            this.btnKasta.Size = new System.Drawing.Size(247, 33);
            this.btnKasta.TabIndex = 0;
            this.btnKasta.Text = "Kasta Tärningar";
            this.btnKasta.UseVisualStyleBackColor = true;
            this.btnKasta.Click += new System.EventHandler(this.btnKasta_Click);
            // 
            // tbxResultat
            // 
            this.tbxResultat.Location = new System.Drawing.Point(276, 182);
            this.tbxResultat.Multiline = true;
            this.tbxResultat.Name = "tbxResultat";
            this.tbxResultat.ReadOnly = true;
            this.tbxResultat.Size = new System.Drawing.Size(247, 221);
            this.tbxResultat.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxResultat);
            this.Controls.Add(this.btnKasta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnKasta;
        private System.Windows.Forms.TextBox tbxResultat;
    }
}

