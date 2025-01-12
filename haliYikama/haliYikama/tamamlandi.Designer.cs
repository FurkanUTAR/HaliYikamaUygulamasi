namespace haliYikama
{
    partial class tamamlandi
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
            this.tamamlandiDataGridView = new System.Windows.Forms.DataGridView();
            this.araButton = new System.Windows.Forms.Button();
            this.araTextBox = new System.Windows.Forms.TextBox();
            this.siparisNoRadioButton = new System.Windows.Forms.RadioButton();
            this.telNoRadioButton = new System.Windows.Forms.RadioButton();
            this.musteriAdiRadioButton = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.adresRadiobutton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamamlandiDataGridView)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // geriDonPictureBox
            // 
            this.geriDonPictureBox.Image = global::haliYikama.Properties.Resources.left;
            this.geriDonPictureBox.Location = new System.Drawing.Point(1, 1);
            this.geriDonPictureBox.Name = "geriDonPictureBox";
            this.geriDonPictureBox.Size = new System.Drawing.Size(30, 25);
            this.geriDonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.geriDonPictureBox.TabIndex = 37;
            this.geriDonPictureBox.TabStop = false;
            this.geriDonPictureBox.Click += new System.EventHandler(this.geriDonPictureBox_Click);
            // 
            // tamamlandiDataGridView
            // 
            this.tamamlandiDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.tamamlandiDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tamamlandiDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.tamamlandiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tamamlandiDataGridView.Location = new System.Drawing.Point(12, 8);
            this.tamamlandiDataGridView.Name = "tamamlandiDataGridView";
            this.tamamlandiDataGridView.Size = new System.Drawing.Size(958, 434);
            this.tamamlandiDataGridView.TabIndex = 38;
            // 
            // araButton
            // 
            this.araButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.araButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.araButton.Location = new System.Drawing.Point(-4, -6);
            this.araButton.Name = "araButton";
            this.araButton.Size = new System.Drawing.Size(83, 45);
            this.araButton.TabIndex = 47;
            this.araButton.Text = "Ara";
            this.araButton.UseVisualStyleBackColor = false;
            this.araButton.Click += new System.EventHandler(this.araButton_Click);
            this.araButton.MouseEnter += new System.EventHandler(this.araButton_MouseEnter);
            this.araButton.MouseLeave += new System.EventHandler(this.araButton_MouseLeave);
            // 
            // araTextBox
            // 
            this.araTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.araTextBox.Location = new System.Drawing.Point(324, 38);
            this.araTextBox.Multiline = true;
            this.araTextBox.Name = "araTextBox";
            this.araTextBox.Size = new System.Drawing.Size(230, 32);
            this.araTextBox.TabIndex = 46;
            this.araTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.araTextBox_KeyPress);
            // 
            // siparisNoRadioButton
            // 
            this.siparisNoRadioButton.AutoSize = true;
            this.siparisNoRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparisNoRadioButton.Location = new System.Drawing.Point(560, 15);
            this.siparisNoRadioButton.Name = "siparisNoRadioButton";
            this.siparisNoRadioButton.Size = new System.Drawing.Size(88, 20);
            this.siparisNoRadioButton.TabIndex = 45;
            this.siparisNoRadioButton.Text = "Sipariş No";
            this.siparisNoRadioButton.UseVisualStyleBackColor = true;
            this.siparisNoRadioButton.CheckedChanged += new System.EventHandler(this.siparisNoRadioButton_CheckedChanged);
            // 
            // telNoRadioButton
            // 
            this.telNoRadioButton.AutoSize = true;
            this.telNoRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telNoRadioButton.Location = new System.Drawing.Point(488, 15);
            this.telNoRadioButton.Name = "telNoRadioButton";
            this.telNoRadioButton.Size = new System.Drawing.Size(66, 20);
            this.telNoRadioButton.TabIndex = 44;
            this.telNoRadioButton.Text = "Tel No";
            this.telNoRadioButton.UseVisualStyleBackColor = true;
            this.telNoRadioButton.CheckedChanged += new System.EventHandler(this.telNoRadioButton_CheckedChanged);
            // 
            // musteriAdiRadioButton
            // 
            this.musteriAdiRadioButton.AutoSize = true;
            this.musteriAdiRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriAdiRadioButton.Location = new System.Drawing.Point(324, 15);
            this.musteriAdiRadioButton.Name = "musteriAdiRadioButton";
            this.musteriAdiRadioButton.Size = new System.Drawing.Size(91, 20);
            this.musteriAdiRadioButton.TabIndex = 43;
            this.musteriAdiRadioButton.Text = "Müşteri Adı";
            this.musteriAdiRadioButton.UseVisualStyleBackColor = true;
            this.musteriAdiRadioButton.CheckedChanged += new System.EventHandler(this.musteriAdiRadioButton_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.geriDonPictureBox);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(982, 47);
            this.panel5.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label5.Location = new System.Drawing.Point(334, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(291, 31);
            this.label5.TabIndex = 38;
            this.label5.Text = "Tamamlanan Siparişler";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.tamamlandiDataGridView);
            this.panel2.Location = new System.Drawing.Point(0, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 450);
            this.panel2.TabIndex = 49;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.adresRadiobutton);
            this.panel1.Controls.Add(this.araTextBox);
            this.panel1.Controls.Add(this.siparisNoRadioButton);
            this.panel1.Controls.Add(this.telNoRadioButton);
            this.panel1.Controls.Add(this.musteriAdiRadioButton);
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 88);
            this.panel1.TabIndex = 48;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.araButton);
            this.panel3.Location = new System.Drawing.Point(567, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(73, 33);
            this.panel3.TabIndex = 38;
            // 
            // adresRadiobutton
            // 
            this.adresRadiobutton.AutoSize = true;
            this.adresRadiobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adresRadiobutton.Location = new System.Drawing.Point(421, 15);
            this.adresRadiobutton.Name = "adresRadiobutton";
            this.adresRadiobutton.Size = new System.Drawing.Size(61, 20);
            this.adresRadiobutton.TabIndex = 37;
            this.adresRadiobutton.Text = "Adres";
            this.adresRadiobutton.UseVisualStyleBackColor = true;
            this.adresRadiobutton.CheckedChanged += new System.EventHandler(this.adresRadiobutton_CheckedChanged);
            // 
            // tamamlandi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 584);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "tamamlandi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.tamamlandi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamamlandiDataGridView)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox geriDonPictureBox;
        private System.Windows.Forms.DataGridView tamamlandiDataGridView;
        private System.Windows.Forms.Button araButton;
        private System.Windows.Forms.TextBox araTextBox;
        private System.Windows.Forms.RadioButton siparisNoRadioButton;
        private System.Windows.Forms.RadioButton telNoRadioButton;
        private System.Windows.Forms.RadioButton musteriAdiRadioButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton adresRadiobutton;
    }
}