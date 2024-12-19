namespace haliYikama
{
    partial class islemdekiler
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
            this.islemdekilerDataGridView = new System.Windows.Forms.DataGridView();
            this.geriDonPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.islemdekilerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // islemdekilerDataGridView
            // 
            this.islemdekilerDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.islemdekilerDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.islemdekilerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.islemdekilerDataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.islemdekilerDataGridView.Location = new System.Drawing.Point(1, 26);
            this.islemdekilerDataGridView.Name = "islemdekilerDataGridView";
            this.islemdekilerDataGridView.Size = new System.Drawing.Size(232, 438);
            this.islemdekilerDataGridView.TabIndex = 40;
            this.islemdekilerDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.islemdekilerDataGridView_CellDoubleClick);
            // 
            // geriDonPictureBox
            // 
            this.geriDonPictureBox.Image = global::haliYikama.Properties.Resources.left;
            this.geriDonPictureBox.Location = new System.Drawing.Point(1, 1);
            this.geriDonPictureBox.Name = "geriDonPictureBox";
            this.geriDonPictureBox.Size = new System.Drawing.Size(23, 19);
            this.geriDonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.geriDonPictureBox.TabIndex = 39;
            this.geriDonPictureBox.TabStop = false;
            this.geriDonPictureBox.Click += new System.EventHandler(this.geriDonPictureBox_Click);
            // 
            // islemdekiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 476);
            this.Controls.Add(this.islemdekilerDataGridView);
            this.Controls.Add(this.geriDonPictureBox);
            this.KeyPreview = true;
            this.Name = "islemdekiler";
            this.Text = "İşlemdekiler";
            this.Load += new System.EventHandler(this.islemdekiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.islemdekilerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox geriDonPictureBox;
        private System.Windows.Forms.DataGridView islemdekilerDataGridView;
    }
}