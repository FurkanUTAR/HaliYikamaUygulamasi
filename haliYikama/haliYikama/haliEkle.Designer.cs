namespace haliYikama
{
    partial class haliEkle
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
            this.metreKareTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adetComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.urunComboBox = new System.Windows.Forms.ComboBox();
            this.eklePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.eklePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // metreKareTextBox
            // 
            this.metreKareTextBox.Location = new System.Drawing.Point(162, 54);
            this.metreKareTextBox.Name = "metreKareTextBox";
            this.metreKareTextBox.Size = new System.Drawing.Size(32, 20);
            this.metreKareTextBox.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "m²";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Adet";
            // 
            // adetComboBox
            // 
            this.adetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.adetComboBox.FormattingEnabled = true;
            this.adetComboBox.Location = new System.Drawing.Point(113, 54);
            this.adetComboBox.Name = "adetComboBox";
            this.adetComboBox.Size = new System.Drawing.Size(43, 21);
            this.adetComboBox.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Ürün";
            // 
            // urunComboBox
            // 
            this.urunComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.urunComboBox.FormattingEnabled = true;
            this.urunComboBox.Location = new System.Drawing.Point(12, 54);
            this.urunComboBox.Name = "urunComboBox";
            this.urunComboBox.Size = new System.Drawing.Size(95, 21);
            this.urunComboBox.TabIndex = 56;
            // 
            // eklePictureBox
            // 
            this.eklePictureBox.Image = global::haliYikama.Properties.Resources.addOrder;
            this.eklePictureBox.Location = new System.Drawing.Point(200, 54);
            this.eklePictureBox.Name = "eklePictureBox";
            this.eklePictureBox.Size = new System.Drawing.Size(23, 19);
            this.eklePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eklePictureBox.TabIndex = 63;
            this.eklePictureBox.TabStop = false;
            this.eklePictureBox.Click += new System.EventHandler(this.eklePictureBox_Click);
            // 
            // haliEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 116);
            this.Controls.Add(this.eklePictureBox);
            this.Controls.Add(this.metreKareTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adetComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urunComboBox);
            this.Name = "haliEkle";
            this.Text = "Halı Ekle";
            this.Load += new System.EventHandler(this.haliEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eklePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox eklePictureBox;
        private System.Windows.Forms.TextBox metreKareTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox adetComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox urunComboBox;
    }
}