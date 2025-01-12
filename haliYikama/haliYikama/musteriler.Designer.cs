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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.musteriAdiRadioButton = new System.Windows.Forms.RadioButton();
            this.telNoRadioButton = new System.Windows.Forms.RadioButton();
            this.siparisNoRadioButton = new System.Windows.Forms.RadioButton();
            this.araTextBox = new System.Windows.Forms.TextBox();
            this.araButton = new System.Windows.Forms.Button();
            this.geriDonPictureBox = new System.Windows.Forms.PictureBox();
            this.musteriEklePictureBox = new System.Windows.Forms.PictureBox();
            this.musteriDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.adresRadiobutton = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriEklePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // musteriAdiRadioButton
            // 
            this.musteriAdiRadioButton.AutoSize = true;
            this.musteriAdiRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriAdiRadioButton.Location = new System.Drawing.Point(324, 15);
            this.musteriAdiRadioButton.Name = "musteriAdiRadioButton";
            this.musteriAdiRadioButton.Size = new System.Drawing.Size(91, 20);
            this.musteriAdiRadioButton.TabIndex = 0;
            this.musteriAdiRadioButton.Text = "Müşteri Adı";
            this.musteriAdiRadioButton.UseVisualStyleBackColor = true;
            this.musteriAdiRadioButton.CheckedChanged += new System.EventHandler(this.musteriAdiRadioButton_CheckedChanged);
            // 
            // telNoRadioButton
            // 
            this.telNoRadioButton.AutoSize = true;
            this.telNoRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telNoRadioButton.Location = new System.Drawing.Point(488, 15);
            this.telNoRadioButton.Name = "telNoRadioButton";
            this.telNoRadioButton.Size = new System.Drawing.Size(66, 20);
            this.telNoRadioButton.TabIndex = 1;
            this.telNoRadioButton.Text = "Tel No";
            this.telNoRadioButton.UseVisualStyleBackColor = true;
            this.telNoRadioButton.CheckedChanged += new System.EventHandler(this.telNoRadioButton_CheckedChanged);
            // 
            // siparisNoRadioButton
            // 
            this.siparisNoRadioButton.AutoSize = true;
            this.siparisNoRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparisNoRadioButton.Location = new System.Drawing.Point(560, 15);
            this.siparisNoRadioButton.Name = "siparisNoRadioButton";
            this.siparisNoRadioButton.Size = new System.Drawing.Size(88, 20);
            this.siparisNoRadioButton.TabIndex = 2;
            this.siparisNoRadioButton.Text = "Sipariş No";
            this.siparisNoRadioButton.UseVisualStyleBackColor = true;
            this.siparisNoRadioButton.CheckedChanged += new System.EventHandler(this.siparisNoRadioButton_CheckedChanged);
            // 
            // araTextBox
            // 
            this.araTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.araTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.araTextBox.ForeColor = System.Drawing.Color.Black;
            this.araTextBox.Location = new System.Drawing.Point(324, 37);
            this.araTextBox.Multiline = true;
            this.araTextBox.Name = "araTextBox";
            this.araTextBox.Size = new System.Drawing.Size(230, 33);
            this.araTextBox.TabIndex = 3;
            this.araTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.araTextBox_KeyPress);
            // 
            // araButton
            // 
            this.araButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.araButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.araButton.Location = new System.Drawing.Point(-4, -6);
            this.araButton.Name = "araButton";
            this.araButton.Size = new System.Drawing.Size(83, 45);
            this.araButton.TabIndex = 4;
            this.araButton.Text = "Ara";
            this.araButton.UseVisualStyleBackColor = false;
            this.araButton.Click += new System.EventHandler(this.araButton_Click);
            this.araButton.MouseEnter += new System.EventHandler(this.araButton_MouseEnter);
            this.araButton.MouseLeave += new System.EventHandler(this.araButton_MouseLeave);
            // 
            // geriDonPictureBox
            // 
            this.geriDonPictureBox.Image = global::haliYikama.Properties.Resources.left;
            this.geriDonPictureBox.Location = new System.Drawing.Point(1, 1);
            this.geriDonPictureBox.Name = "geriDonPictureBox";
            this.geriDonPictureBox.Size = new System.Drawing.Size(30, 25);
            this.geriDonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.geriDonPictureBox.TabIndex = 36;
            this.geriDonPictureBox.TabStop = false;
            this.geriDonPictureBox.Click += new System.EventHandler(this.geriDonPictureBox_Click);
            // 
            // musteriEklePictureBox
            // 
            this.musteriEklePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.musteriEklePictureBox.Image = global::haliYikama.Properties.Resources.Add;
            this.musteriEklePictureBox.Location = new System.Drawing.Point(920, 20);
            this.musteriEklePictureBox.Name = "musteriEklePictureBox";
            this.musteriEklePictureBox.Size = new System.Drawing.Size(50, 50);
            this.musteriEklePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.musteriEklePictureBox.TabIndex = 5;
            this.musteriEklePictureBox.TabStop = false;
            this.musteriEklePictureBox.Click += new System.EventHandler(this.musteriEklePictureBox_Click);
            // 
            // musteriDataGridView
            // 
            this.musteriDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.musteriDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.musteriDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.musteriDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.musteriDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.musteriDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.musteriDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.musteriDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.musteriDataGridView.Location = new System.Drawing.Point(12, 8);
            this.musteriDataGridView.Name = "musteriDataGridView";
            this.musteriDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.musteriDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.musteriDataGridView.RowHeadersVisible = false;
            this.musteriDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.musteriDataGridView.Size = new System.Drawing.Size(958, 434);
            this.musteriDataGridView.TabIndex = 37;
            this.musteriDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.musteriDataGridView_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.adresRadiobutton);
            this.panel1.Controls.Add(this.siparisNoRadioButton);
            this.panel1.Controls.Add(this.musteriEklePictureBox);
            this.panel1.Controls.Add(this.telNoRadioButton);
            this.panel1.Controls.Add(this.araTextBox);
            this.panel1.Controls.Add(this.musteriAdiRadioButton);
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 88);
            this.panel1.TabIndex = 38;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.musteriDataGridView);
            this.panel2.Location = new System.Drawing.Point(0, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 450);
            this.panel2.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label1.Location = new System.Drawing.Point(421, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 38;
            this.label1.Text = "Müşteriler";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.panel5.Controls.Add(this.geriDonPictureBox);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(982, 47);
            this.panel5.TabIndex = 43;
            // 
            // musteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 584);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "musteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.musteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriEklePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton adresRadiobutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
    }
}