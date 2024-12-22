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
            ((System.ComponentModel.ISupportInitialize)(this.veresiyeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Ödeme Yöntemi?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Alınan Tutar?";
            // 
            // odemeYontemiComboBox
            // 
            this.odemeYontemiComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.odemeYontemiComboBox.FormattingEnabled = true;
            this.odemeYontemiComboBox.Location = new System.Drawing.Point(120, 55);
            this.odemeYontemiComboBox.Name = "odemeYontemiComboBox";
            this.odemeYontemiComboBox.Size = new System.Drawing.Size(102, 21);
            this.odemeYontemiComboBox.TabIndex = 57;
            // 
            // alinanTutarTextBox
            // 
            this.alinanTutarTextBox.Location = new System.Drawing.Point(12, 55);
            this.alinanTutarTextBox.Multiline = true;
            this.alinanTutarTextBox.Name = "alinanTutarTextBox";
            this.alinanTutarTextBox.Size = new System.Drawing.Size(102, 21);
            this.alinanTutarTextBox.TabIndex = 56;
            // 
            // gonderButton
            // 
            this.gonderButton.Location = new System.Drawing.Point(146, 428);
            this.gonderButton.Name = "gonderButton";
            this.gonderButton.Size = new System.Drawing.Size(84, 36);
            this.gonderButton.TabIndex = 55;
            this.gonderButton.Text = "Gönder";
            this.gonderButton.UseVisualStyleBackColor = true;
            this.gonderButton.Click += new System.EventHandler(this.gonderButton_Click);
            // 
            // veresiyeDataGridView
            // 
            this.veresiyeDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.veresiyeDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.veresiyeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.veresiyeDataGridView.Location = new System.Drawing.Point(1, 82);
            this.veresiyeDataGridView.Name = "veresiyeDataGridView";
            this.veresiyeDataGridView.Size = new System.Drawing.Size(232, 297);
            this.veresiyeDataGridView.TabIndex = 54;
            // 
            // geriDonPictureBox
            // 
            this.geriDonPictureBox.Image = global::haliYikama.Properties.Resources.left;
            this.geriDonPictureBox.Location = new System.Drawing.Point(1, 1);
            this.geriDonPictureBox.Name = "geriDonPictureBox";
            this.geriDonPictureBox.Size = new System.Drawing.Size(23, 19);
            this.geriDonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.geriDonPictureBox.TabIndex = 53;
            this.geriDonPictureBox.TabStop = false;
            this.geriDonPictureBox.Click += new System.EventHandler(this.geriDonPictureBox_Click);
            // 
            // veresiyeFiyatLabel
            // 
            this.veresiyeFiyatLabel.AutoSize = true;
            this.veresiyeFiyatLabel.Location = new System.Drawing.Point(71, 382);
            this.veresiyeFiyatLabel.Name = "veresiyeFiyatLabel";
            this.veresiyeFiyatLabel.Size = new System.Drawing.Size(0, 13);
            this.veresiyeFiyatLabel.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Toplam Fiyat :";
            // 
            // veresiye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 476);
            this.Controls.Add(this.veresiyeFiyatLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odemeYontemiComboBox);
            this.Controls.Add(this.alinanTutarTextBox);
            this.Controls.Add(this.gonderButton);
            this.Controls.Add(this.veresiyeDataGridView);
            this.Controls.Add(this.geriDonPictureBox);
            this.Name = "veresiye";
            this.Text = "Veresiye";
            this.Load += new System.EventHandler(this.veresiye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.veresiyeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}