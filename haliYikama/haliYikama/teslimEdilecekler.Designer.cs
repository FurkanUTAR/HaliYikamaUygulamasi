namespace haliYikama
{
    partial class teslimEdilecekler
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
            this.gonderButton = new System.Windows.Forms.Button();
            this.haliDataGridView = new System.Windows.Forms.DataGridView();
            this.alinanTutarTextBox = new System.Windows.Forms.TextBox();
            this.odemeSekliComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.haliDataGridView)).BeginInit();
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
            // gonderButton
            // 
            this.gonderButton.Location = new System.Drawing.Point(146, 428);
            this.gonderButton.Name = "gonderButton";
            this.gonderButton.Size = new System.Drawing.Size(84, 36);
            this.gonderButton.TabIndex = 48;
            this.gonderButton.Text = "Gönder";
            this.gonderButton.UseVisualStyleBackColor = true;
            this.gonderButton.Click += new System.EventHandler(this.gonderButton_Click);
            // 
            // haliDataGridView
            // 
            this.haliDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.haliDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.haliDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.haliDataGridView.Location = new System.Drawing.Point(1, 82);
            this.haliDataGridView.Name = "haliDataGridView";
            this.haliDataGridView.Size = new System.Drawing.Size(232, 297);
            this.haliDataGridView.TabIndex = 47;
            // 
            // alinanTutarTextBox
            // 
            this.alinanTutarTextBox.Location = new System.Drawing.Point(12, 55);
            this.alinanTutarTextBox.Multiline = true;
            this.alinanTutarTextBox.Name = "alinanTutarTextBox";
            this.alinanTutarTextBox.Size = new System.Drawing.Size(102, 21);
            this.alinanTutarTextBox.TabIndex = 49;
            // 
            // odemeSekliComboBox
            // 
            this.odemeSekliComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.odemeSekliComboBox.FormattingEnabled = true;
            this.odemeSekliComboBox.Location = new System.Drawing.Point(120, 55);
            this.odemeSekliComboBox.Name = "odemeSekliComboBox";
            this.odemeSekliComboBox.Size = new System.Drawing.Size(102, 21);
            this.odemeSekliComboBox.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Alınan Tutar?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Ödeme Şekli?";
            // 
            // teslimEdilecekler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 476);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odemeSekliComboBox);
            this.Controls.Add(this.alinanTutarTextBox);
            this.Controls.Add(this.gonderButton);
            this.Controls.Add(this.haliDataGridView);
            this.Controls.Add(this.geriDonPictureBox);
            this.Name = "teslimEdilecekler";
            this.Text = "Teslim Edilecekler";
            this.Load += new System.EventHandler(this.teslimEdilecekler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.haliDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox geriDonPictureBox;
        private System.Windows.Forms.Button gonderButton;
        private System.Windows.Forms.DataGridView haliDataGridView;
        private System.Windows.Forms.TextBox alinanTutarTextBox;
        private System.Windows.Forms.ComboBox odemeSekliComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}