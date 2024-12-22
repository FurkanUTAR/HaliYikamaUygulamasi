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
            this.components = new System.ComponentModel.Container();
            this.haliBilgiDataGridView = new System.Windows.Forms.DataGridView();
            this.haliEkleButton = new System.Windows.Forms.Button();
            this.teslimatCekButton = new System.Windows.Forms.Button();
            this.teslimatNotuTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.yenilePictureBox = new System.Windows.Forms.PictureBox();
            this.geriDonPictureBox = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toplamFiyatLabel = new System.Windows.Forms.Label();
            this.adetLabel = new System.Windows.Forms.Label();
            this.haliCikarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.haliBilgiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yenilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // haliBilgiDataGridView
            // 
            this.haliBilgiDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.haliBilgiDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.haliBilgiDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.haliBilgiDataGridView.Location = new System.Drawing.Point(1, 26);
            this.haliBilgiDataGridView.Name = "haliBilgiDataGridView";
            this.haliBilgiDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.haliBilgiDataGridView.Size = new System.Drawing.Size(232, 251);
            this.haliBilgiDataGridView.TabIndex = 41;
            // 
            // haliEkleButton
            // 
            this.haliEkleButton.Location = new System.Drawing.Point(12, 305);
            this.haliEkleButton.Name = "haliEkleButton";
            this.haliEkleButton.Size = new System.Drawing.Size(105, 37);
            this.haliEkleButton.TabIndex = 42;
            this.haliEkleButton.Text = "Halı Ekle";
            this.haliEkleButton.UseVisualStyleBackColor = true;
            this.haliEkleButton.Click += new System.EventHandler(this.haliEkleButton_Click);
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // yenilePictureBox
            // 
            this.yenilePictureBox.Image = global::haliYikama.Properties.Resources.refresh1;
            this.yenilePictureBox.Location = new System.Drawing.Point(211, 1);
            this.yenilePictureBox.Name = "yenilePictureBox";
            this.yenilePictureBox.Size = new System.Drawing.Size(20, 20);
            this.yenilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yenilePictureBox.TabIndex = 46;
            this.yenilePictureBox.TabStop = false;
            this.yenilePictureBox.Click += new System.EventHandler(this.yenilePictureBox_Click);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(9, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "|";
            // 
            // toplamFiyatLabel
            // 
            this.toplamFiyatLabel.AutoSize = true;
            this.toplamFiyatLabel.Location = new System.Drawing.Point(55, 286);
            this.toplamFiyatLabel.Name = "toplamFiyatLabel";
            this.toplamFiyatLabel.Size = new System.Drawing.Size(32, 13);
            this.toplamFiyatLabel.TabIndex = 55;
            this.toplamFiyatLabel.Text = " Fiyat";
            // 
            // adetLabel
            // 
            this.adetLabel.AutoSize = true;
            this.adetLabel.Location = new System.Drawing.Point(11, 286);
            this.adetLabel.Name = "adetLabel";
            this.adetLabel.Size = new System.Drawing.Size(29, 13);
            this.adetLabel.TabIndex = 54;
            this.adetLabel.Text = "Adet";
            // 
            // haliCikarButton
            // 
            this.haliCikarButton.Location = new System.Drawing.Point(117, 305);
            this.haliCikarButton.Name = "haliCikarButton";
            this.haliCikarButton.Size = new System.Drawing.Size(105, 37);
            this.haliCikarButton.TabIndex = 57;
            this.haliCikarButton.Text = "Halı Çıkar";
            this.haliCikarButton.UseVisualStyleBackColor = true;
            this.haliCikarButton.Click += new System.EventHandler(this.haliCikarButton_Click);
            // 
            // siparisDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 476);
            this.Controls.Add(this.haliCikarButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.toplamFiyatLabel);
            this.Controls.Add(this.adetLabel);
            this.Controls.Add(this.yenilePictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teslimatNotuTextBox);
            this.Controls.Add(this.teslimatCekButton);
            this.Controls.Add(this.haliEkleButton);
            this.Controls.Add(this.haliBilgiDataGridView);
            this.Controls.Add(this.geriDonPictureBox);
            this.Name = "siparisDetay";
            this.Text = "Sipariş Detay";
            this.Load += new System.EventHandler(this.siparisDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.haliBilgiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yenilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).EndInit();
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox yenilePictureBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label toplamFiyatLabel;
        private System.Windows.Forms.Label adetLabel;
        private System.Windows.Forms.Button haliCikarButton;
    }
}