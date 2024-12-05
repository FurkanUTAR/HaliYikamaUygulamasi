namespace haliYikama
{
    partial class alinacaklar
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
            this.urunComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.adetComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.metreKareTextBox = new System.Windows.Forms.TextBox();
            this.eklePictureBox = new System.Windows.Forms.PictureBox();
            this.geriDonPictureBox = new System.Windows.Forms.PictureBox();
            this.gonderButton = new System.Windows.Forms.Button();
            this.indirimTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.indirimEklePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eklePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indirimEklePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // urunComboBox
            // 
            this.urunComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.urunComboBox.FormattingEnabled = true;
            this.urunComboBox.Location = new System.Drawing.Point(11, 43);
            this.urunComboBox.Name = "urunComboBox";
            this.urunComboBox.Size = new System.Drawing.Size(95, 21);
            this.urunComboBox.TabIndex = 37;
            this.urunComboBox.SelectedIndexChanged += new System.EventHandler(this.urunComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Ürün";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(232, 316);
            this.dataGridView1.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Adet";
            // 
            // adetComboBox
            // 
            this.adetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.adetComboBox.FormattingEnabled = true;
            this.adetComboBox.Location = new System.Drawing.Point(112, 43);
            this.adetComboBox.Name = "adetComboBox";
            this.adetComboBox.Size = new System.Drawing.Size(43, 21);
            this.adetComboBox.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "m²";
            // 
            // metreKareTextBox
            // 
            this.metreKareTextBox.Location = new System.Drawing.Point(161, 43);
            this.metreKareTextBox.Name = "metreKareTextBox";
            this.metreKareTextBox.Size = new System.Drawing.Size(32, 20);
            this.metreKareTextBox.TabIndex = 44;
            // 
            // eklePictureBox
            // 
            this.eklePictureBox.Image = global::haliYikama.Properties.Resources.addOrder;
            this.eklePictureBox.Location = new System.Drawing.Point(199, 44);
            this.eklePictureBox.Name = "eklePictureBox";
            this.eklePictureBox.Size = new System.Drawing.Size(23, 19);
            this.eklePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eklePictureBox.TabIndex = 45;
            this.eklePictureBox.TabStop = false;
            this.eklePictureBox.Click += new System.EventHandler(this.eklePictureBox_Click);
            // 
            // geriDonPictureBox
            // 
            this.geriDonPictureBox.Image = global::haliYikama.Properties.Resources.left;
            this.geriDonPictureBox.Location = new System.Drawing.Point(1, 1);
            this.geriDonPictureBox.Name = "geriDonPictureBox";
            this.geriDonPictureBox.Size = new System.Drawing.Size(23, 19);
            this.geriDonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.geriDonPictureBox.TabIndex = 36;
            this.geriDonPictureBox.TabStop = false;
            this.geriDonPictureBox.Click += new System.EventHandler(this.geriDonPictureBox_Click);
            // 
            // gonderButton
            // 
            this.gonderButton.Location = new System.Drawing.Point(1, 428);
            this.gonderButton.Name = "gonderButton";
            this.gonderButton.Size = new System.Drawing.Size(84, 36);
            this.gonderButton.TabIndex = 46;
            this.gonderButton.Text = "Gönder";
            this.gonderButton.UseVisualStyleBackColor = true;
            // 
            // indirimTextBox
            // 
            this.indirimTextBox.Location = new System.Drawing.Point(13, 83);
            this.indirimTextBox.Name = "indirimTextBox";
            this.indirimTextBox.Size = new System.Drawing.Size(95, 20);
            this.indirimTextBox.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "İndirim";
            // 
            // indirimEklePictureBox
            // 
            this.indirimEklePictureBox.Image = global::haliYikama.Properties.Resources.addOrder;
            this.indirimEklePictureBox.Location = new System.Drawing.Point(112, 84);
            this.indirimEklePictureBox.Name = "indirimEklePictureBox";
            this.indirimEklePictureBox.Size = new System.Drawing.Size(23, 19);
            this.indirimEklePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.indirimEklePictureBox.TabIndex = 49;
            this.indirimEklePictureBox.TabStop = false;
            // 
            // alinacaklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 476);
            this.Controls.Add(this.indirimEklePictureBox);
            this.Controls.Add(this.indirimTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gonderButton);
            this.Controls.Add(this.eklePictureBox);
            this.Controls.Add(this.metreKareTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adetComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urunComboBox);
            this.Controls.Add(this.geriDonPictureBox);
            this.Name = "alinacaklar";
            this.Text = "Alınacaklar";
            this.Load += new System.EventHandler(this.alinacaklar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eklePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indirimEklePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox geriDonPictureBox;
        private System.Windows.Forms.ComboBox urunComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox adetComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox metreKareTextBox;
        private System.Windows.Forms.PictureBox eklePictureBox;
        private System.Windows.Forms.Button gonderButton;
        private System.Windows.Forms.TextBox indirimTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox indirimEklePictureBox;
    }
}