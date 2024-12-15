namespace haliYikama
{
    partial class anaSayfa
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.anaSayfaTabPage = new System.Windows.Forms.TabPage();
            this.siparislerButton = new System.Windows.Forms.Button();
            this.gelirGiderButton = new System.Windows.Forms.Button();
            this.aramaGecmisiButton = new System.Windows.Forms.Button();
            this.ozetlerButton = new System.Windows.Forms.Button();
            this.musterilerButton = new System.Windows.Forms.Button();
            this.yoneticiTabPage = new System.Windows.Forms.TabPage();
            this.mesajlarButton = new System.Windows.Forms.Button();
            this.fiyatButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.anaSayfaTabPage.SuspendLayout();
            this.yoneticiTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.anaSayfaTabPage);
            this.TabControl.Controls.Add(this.yoneticiTabPage);
            this.TabControl.Location = new System.Drawing.Point(0, -1);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(236, 479);
            this.TabControl.TabIndex = 1;
            // 
            // anaSayfaTabPage
            // 
            this.anaSayfaTabPage.Controls.Add(this.button1);
            this.anaSayfaTabPage.Controls.Add(this.siparislerButton);
            this.anaSayfaTabPage.Controls.Add(this.gelirGiderButton);
            this.anaSayfaTabPage.Controls.Add(this.aramaGecmisiButton);
            this.anaSayfaTabPage.Controls.Add(this.ozetlerButton);
            this.anaSayfaTabPage.Controls.Add(this.musterilerButton);
            this.anaSayfaTabPage.Location = new System.Drawing.Point(4, 22);
            this.anaSayfaTabPage.Name = "anaSayfaTabPage";
            this.anaSayfaTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.anaSayfaTabPage.Size = new System.Drawing.Size(228, 453);
            this.anaSayfaTabPage.TabIndex = 0;
            this.anaSayfaTabPage.Text = "Ana Sayfa";
            this.anaSayfaTabPage.UseVisualStyleBackColor = true;
            // 
            // siparislerButton
            // 
            this.siparislerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparislerButton.Location = new System.Drawing.Point(8, 98);
            this.siparislerButton.Name = "siparislerButton";
            this.siparislerButton.Size = new System.Drawing.Size(100, 65);
            this.siparislerButton.TabIndex = 2;
            this.siparislerButton.Text = "Siparişler";
            this.siparislerButton.UseVisualStyleBackColor = true;
            this.siparislerButton.Click += new System.EventHandler(this.siparislerButton_Click);
            // 
            // gelirGiderButton
            // 
            this.gelirGiderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gelirGiderButton.Location = new System.Drawing.Point(8, 240);
            this.gelirGiderButton.Name = "gelirGiderButton";
            this.gelirGiderButton.Size = new System.Drawing.Size(100, 65);
            this.gelirGiderButton.TabIndex = 7;
            this.gelirGiderButton.Text = "Gelir/Gider\r\nTakip";
            this.gelirGiderButton.UseVisualStyleBackColor = true;
            this.gelirGiderButton.Click += new System.EventHandler(this.gelirGiderButton_Click);
            // 
            // aramaGecmisiButton
            // 
            this.aramaGecmisiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aramaGecmisiButton.Location = new System.Drawing.Point(8, 169);
            this.aramaGecmisiButton.Name = "aramaGecmisiButton";
            this.aramaGecmisiButton.Size = new System.Drawing.Size(100, 65);
            this.aramaGecmisiButton.TabIndex = 6;
            this.aramaGecmisiButton.Text = "Arama\r\nGeçmişi";
            this.aramaGecmisiButton.UseVisualStyleBackColor = true;
            this.aramaGecmisiButton.Click += new System.EventHandler(this.aramaGecmisiButton_Click);
            // 
            // ozetlerButton
            // 
            this.ozetlerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ozetlerButton.Location = new System.Drawing.Point(118, 240);
            this.ozetlerButton.Name = "ozetlerButton";
            this.ozetlerButton.Size = new System.Drawing.Size(100, 65);
            this.ozetlerButton.TabIndex = 8;
            this.ozetlerButton.Text = "Özetler";
            this.ozetlerButton.UseVisualStyleBackColor = true;
            this.ozetlerButton.Click += new System.EventHandler(this.ozetlerButton_Click);
            // 
            // musterilerButton
            // 
            this.musterilerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musterilerButton.Location = new System.Drawing.Point(118, 98);
            this.musterilerButton.Name = "musterilerButton";
            this.musterilerButton.Size = new System.Drawing.Size(100, 65);
            this.musterilerButton.TabIndex = 5;
            this.musterilerButton.Text = "Müşteriler";
            this.musterilerButton.UseVisualStyleBackColor = true;
            this.musterilerButton.Click += new System.EventHandler(this.musterilerButton_Click);
            // 
            // yoneticiTabPage
            // 
            this.yoneticiTabPage.Controls.Add(this.mesajlarButton);
            this.yoneticiTabPage.Controls.Add(this.fiyatButton);
            this.yoneticiTabPage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.yoneticiTabPage.Location = new System.Drawing.Point(4, 22);
            this.yoneticiTabPage.Name = "yoneticiTabPage";
            this.yoneticiTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.yoneticiTabPage.Size = new System.Drawing.Size(228, 453);
            this.yoneticiTabPage.TabIndex = 1;
            this.yoneticiTabPage.Text = "Ayarlar";
            this.yoneticiTabPage.UseVisualStyleBackColor = true;
            // 
            // mesajlarButton
            // 
            this.mesajlarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mesajlarButton.Location = new System.Drawing.Point(9, 78);
            this.mesajlarButton.Name = "mesajlarButton";
            this.mesajlarButton.Size = new System.Drawing.Size(209, 65);
            this.mesajlarButton.TabIndex = 1;
            this.mesajlarButton.Text = "Mesajlar";
            this.mesajlarButton.UseVisualStyleBackColor = true;
            this.mesajlarButton.Click += new System.EventHandler(this.mesajlarButton_Click);
            // 
            // fiyatButton
            // 
            this.fiyatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fiyatButton.Location = new System.Drawing.Point(9, 7);
            this.fiyatButton.Name = "fiyatButton";
            this.fiyatButton.Size = new System.Drawing.Size(209, 65);
            this.fiyatButton.TabIndex = 0;
            this.fiyatButton.Text = "Fiyat";
            this.fiyatButton.UseVisualStyleBackColor = true;
            this.fiyatButton.Click += new System.EventHandler(this.fiyatButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(118, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 65);
            this.button1.TabIndex = 9;
            this.button1.Text = "İşlemdekiler";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // anaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 476);
            this.Controls.Add(this.TabControl);
            this.Name = "anaSayfa";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.anaSayfa_Load);
            this.TabControl.ResumeLayout(false);
            this.anaSayfaTabPage.ResumeLayout(false);
            this.yoneticiTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage anaSayfaTabPage;
        private System.Windows.Forms.TabPage yoneticiTabPage;
        private System.Windows.Forms.Button ozetlerButton;
        private System.Windows.Forms.Button musterilerButton;
        private System.Windows.Forms.Button siparislerButton;
        private System.Windows.Forms.Button gelirGiderButton;
        private System.Windows.Forms.Button aramaGecmisiButton;
        private System.Windows.Forms.Button fiyatButton;
        private System.Windows.Forms.Button mesajlarButton;
        private System.Windows.Forms.Button button1;
    }
}