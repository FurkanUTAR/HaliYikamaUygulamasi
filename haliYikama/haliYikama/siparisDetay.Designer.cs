namespace haliYikama
{
    partial class siparisDetay
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
            this.haliBilgiDataGridView = new System.Windows.Forms.DataGridView();
            this.haliEkleButton = new System.Windows.Forms.Button();
            this.teslimatCekButton = new System.Windows.Forms.Button();
            this.teslimatNotuTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.haliBilgiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // geriDonPictureBox
            // 
            this.geriDonPictureBox.Image = global::haliYikama.Properties.Resources.left;
            this.geriDonPictureBox.Location = new System.Drawing.Point(1, 1);
            this.geriDonPictureBox.Name = "geriDonPictureBox";
            this.geriDonPictureBox.Size = new System.Drawing.Size(23, 19);
            this.geriDonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.geriDonPictureBox.TabIndex = 40;
            this.geriDonPictureBox.TabStop = false;
            this.geriDonPictureBox.Click += new System.EventHandler(this.geriDonPictureBox_Click);
            // 
            // haliBilgiDataGridView
            // 
            this.haliBilgiDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.haliBilgiDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.haliBilgiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.haliBilgiDataGridView.Location = new System.Drawing.Point(1, 36);
            this.haliBilgiDataGridView.Name = "haliBilgiDataGridView";
            this.haliBilgiDataGridView.Size = new System.Drawing.Size(232, 263);
            this.haliBilgiDataGridView.TabIndex = 41;
            // 
            // haliEkleButton
            // 
            this.haliEkleButton.Location = new System.Drawing.Point(12, 305);
            this.haliEkleButton.Name = "haliEkleButton";
            this.haliEkleButton.Size = new System.Drawing.Size(210, 37);
            this.haliEkleButton.TabIndex = 42;
            this.haliEkleButton.Text = "Halı Ekle";
            this.haliEkleButton.UseVisualStyleBackColor = true;
            // 
            // teslimatCekButton
            // 
            this.teslimatCekButton.Location = new System.Drawing.Point(122, 423);
            this.teslimatCekButton.Name = "teslimatCekButton";
            this.teslimatCekButton.Size = new System.Drawing.Size(100, 41);
            this.teslimatCekButton.TabIndex = 43;
            this.teslimatCekButton.Text = "Teslimata Çek";
            this.teslimatCekButton.UseVisualStyleBackColor = true;
            this.teslimatCekButton.Click += new System.EventHandler(this.teslimatCekButton_Click);
            // 
            // teslimatNotuTextBox
            // 
            this.teslimatNotuTextBox.Location = new System.Drawing.Point(12, 361);
            this.teslimatNotuTextBox.Multiline = true;
            this.teslimatNotuTextBox.Name = "teslimatNotuTextBox";
            this.teslimatNotuTextBox.Size = new System.Drawing.Size(210, 56);
            this.teslimatNotuTextBox.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Teslimat Notu";
            // 
            // siparisDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 476);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teslimatNotuTextBox);
            this.Controls.Add(this.teslimatCekButton);
            this.Controls.Add(this.haliEkleButton);
            this.Controls.Add(this.haliBilgiDataGridView);
            this.Controls.Add(this.geriDonPictureBox);
            this.Name = "siparisDetay";
            this.Text = "Sipariş Detay";
            this.Load += new System.EventHandler(this.siparisDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.haliBilgiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox geriDonPictureBox;
        private System.Windows.Forms.DataGridView haliBilgiDataGridView;
        private System.Windows.Forms.Button haliEkleButton;
        private System.Windows.Forms.Button teslimatCekButton;
        private System.Windows.Forms.TextBox teslimatNotuTextBox;
        private System.Windows.Forms.Label label1;
    }
}