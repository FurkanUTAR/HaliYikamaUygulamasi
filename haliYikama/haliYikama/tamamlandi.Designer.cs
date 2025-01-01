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
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamamlandiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // geriDonPictureBox
            // 
            this.geriDonPictureBox.Image = global::haliYikama.Properties.Resources.left;
            this.geriDonPictureBox.Location = new System.Drawing.Point(1, 1);
            this.geriDonPictureBox.Name = "geriDonPictureBox";
            this.geriDonPictureBox.Size = new System.Drawing.Size(23, 19);
            this.geriDonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.geriDonPictureBox.TabIndex = 37;
            this.geriDonPictureBox.TabStop = false;
            this.geriDonPictureBox.Click += new System.EventHandler(this.geriDonPictureBox_Click);
            // 
            // tamamlandiDataGridView
            // 
            this.tamamlandiDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tamamlandiDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tamamlandiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tamamlandiDataGridView.Location = new System.Drawing.Point(1, 91);
            this.tamamlandiDataGridView.Name = "tamamlandiDataGridView";
            this.tamamlandiDataGridView.Size = new System.Drawing.Size(232, 373);
            this.tamamlandiDataGridView.TabIndex = 38;
            // 
            // araButton
            // 
            this.araButton.Location = new System.Drawing.Point(169, 64);
            this.araButton.Name = "araButton";
            this.araButton.Size = new System.Drawing.Size(57, 23);
            this.araButton.TabIndex = 47;
            this.araButton.Text = "Ara";
            this.araButton.UseVisualStyleBackColor = true;
            this.araButton.Click += new System.EventHandler(this.araButton_Click);
            // 
            // araTextBox
            // 
            this.araTextBox.Location = new System.Drawing.Point(12, 65);
            this.araTextBox.Name = "araTextBox";
            this.araTextBox.Size = new System.Drawing.Size(151, 20);
            this.araTextBox.TabIndex = 46;
            this.araTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.araTextBox_KeyPress);
            // 
            // siparisNoRadioButton
            // 
            this.siparisNoRadioButton.AutoSize = true;
            this.siparisNoRadioButton.Location = new System.Drawing.Point(158, 40);
            this.siparisNoRadioButton.Name = "siparisNoRadioButton";
            this.siparisNoRadioButton.Size = new System.Drawing.Size(73, 17);
            this.siparisNoRadioButton.TabIndex = 45;
            this.siparisNoRadioButton.Text = "Sipariş No";
            this.siparisNoRadioButton.UseVisualStyleBackColor = true;
            this.siparisNoRadioButton.CheckedChanged += new System.EventHandler(this.siparisNoRadioButton_CheckedChanged);
            // 
            // telNoRadioButton
            // 
            this.telNoRadioButton.AutoSize = true;
            this.telNoRadioButton.Location = new System.Drawing.Point(95, 40);
            this.telNoRadioButton.Name = "telNoRadioButton";
            this.telNoRadioButton.Size = new System.Drawing.Size(57, 17);
            this.telNoRadioButton.TabIndex = 44;
            this.telNoRadioButton.Text = "Tel No";
            this.telNoRadioButton.UseVisualStyleBackColor = true;
            this.telNoRadioButton.CheckedChanged += new System.EventHandler(this.telNoRadioButton_CheckedChanged);
            // 
            // musteriAdiRadioButton
            // 
            this.musteriAdiRadioButton.AutoSize = true;
            this.musteriAdiRadioButton.Location = new System.Drawing.Point(12, 40);
            this.musteriAdiRadioButton.Name = "musteriAdiRadioButton";
            this.musteriAdiRadioButton.Size = new System.Drawing.Size(77, 17);
            this.musteriAdiRadioButton.TabIndex = 43;
            this.musteriAdiRadioButton.Text = "Müşteri Adı";
            this.musteriAdiRadioButton.UseVisualStyleBackColor = true;
            this.musteriAdiRadioButton.CheckedChanged += new System.EventHandler(this.musteriAdiRadioButton_CheckedChanged);
            // 
            // tamamlandi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 476);
            this.Controls.Add(this.araButton);
            this.Controls.Add(this.araTextBox);
            this.Controls.Add(this.siparisNoRadioButton);
            this.Controls.Add(this.telNoRadioButton);
            this.Controls.Add(this.musteriAdiRadioButton);
            this.Controls.Add(this.tamamlandiDataGridView);
            this.Controls.Add(this.geriDonPictureBox);
            this.Name = "tamamlandi";
            this.Text = "Tamamlanan Siparişler";
            this.Load += new System.EventHandler(this.tamamlandi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamamlandiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox geriDonPictureBox;
        private System.Windows.Forms.DataGridView tamamlandiDataGridView;
        private System.Windows.Forms.Button araButton;
        private System.Windows.Forms.TextBox araTextBox;
        private System.Windows.Forms.RadioButton siparisNoRadioButton;
        private System.Windows.Forms.RadioButton telNoRadioButton;
        private System.Windows.Forms.RadioButton musteriAdiRadioButton;
    }
}