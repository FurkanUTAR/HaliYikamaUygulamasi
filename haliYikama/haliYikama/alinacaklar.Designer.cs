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
            this.alinacakHaliDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.adetComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.metreKareTextBox = new System.Windows.Forms.TextBox();
            this.gonderButton = new System.Windows.Forms.Button();
            this.indirimTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cıkarButton = new System.Windows.Forms.Button();
            this.teslimTarihiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toplamFiyatLabel = new System.Windows.Forms.Label();
            this.adetLabel = new System.Windows.Forms.Label();
            this.indirimEklePictureBox = new System.Windows.Forms.PictureBox();
            this.eklePictureBox = new System.Windows.Forms.PictureBox();
            this.geriDonPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.alinacakHaliDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indirimEklePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eklePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // urunComboBox
            // 
            this.urunComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.urunComboBox.FormattingEnabled = true;
            this.urunComboBox.Location = new System.Drawing.Point(72, 27);
            this.urunComboBox.Name = "urunComboBox";
            this.urunComboBox.Size = new System.Drawing.Size(95, 21);
            this.urunComboBox.TabIndex = 37;
            this.urunComboBox.SelectedIndexChanged += new System.EventHandler(this.urunComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Ürün";
            // 
            // alinacakHaliDataGridView
            // 
            this.alinacakHaliDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.alinacakHaliDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alinacakHaliDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alinacakHaliDataGridView.Location = new System.Drawing.Point(18, 94);
            this.alinacakHaliDataGridView.Name = "alinacakHaliDataGridView";
            this.alinacakHaliDataGridView.Size = new System.Drawing.Size(319, 160);
            this.alinacakHaliDataGridView.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Adet";
            // 
            // adetComboBox
            // 
            this.adetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.adetComboBox.FormattingEnabled = true;
            this.adetComboBox.Location = new System.Drawing.Point(171, 27);
            this.adetComboBox.Name = "adetComboBox";
            this.adetComboBox.Size = new System.Drawing.Size(43, 21);
            this.adetComboBox.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "m²";
            // 
            // metreKareTextBox
            // 
            this.metreKareTextBox.Location = new System.Drawing.Point(218, 28);
            this.metreKareTextBox.Name = "metreKareTextBox";
            this.metreKareTextBox.Size = new System.Drawing.Size(32, 20);
            this.metreKareTextBox.TabIndex = 44;
            // 
            // gonderButton
            // 
            this.gonderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.gonderButton.Location = new System.Drawing.Point(-7, -6);
            this.gonderButton.Name = "gonderButton";
            this.gonderButton.Size = new System.Drawing.Size(100, 47);
            this.gonderButton.TabIndex = 46;
            this.gonderButton.Text = "Gönder";
            this.gonderButton.UseVisualStyleBackColor = false;
            this.gonderButton.Click += new System.EventHandler(this.gonderButton_Click);
            this.gonderButton.MouseEnter += new System.EventHandler(this.gonderButton_MouseEnter);
            this.gonderButton.MouseLeave += new System.EventHandler(this.gonderButton_MouseLeave);
            // 
            // indirimTextBox
            // 
            this.indirimTextBox.Location = new System.Drawing.Point(72, 68);
            this.indirimTextBox.Name = "indirimTextBox";
            this.indirimTextBox.Size = new System.Drawing.Size(95, 20);
            this.indirimTextBox.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "İndirim";
            // 
            // cıkarButton
            // 
            this.cıkarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.cıkarButton.Location = new System.Drawing.Point(-7, -6);
            this.cıkarButton.Name = "cıkarButton";
            this.cıkarButton.Size = new System.Drawing.Size(100, 47);
            this.cıkarButton.TabIndex = 50;
            this.cıkarButton.Text = "Çıkar";
            this.cıkarButton.UseVisualStyleBackColor = false;
            this.cıkarButton.Click += new System.EventHandler(this.cıkarButton_Click);
            this.cıkarButton.MouseEnter += new System.EventHandler(this.cıkarButton_MouseEnter);
            this.cıkarButton.MouseLeave += new System.EventHandler(this.cıkarButton_MouseLeave);
            // 
            // teslimTarihiDateTimePicker
            // 
            this.teslimTarihiDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.teslimTarihiDateTimePicker.Location = new System.Drawing.Point(201, 68);
            this.teslimTarihiDateTimePicker.Name = "teslimTarihiDateTimePicker";
            this.teslimTarihiDateTimePicker.Size = new System.Drawing.Size(81, 20);
            this.teslimTarihiDateTimePicker.TabIndex = 54;
            this.teslimTarihiDateTimePicker.Value = new System.DateTime(2024, 12, 10, 20, 43, 23, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Teslim Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(9, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "|";
            // 
            // toplamFiyatLabel
            // 
            this.toplamFiyatLabel.AutoSize = true;
            this.toplamFiyatLabel.Location = new System.Drawing.Point(80, 271);
            this.toplamFiyatLabel.Name = "toplamFiyatLabel";
            this.toplamFiyatLabel.Size = new System.Drawing.Size(32, 13);
            this.toplamFiyatLabel.TabIndex = 58;
            this.toplamFiyatLabel.Text = " Fiyat";
            // 
            // adetLabel
            // 
            this.adetLabel.AutoSize = true;
            this.adetLabel.Location = new System.Drawing.Point(31, 271);
            this.adetLabel.Name = "adetLabel";
            this.adetLabel.Size = new System.Drawing.Size(29, 13);
            this.adetLabel.TabIndex = 57;
            this.adetLabel.Text = "Adet";
            // 
            // indirimEklePictureBox
            // 
            this.indirimEklePictureBox.Image = global::haliYikama.Properties.Resources.addOrder;
            this.indirimEklePictureBox.Location = new System.Drawing.Point(172, 69);
            this.indirimEklePictureBox.Name = "indirimEklePictureBox";
            this.indirimEklePictureBox.Size = new System.Drawing.Size(23, 19);
            this.indirimEklePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.indirimEklePictureBox.TabIndex = 49;
            this.indirimEklePictureBox.TabStop = false;
            this.indirimEklePictureBox.Click += new System.EventHandler(this.indirimEklePictureBox_Click);
            // 
            // eklePictureBox
            // 
            this.eklePictureBox.Image = global::haliYikama.Properties.Resources.addOrder;
            this.eklePictureBox.Location = new System.Drawing.Point(256, 29);
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
            this.geriDonPictureBox.Size = new System.Drawing.Size(30, 25);
            this.geriDonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.geriDonPictureBox.TabIndex = 36;
            this.geriDonPictureBox.TabStop = false;
            this.geriDonPictureBox.Click += new System.EventHandler(this.geriDonPictureBox_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.geriDonPictureBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 361);
            this.panel1.TabIndex = 60;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.adetLabel);
            this.panel2.Controls.Add(this.teslimTarihiDateTimePicker);
            this.panel2.Controls.Add(this.toplamFiyatLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.alinacakHaliDataGridView);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.urunComboBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.adetComboBox);
            this.panel2.Controls.Add(this.indirimEklePictureBox);
            this.panel2.Controls.Add(this.eklePictureBox);
            this.panel2.Controls.Add(this.indirimTextBox);
            this.panel2.Controls.Add(this.metreKareTextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(40, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 353);
            this.panel2.TabIndex = 61;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gonderButton);
            this.panel4.Location = new System.Drawing.Point(252, 302);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(84, 36);
            this.panel4.TabIndex = 61;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cıkarButton);
            this.panel3.Location = new System.Drawing.Point(252, 260);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(84, 36);
            this.panel3.TabIndex = 60;
            // 
            // alinacaklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "alinacaklar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alınacaklar";
            this.Load += new System.EventHandler(this.alinacaklar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alinacakHaliDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indirimEklePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eklePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox geriDonPictureBox;
        private System.Windows.Forms.ComboBox urunComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView alinacakHaliDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox adetComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox metreKareTextBox;
        private System.Windows.Forms.PictureBox eklePictureBox;
        private System.Windows.Forms.Button gonderButton;
        private System.Windows.Forms.TextBox indirimTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox indirimEklePictureBox;
        private System.Windows.Forms.Button cıkarButton;
        private System.Windows.Forms.DateTimePicker teslimTarihiDateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label toplamFiyatLabel;
        private System.Windows.Forms.Label adetLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}