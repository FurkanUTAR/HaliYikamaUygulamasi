namespace haliYikama
{
    partial class musteriler
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
            this.musteriAdiRadioButton = new System.Windows.Forms.RadioButton();
            this.telNoRadioButton = new System.Windows.Forms.RadioButton();
            this.siparisNoRadioButton = new System.Windows.Forms.RadioButton();
            this.araTextBox = new System.Windows.Forms.TextBox();
            this.araButton = new System.Windows.Forms.Button();
            this.geriDonPictureBox = new System.Windows.Forms.PictureBox();
            this.musteriEklePictureBox = new System.Windows.Forms.PictureBox();
            this.musteriDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriEklePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // musteriAdiRadioButton
            // 
            this.musteriAdiRadioButton.AutoSize = true;
            this.musteriAdiRadioButton.Location = new System.Drawing.Point(8, 26);
            this.musteriAdiRadioButton.Name = "musteriAdiRadioButton";
            this.musteriAdiRadioButton.Size = new System.Drawing.Size(77, 17);
            this.musteriAdiRadioButton.TabIndex = 0;
            this.musteriAdiRadioButton.TabStop = true;
            this.musteriAdiRadioButton.Text = "Müşteri Adı";
            this.musteriAdiRadioButton.UseVisualStyleBackColor = true;
            // 
            // telNoRadioButton
            // 
            this.telNoRadioButton.AutoSize = true;
            this.telNoRadioButton.Location = new System.Drawing.Point(91, 26);
            this.telNoRadioButton.Name = "telNoRadioButton";
            this.telNoRadioButton.Size = new System.Drawing.Size(57, 17);
            this.telNoRadioButton.TabIndex = 1;
            this.telNoRadioButton.TabStop = true;
            this.telNoRadioButton.Text = "Tel No";
            this.telNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // siparisNoRadioButton
            // 
            this.siparisNoRadioButton.AutoSize = true;
            this.siparisNoRadioButton.Location = new System.Drawing.Point(154, 26);
            this.siparisNoRadioButton.Name = "siparisNoRadioButton";
            this.siparisNoRadioButton.Size = new System.Drawing.Size(73, 17);
            this.siparisNoRadioButton.TabIndex = 2;
            this.siparisNoRadioButton.TabStop = true;
            this.siparisNoRadioButton.Text = "Sipariş No";
            this.siparisNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // araTextBox
            // 
            this.araTextBox.Location = new System.Drawing.Point(8, 51);
            this.araTextBox.Name = "araTextBox";
            this.araTextBox.Size = new System.Drawing.Size(151, 20);
            this.araTextBox.TabIndex = 3;
            // 
            // araButton
            // 
            this.araButton.Location = new System.Drawing.Point(165, 50);
            this.araButton.Name = "araButton";
            this.araButton.Size = new System.Drawing.Size(57, 23);
            this.araButton.TabIndex = 4;
            this.araButton.Text = "Ara";
            this.araButton.UseVisualStyleBackColor = true;
            this.araButton.Click += new System.EventHandler(this.araButton_Click);
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
            // musteriEklePictureBox
            // 
            this.musteriEklePictureBox.Image = global::haliYikama.Properties.Resources.Add;
            this.musteriEklePictureBox.Location = new System.Drawing.Point(196, 435);
            this.musteriEklePictureBox.Name = "musteriEklePictureBox";
            this.musteriEklePictureBox.Size = new System.Drawing.Size(36, 37);
            this.musteriEklePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.musteriEklePictureBox.TabIndex = 5;
            this.musteriEklePictureBox.TabStop = false;
            this.musteriEklePictureBox.Click += new System.EventHandler(this.musteriEklePictureBox_Click);
            // 
            // musteriDataGridView
            // 
            this.musteriDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.musteriDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.musteriDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musteriDataGridView.Location = new System.Drawing.Point(8, 76);
            this.musteriDataGridView.Name = "musteriDataGridView";
            this.musteriDataGridView.Size = new System.Drawing.Size(214, 353);
            this.musteriDataGridView.TabIndex = 37;
            this.musteriDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.musteriDataGridView_CellDoubleClick);
            // 
            // musteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 476);
            this.Controls.Add(this.musteriDataGridView);
            this.Controls.Add(this.geriDonPictureBox);
            this.Controls.Add(this.musteriEklePictureBox);
            this.Controls.Add(this.araButton);
            this.Controls.Add(this.araTextBox);
            this.Controls.Add(this.siparisNoRadioButton);
            this.Controls.Add(this.telNoRadioButton);
            this.Controls.Add(this.musteriAdiRadioButton);
            this.Name = "musteriler";
            this.Text = "Müşteriler";
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriEklePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton musteriAdiRadioButton;
        private System.Windows.Forms.RadioButton telNoRadioButton;
        private System.Windows.Forms.RadioButton siparisNoRadioButton;
        private System.Windows.Forms.TextBox araTextBox;
        private System.Windows.Forms.Button araButton;
        private System.Windows.Forms.PictureBox musteriEklePictureBox;
        private System.Windows.Forms.PictureBox geriDonPictureBox;
        private System.Windows.Forms.DataGridView musteriDataGridView;
    }
}