namespace haliYikama
{
    partial class musteriDuzenle
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
            this.label1 = new System.Windows.Forms.Label();
            this.adSoyadTextBox = new System.Windows.Forms.TextBox();
            this.telNoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adresTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.duzenleButton = new System.Windows.Forms.Button();
            this.telNoIkiTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.geriDonPictureBox.TabIndex = 38;
            this.geriDonPictureBox.TabStop = false;
            this.geriDonPictureBox.Click += new System.EventHandler(this.geriDonPictureBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Ad-Soyad";
            // 
            // adSoyadTextBox
            // 
            this.adSoyadTextBox.Location = new System.Drawing.Point(44, 62);
            this.adSoyadTextBox.Name = "adSoyadTextBox";
            this.adSoyadTextBox.Size = new System.Drawing.Size(151, 20);
            this.adSoyadTextBox.TabIndex = 40;
            // 
            // telNoTextBox
            // 
            this.telNoTextBox.Location = new System.Drawing.Point(44, 103);
            this.telNoTextBox.Name = "telNoTextBox";
            this.telNoTextBox.Size = new System.Drawing.Size(151, 20);
            this.telNoTextBox.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Telefon Numarası";
            // 
            // adresTextBox
            // 
            this.adresTextBox.Location = new System.Drawing.Point(44, 181);
            this.adresTextBox.Multiline = true;
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.Size = new System.Drawing.Size(156, 67);
            this.adresTextBox.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Adres";
            // 
            // duzenleButton
            // 
            this.duzenleButton.Location = new System.Drawing.Point(44, 254);
            this.duzenleButton.Name = "duzenleButton";
            this.duzenleButton.Size = new System.Drawing.Size(156, 23);
            this.duzenleButton.TabIndex = 45;
            this.duzenleButton.Text = "Düzenle";
            this.duzenleButton.UseVisualStyleBackColor = true;
            // 
            // telNoIkiTextBox
            // 
            this.telNoIkiTextBox.Location = new System.Drawing.Point(44, 142);
            this.telNoIkiTextBox.Name = "telNoIkiTextBox";
            this.telNoIkiTextBox.Size = new System.Drawing.Size(156, 20);
            this.telNoIkiTextBox.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "2. Telefon Numarası";
            // 
            // musteriDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 476);
            this.Controls.Add(this.telNoIkiTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.duzenleButton);
            this.Controls.Add(this.adresTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.telNoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adSoyadTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.geriDonPictureBox);
            this.Name = "musteriDuzenle";
            this.Text = "Müşteriyi Düzenle";
            this.Load += new System.EventHandler(this.musteriDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox geriDonPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adSoyadTextBox;
        private System.Windows.Forms.TextBox telNoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adresTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button duzenleButton;
        private System.Windows.Forms.TextBox telNoIkiTextBox;
        private System.Windows.Forms.Label label4;
    }
}