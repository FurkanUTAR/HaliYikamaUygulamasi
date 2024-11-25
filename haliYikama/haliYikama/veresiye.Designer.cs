namespace haliYikama
{
    partial class veresiye
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gonderButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Ödeme Şekli?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Alınan Tutar?";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(120, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(102, 21);
            this.comboBox1.TabIndex = 56;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 42);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 21);
            this.textBox1.TabIndex = 55;
            // 
            // gonderButton
            // 
            this.gonderButton.Location = new System.Drawing.Point(1, 415);
            this.gonderButton.Name = "gonderButton";
            this.gonderButton.Size = new System.Drawing.Size(84, 36);
            this.gonderButton.TabIndex = 54;
            this.gonderButton.Text = "Gönder";
            this.gonderButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(232, 328);
            this.dataGridView1.TabIndex = 53;
            // 
            // veresiye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 476);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gonderButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.geriDonPictureBox);
            this.Name = "veresiye";
            this.Text = "Veresiye";
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox geriDonPictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button gonderButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}