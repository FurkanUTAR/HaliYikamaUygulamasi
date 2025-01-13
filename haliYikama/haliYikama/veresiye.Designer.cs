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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.odemeYontemiComboBox = new System.Windows.Forms.ComboBox();
            this.alinanTutarTextBox = new System.Windows.Forms.TextBox();
            this.gonderButton = new System.Windows.Forms.Button();
            this.veresiyeDataGridView = new System.Windows.Forms.DataGridView();
            this.geriDonPictureBox = new System.Windows.Forms.PictureBox();
            this.veresiyeFiyatLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.veresiyeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Ödeme Yöntemi?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Alınan Tutar?";
            // 
            // odemeYontemiComboBox
            // 
            this.odemeYontemiComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.odemeYontemiComboBox.FormattingEnabled = true;
            this.odemeYontemiComboBox.Location = new System.Drawing.Point(189, 27);
            this.odemeYontemiComboBox.Name = "odemeYontemiComboBox";
            this.odemeYontemiComboBox.Size = new System.Drawing.Size(102, 21);
            this.odemeYontemiComboBox.TabIndex = 57;
            // 
            // alinanTutarTextBox
            // 
            this.alinanTutarTextBox.Location = new System.Drawing.Point(81, 27);
            this.alinanTutarTextBox.Multiline = true;
            this.alinanTutarTextBox.Name = "alinanTutarTextBox";
            this.alinanTutarTextBox.Size = new System.Drawing.Size(102, 21);
            this.alinanTutarTextBox.TabIndex = 56;
            // 
            // gonderButton
            // 
            this.gonderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.gonderButton.Location = new System.Drawing.Point(-7, -6);
            this.gonderButton.Name = "gonderButton";
            this.gonderButton.Size = new System.Drawing.Size(100, 47);
            this.gonderButton.TabIndex = 55;
            this.gonderButton.Text = "Gönder";
            this.gonderButton.UseVisualStyleBackColor = false;
            this.gonderButton.Click += new System.EventHandler(this.gonderButton_Click);
            this.gonderButton.MouseEnter += new System.EventHandler(this.gonderButton_MouseEnter);
            this.gonderButton.MouseLeave += new System.EventHandler(this.gonderButton_MouseLeave);
            // 
            // veresiyeDataGridView
            // 
            this.veresiyeDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.veresiyeDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.veresiyeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.veresiyeDataGridView.Location = new System.Drawing.Point(18, 58);
            this.veresiyeDataGridView.Name = "veresiyeDataGridView";
            this.veresiyeDataGridView.Size = new System.Drawing.Size(319, 190);
            this.veresiyeDataGridView.TabIndex = 54;
            // 
            // geriDonPictureBox
            // 
            this.geriDonPictureBox.Image = global::haliYikama.Properties.Resources.left;
            this.geriDonPictureBox.Location = new System.Drawing.Point(1, 1);
            this.geriDonPictureBox.Name = "geriDonPictureBox";
            this.geriDonPictureBox.Size = new System.Drawing.Size(30, 25);
            this.geriDonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.geriDonPictureBox.TabIndex = 53;
            this.geriDonPictureBox.TabStop = false;
            this.geriDonPictureBox.Click += new System.EventHandler(this.geriDonPictureBox_Click);
            // 
            // veresiyeFiyatLabel
            // 
            this.veresiyeFiyatLabel.AutoSize = true;
            this.veresiyeFiyatLabel.Location = new System.Drawing.Point(88, 271);
            this.veresiyeFiyatLabel.Name = "veresiyeFiyatLabel";
            this.veresiyeFiyatLabel.Size = new System.Drawing.Size(0, 13);
            this.veresiyeFiyatLabel.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Toplam Fiyat :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.geriDonPictureBox);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 361);
            this.panel1.TabIndex = 62;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.veresiyeDataGridView);
            this.panel2.Controls.Add(this.veresiyeFiyatLabel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.odemeYontemiComboBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.alinanTutarTextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(40, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 315);
            this.panel2.TabIndex = 61;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gonderButton);
            this.panel4.Location = new System.Drawing.Point(253, 260);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(84, 36);
            this.panel4.TabIndex = 61;
            // 
            // veresiye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "veresiye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veresiye";
            this.Load += new System.EventHandler(this.veresiye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.veresiyeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox odemeYontemiComboBox;
        private System.Windows.Forms.TextBox alinanTutarTextBox;
        private System.Windows.Forms.Button gonderButton;
        private System.Windows.Forms.DataGridView veresiyeDataGridView;
        private System.Windows.Forms.PictureBox geriDonPictureBox;
        private System.Windows.Forms.Label veresiyeFiyatLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
    }
}