namespace haliYikama
{
    partial class musteriEkle
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
            this.adSoyadTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.telNoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.adresTextBox = new System.Windows.Forms.TextBox();
            this.musteriEkleButton = new System.Windows.Forms.Button();
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
            this.geriDonPictureBox.TabIndex = 37;
            this.geriDonPictureBox.TabStop = false;
            this.geriDonPictureBox.Click += new System.EventHandler(this.geriDonPictureBox_Click);
            // 
            // adSoyadTextBox
            // 
            this.adSoyadTextBox.Location = new System.Drawing.Point(15, 109);
            this.adSoyadTextBox.Name = "adSoyadTextBox";
            this.adSoyadTextBox.Size = new System.Drawing.Size(207, 20);
            this.adSoyadTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Adı-Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Telefon Numarası";
            // 
            // telNoTextBox
            // 
            this.telNoTextBox.Location = new System.Drawing.Point(15, 148);
            this.telNoTextBox.Name = "telNoTextBox";
            this.telNoTextBox.Size = new System.Drawing.Size(207, 20);
            this.telNoTextBox.TabIndex = 2;
            this.telNoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telNoTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Adres Bilgileri";
            // 
            // adresTextBox
            // 
            this.adresTextBox.Location = new System.Drawing.Point(15, 187);
            this.adresTextBox.Multiline = true;
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.Size = new System.Drawing.Size(207, 44);
            this.adresTextBox.TabIndex = 5;
            // 
            // musteriEkleButton
            // 
            this.musteriEkleButton.Location = new System.Drawing.Point(15, 237);
            this.musteriEkleButton.Name = "musteriEkleButton";
            this.musteriEkleButton.Size = new System.Drawing.Size(207, 42);
            this.musteriEkleButton.TabIndex = 6;
            this.musteriEkleButton.Text = "Müşteri  Ekle";
            this.musteriEkleButton.UseVisualStyleBackColor = true;
            this.musteriEkleButton.Click += new System.EventHandler(this.musteriEkleButton_Click);
            // 
            // musteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 476);
            this.Controls.Add(this.musteriEkleButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.adresTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.telNoTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adSoyadTextBox);
            this.Controls.Add(this.geriDonPictureBox);
            this.Name = "musteriEkle";
            this.Text = "Müşteri Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox geriDonPictureBox;
        private System.Windows.Forms.TextBox adSoyadTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox telNoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adresTextBox;
        private System.Windows.Forms.Button musteriEkleButton;
    }
}