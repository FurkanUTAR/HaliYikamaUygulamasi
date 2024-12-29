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
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelirGiderDataGridView)).BeginInit();
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
            // gelirGiderDataGridView
            // 
            this.gelirGiderDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gelirGiderDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gelirGiderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gelirGiderDataGridView.Location = new System.Drawing.Point(1, 69);
            this.gelirGiderDataGridView.Name = "gelirGiderDataGridView";
            this.gelirGiderDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gelirGiderDataGridView.Size = new System.Drawing.Size(232, 290);
            this.gelirGiderDataGridView.TabIndex = 38;
            // 
            // silButton
            // 
            this.silButton.Location = new System.Drawing.Point(12, 412);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(210, 52);
            this.silButton.TabIndex = 40;
            this.silButton.Text = "Sil";
            this.silButton.UseVisualStyleBackColor = true;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Gelir:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Gider:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Kâr:";
            // 
            // gelirLabel
            // 
            this.gelirLabel.AutoSize = true;
            this.gelirLabel.Location = new System.Drawing.Point(46, 366);
            this.gelirLabel.Name = "gelirLabel";
            this.gelirLabel.Size = new System.Drawing.Size(13, 13);
            this.gelirLabel.TabIndex = 44;
            this.gelirLabel.Text = "0";
            // 
            // giderLabel
            // 
            this.giderLabel.AutoSize = true;
            this.giderLabel.Location = new System.Drawing.Point(160, 366);
            this.giderLabel.Name = "giderLabel";
            this.giderLabel.Size = new System.Drawing.Size(13, 13);
            this.giderLabel.TabIndex = 45;
            this.giderLabel.Text = "0";
            // 
            // karLabel
            // 
            this.karLabel.AutoSize = true;
            this.karLabel.Location = new System.Drawing.Point(46, 390);
            this.karLabel.Name = "karLabel";
            this.karLabel.Size = new System.Drawing.Size(13, 13);
            this.karLabel.TabIndex = 46;
            this.karLabel.Text = "0";
            // 
            // filtreComboBox
            // 
            this.filtreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtreComboBox.FormattingEnabled = true;
            this.filtreComboBox.Location = new System.Drawing.Point(101, 42);
            this.filtreComboBox.Name = "filtreComboBox";
            this.filtreComboBox.Size = new System.Drawing.Size(121, 21);
            this.filtreComboBox.TabIndex = 47;
            this.filtreComboBox.SelectedIndexChanged += new System.EventHandler(this.filtreComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Filtrele";
            // 
            // gelirGiderTablo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 476);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.filtreComboBox);
            this.Controls.Add(this.karLabel);
            this.Controls.Add(this.giderLabel);
            this.Controls.Add(this.gelirLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.gelirGiderDataGridView);
            this.Controls.Add(this.geriDonPictureBox);
            this.Name = "gelirGiderTablo";
            this.Text = "Gelir-Gider Tablosu";
            this.Load += new System.EventHandler(this.gelirGiderTablo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelirGiderDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}