namespace haliYikama
{
    partial class gelirGiderTakip
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
            this.gelirGiderEkleButton = new System.Windows.Forms.Button();
            this.gelirGiderTablosuButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // geriDonPictureBox
            // 
            this.geriDonPictureBox.Image = global::haliYikama.Properties.Resources.left;
            this.geriDonPictureBox.Location = new System.Drawing.Point(1, 1);
            this.geriDonPictureBox.Name = "geriDonPictureBox";
            this.geriDonPictureBox.Size = new System.Drawing.Size(30, 25);
            this.geriDonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.geriDonPictureBox.TabIndex = 35;
            this.geriDonPictureBox.TabStop = false;
            this.geriDonPictureBox.Click += new System.EventHandler(this.geriDonPictureBox_Click);
            // 
            // gelirGiderEkleButton
            // 
            this.gelirGiderEkleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.gelirGiderEkleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gelirGiderEkleButton.Location = new System.Drawing.Point(-5, -5);
            this.gelirGiderEkleButton.Name = "gelirGiderEkleButton";
            this.gelirGiderEkleButton.Size = new System.Drawing.Size(220, 133);
            this.gelirGiderEkleButton.TabIndex = 36;
            this.gelirGiderEkleButton.Text = "Gelir-Gider Ekle";
            this.gelirGiderEkleButton.UseVisualStyleBackColor = false;
            this.gelirGiderEkleButton.Click += new System.EventHandler(this.gelirGiderEkleButton_Click);
            this.gelirGiderEkleButton.MouseEnter += new System.EventHandler(this.gelirGiderEkleButton_MouseEnter);
            this.gelirGiderEkleButton.MouseLeave += new System.EventHandler(this.gelirGiderEkleButton_MouseLeave);
            // 
            // gelirGiderTablosuButton
            // 
            this.gelirGiderTablosuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.gelirGiderTablosuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gelirGiderTablosuButton.Location = new System.Drawing.Point(-5, -5);
            this.gelirGiderTablosuButton.Name = "gelirGiderTablosuButton";
            this.gelirGiderTablosuButton.Size = new System.Drawing.Size(220, 133);
            this.gelirGiderTablosuButton.TabIndex = 38;
            this.gelirGiderTablosuButton.Text = "Gelir-Gider Tablosu";
            this.gelirGiderTablosuButton.UseVisualStyleBackColor = false;
            this.gelirGiderTablosuButton.Click += new System.EventHandler(this.gelirGiderTablosuButton_Click);
            this.gelirGiderTablosuButton.MouseEnter += new System.EventHandler(this.gelirGiderTablosuButton_MouseEnter);
            this.gelirGiderTablosuButton.MouseLeave += new System.EventHandler(this.gelirGiderTablosuButton_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(64, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 277);
            this.panel1.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gelirGiderEkleButton);
            this.panel2.Location = new System.Drawing.Point(50, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 124);
            this.panel2.TabIndex = 40;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gelirGiderTablosuButton);
            this.panel3.Location = new System.Drawing.Point(50, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 124);
            this.panel3.TabIndex = 41;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.geriDonPictureBox);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(434, 361);
            this.panel4.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(132, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Gelir-Gider Takip";
            // 
            // gelirGiderTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gelirGiderTakip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gelir-Gider Takip";
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox geriDonPictureBox;
        private System.Windows.Forms.Button gelirGiderEkleButton;
        private System.Windows.Forms.Button gelirGiderTablosuButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
    }
}