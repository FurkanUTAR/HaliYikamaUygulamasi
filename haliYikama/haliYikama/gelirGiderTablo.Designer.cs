namespace haliYikama
{
    partial class gelirGiderTablo
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
            this.gelirGiderDataGridView = new System.Windows.Forms.DataGridView();
            this.silButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gelirLabel = new System.Windows.Forms.Label();
            this.giderLabel = new System.Windows.Forms.Label();
            this.karLabel = new System.Windows.Forms.Label();
            this.filtreComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tarihDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelirGiderDataGridView)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            // gelirGiderDataGridView
            // 
            this.gelirGiderDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gelirGiderDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.gelirGiderDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gelirGiderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gelirGiderDataGridView.Location = new System.Drawing.Point(3, 56);
            this.gelirGiderDataGridView.Name = "gelirGiderDataGridView";
            this.gelirGiderDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gelirGiderDataGridView.Size = new System.Drawing.Size(356, 165);
            this.gelirGiderDataGridView.TabIndex = 38;
            // 
            // silButton
            // 
            this.silButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.silButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silButton.Location = new System.Drawing.Point(-7, -5);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(150, 69);
            this.silButton.TabIndex = 40;
            this.silButton.Text = "Sil";
            this.silButton.UseVisualStyleBackColor = false;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            this.silButton.MouseEnter += new System.EventHandler(this.silButton_MouseEnter);
            this.silButton.MouseLeave += new System.EventHandler(this.silButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Gelir:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Gider:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Kâr:";
            // 
            // gelirLabel
            // 
            this.gelirLabel.AutoSize = true;
            this.gelirLabel.Location = new System.Drawing.Point(54, 227);
            this.gelirLabel.Name = "gelirLabel";
            this.gelirLabel.Size = new System.Drawing.Size(14, 16);
            this.gelirLabel.TabIndex = 44;
            this.gelirLabel.Text = "0";
            // 
            // giderLabel
            // 
            this.giderLabel.AutoSize = true;
            this.giderLabel.Location = new System.Drawing.Point(54, 248);
            this.giderLabel.Name = "giderLabel";
            this.giderLabel.Size = new System.Drawing.Size(14, 16);
            this.giderLabel.TabIndex = 45;
            this.giderLabel.Text = "0";
            // 
            // karLabel
            // 
            this.karLabel.AutoSize = true;
            this.karLabel.Location = new System.Drawing.Point(54, 269);
            this.karLabel.Name = "karLabel";
            this.karLabel.Size = new System.Drawing.Size(14, 16);
            this.karLabel.TabIndex = 46;
            this.karLabel.Text = "0";
            // 
            // filtreComboBox
            // 
            this.filtreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtreComboBox.FormattingEnabled = true;
            this.filtreComboBox.Location = new System.Drawing.Point(69, 26);
            this.filtreComboBox.Name = "filtreComboBox";
            this.filtreComboBox.Size = new System.Drawing.Size(121, 24);
            this.filtreComboBox.TabIndex = 47;
            this.filtreComboBox.SelectedIndexChanged += new System.EventHandler(this.filtreComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Filtrele";
            // 
            // tarihDateTimePicker
            // 
            this.tarihDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tarihDateTimePicker.Location = new System.Drawing.Point(198, 27);
            this.tarihDateTimePicker.Name = "tarihDateTimePicker";
            this.tarihDateTimePicker.Size = new System.Drawing.Size(91, 22);
            this.tarihDateTimePicker.TabIndex = 49;
            this.tarihDateTimePicker.ValueChanged += new System.EventHandler(this.tarihDateTimePicker_ValueChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.geriDonPictureBox);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(434, 361);
            this.panel4.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(108, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 25);
            this.label6.TabIndex = 40;
            this.label6.Text = "Gelir-Gider Tablosu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.gelirGiderDataGridView);
            this.panel1.Controls.Add(this.karLabel);
            this.panel1.Controls.Add(this.tarihDateTimePicker);
            this.panel1.Controls.Add(this.giderLabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.gelirLabel);
            this.panel1.Controls.Add(this.filtreComboBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(39, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 304);
            this.panel1.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.silButton);
            this.panel2.Location = new System.Drawing.Point(211, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 58);
            this.panel2.TabIndex = 50;
            // 
            // gelirGiderTablo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gelirGiderTablo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gelir-Gider Tablosu";
            this.Load += new System.EventHandler(this.gelirGiderTablo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelirGiderDataGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox geriDonPictureBox;
        private System.Windows.Forms.DataGridView gelirGiderDataGridView;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label gelirLabel;
        private System.Windows.Forms.Label giderLabel;
        private System.Windows.Forms.Label karLabel;
        private System.Windows.Forms.ComboBox filtreComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker tarihDateTimePicker;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}