﻿namespace haliYikama
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
            this.gelirGiderDataGridView.Location = new System.Drawing.Point(1, 40);
            this.gelirGiderDataGridView.Name = "gelirGiderDataGridView";
            this.gelirGiderDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gelirGiderDataGridView.Size = new System.Drawing.Size(232, 319);
            this.gelirGiderDataGridView.TabIndex = 38;
            // 
            // silButton
            // 
            this.silButton.Location = new System.Drawing.Point(12, 365);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(210, 52);
            this.silButton.TabIndex = 40;
            this.silButton.Text = "Sil";
            this.silButton.UseVisualStyleBackColor = true;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // gelirGiderTablo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 476);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.gelirGiderDataGridView);
            this.Controls.Add(this.geriDonPictureBox);
            this.Name = "gelirGiderTablo";
            this.Text = "Gelir-Gider Tablosu";
            this.Load += new System.EventHandler(this.gelirGiderTablo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelirGiderDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox geriDonPictureBox;
        private System.Windows.Forms.DataGridView gelirGiderDataGridView;
        private System.Windows.Forms.Button silButton;
    }
}