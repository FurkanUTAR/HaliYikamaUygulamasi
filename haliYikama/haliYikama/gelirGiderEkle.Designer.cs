namespace haliYikama
{
    partial class gelirGiderEkle
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
            this.tarihDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.turComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kategoriComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.miktarTextBox = new System.Windows.Forms.TextBox();
            this.aciklamaTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ekleButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            // tarihDateTimePicker
            // 
            this.tarihDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tarihDateTimePicker.Location = new System.Drawing.Point(12, 54);
            this.tarihDateTimePicker.Name = "tarihDateTimePicker";
            this.tarihDateTimePicker.Size = new System.Drawing.Size(135, 22);
            this.tarihDateTimePicker.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Tarih";
            // 
            // turComboBox
            // 
            this.turComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.turComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.turComboBox.FormattingEnabled = true;
            this.turComboBox.Location = new System.Drawing.Point(12, 103);
            this.turComboBox.Name = "turComboBox";
            this.turComboBox.Size = new System.Drawing.Size(135, 24);
            this.turComboBox.TabIndex = 39;
            this.turComboBox.SelectedIndexChanged += new System.EventHandler(this.turComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tür";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Kategori";
            // 
            // kategoriComboBox
            // 
            this.kategoriComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.kategoriComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kategoriComboBox.FormattingEnabled = true;
            this.kategoriComboBox.Location = new System.Drawing.Point(12, 149);
            this.kategoriComboBox.Name = "kategoriComboBox";
            this.kategoriComboBox.Size = new System.Drawing.Size(135, 24);
            this.kategoriComboBox.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(154, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "Miktar";
            // 
            // miktarTextBox
            // 
            this.miktarTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.miktarTextBox.Location = new System.Drawing.Point(153, 54);
            this.miktarTextBox.Name = "miktarTextBox";
            this.miktarTextBox.Size = new System.Drawing.Size(135, 22);
            this.miktarTextBox.TabIndex = 45;
            this.miktarTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.miktarTextBox_KeyPress);
            // 
            // aciklamaTextBox
            // 
            this.aciklamaTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.aciklamaTextBox.Location = new System.Drawing.Point(153, 103);
            this.aciklamaTextBox.Multiline = true;
            this.aciklamaTextBox.Name = "aciklamaTextBox";
            this.aciklamaTextBox.Size = new System.Drawing.Size(135, 70);
            this.aciklamaTextBox.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(154, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Açıklama";
            // 
            // ekleButton
            // 
            this.ekleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.ekleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekleButton.Location = new System.Drawing.Point(-7, -7);
            this.ekleButton.Name = "ekleButton";
            this.ekleButton.Size = new System.Drawing.Size(294, 67);
            this.ekleButton.TabIndex = 48;
            this.ekleButton.Text = "Ekle";
            this.ekleButton.UseVisualStyleBackColor = false;
            this.ekleButton.Click += new System.EventHandler(this.ekleButton_Click);
            this.ekleButton.MouseEnter += new System.EventHandler(this.ekleButton_MouseEnter);
            this.ekleButton.MouseLeave += new System.EventHandler(this.ekleButton_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.geriDonPictureBox);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(434, 361);
            this.panel4.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(132, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 25);
            this.label6.TabIndex = 40;
            this.label6.Text = "Gelir-Gider Ekle";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tarihDateTimePicker);
            this.panel1.Controls.Add(this.aciklamaTextBox);
            this.panel1.Controls.Add(this.turComboBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.miktarTextBox);
            this.panel1.Controls.Add(this.kategoriComboBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(64, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 297);
            this.panel1.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ekleButton);
            this.panel2.Location = new System.Drawing.Point(12, 210);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 51);
            this.panel2.TabIndex = 50;
            // 
            // gelirGiderEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gelirGiderEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gelir-Gider Ekle";
            this.Load += new System.EventHandler(this.gelirGiderEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox geriDonPictureBox;
        private System.Windows.Forms.DateTimePicker tarihDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox turComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox kategoriComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox miktarTextBox;
        private System.Windows.Forms.TextBox aciklamaTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ekleButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}