﻿namespace haliYikama
{
    partial class gelirGiderTakip
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
            this.geriDonPictureBox = new System.Windows.Forms.PictureBox();
            this.gelirGiderEkleButton = new System.Windows.Forms.Button();
            this.gelirGiderTablosuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // geriDonPictureBox
            // 
            this.geriDonPictureBox.Image = global::haliYikama.Properties.Resources.left;
            this.geriDonPictureBox.Location = new System.Drawing.Point(1, 1);
            this.geriDonPictureBox.Name = "geriDonPictureBox";
            this.geriDonPictureBox.Size = new System.Drawing.Size(23, 19);
            this.geriDonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.geriDonPictureBox.TabIndex = 35;
            this.geriDonPictureBox.TabStop = false;
            this.geriDonPictureBox.Click += new System.EventHandler(this.geriDonPictureBox_Click);
            // 
            // gelirGiderEkleButton
            // 
            this.gelirGiderEkleButton.Location = new System.Drawing.Point(12, 98);
            this.gelirGiderEkleButton.Name = "gelirGiderEkleButton";
            this.gelirGiderEkleButton.Size = new System.Drawing.Size(210, 125);
            this.gelirGiderEkleButton.TabIndex = 36;
            this.gelirGiderEkleButton.Text = "Gelir-Gider Ekle";
            this.gelirGiderEkleButton.UseVisualStyleBackColor = true;
            this.gelirGiderEkleButton.Click += new System.EventHandler(this.gelirGiderEkleButton_Click);
            // 
            // gelirGiderTablosuButton
            // 
            this.gelirGiderTablosuButton.Location = new System.Drawing.Point(12, 229);
            this.gelirGiderTablosuButton.Name = "gelirGiderTablosuButton";
            this.gelirGiderTablosuButton.Size = new System.Drawing.Size(210, 125);
            this.gelirGiderTablosuButton.TabIndex = 38;
            this.gelirGiderTablosuButton.Text = "Gelir-Gider Tablosu";
            this.gelirGiderTablosuButton.UseVisualStyleBackColor = true;
            this.gelirGiderTablosuButton.Click += new System.EventHandler(this.gelirGiderTablosuButton_Click);
            // 
            // gelirGiderTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 476);
            this.Controls.Add(this.gelirGiderTablosuButton);
            this.Controls.Add(this.gelirGiderEkleButton);
            this.Controls.Add(this.geriDonPictureBox);
            this.Name = "gelirGiderTakip";
            this.Text = "Gelir-Gider Takip";
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox geriDonPictureBox;
        private System.Windows.Forms.Button gelirGiderEkleButton;
        private System.Windows.Forms.Button gelirGiderTablosuButton;
    }
}