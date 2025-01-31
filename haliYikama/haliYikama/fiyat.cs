﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace haliYikama
{
    public partial class fiyat : Form
    {
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");

        public fiyat()
        {
            InitializeComponent();
        }

        private void fiyat_Load(object sender, EventArgs e)
        {
            fiyatGoster();
            sayfa2.Location = sayfa1.Location;
            sayfa2.Visible = false;
        }

        private void geriDonPictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void rightPictureBox_Click(object sender, EventArgs e)
        {
            sayfa1.Visible = false;
            sayfa2.Visible = true;
        }

        private void leftPictureBox_Click(object sender, EventArgs e)
        {
            sayfa2.Visible = true;
            sayfa1.Visible = false;
        }

        private void rightPictureBox2_Click(object sender, EventArgs e)
        {
            sayfa1.Visible = true;
            sayfa2.Visible = false;
        }

        private void leftPictureBox2_Click(object sender, EventArgs e)
        {
            sayfa1.Visible = true;
            sayfa2.Visible = false;
        }

        private void kaydetButton_MouseEnter(object sender, EventArgs e)
        {
            kaydetButton.BackColor = Color.FromArgb(160, 190, 210);
        }

        private void kaydetButton_MouseLeave(object sender, EventArgs e)
        {
            kaydetButton.BackColor = Color.FromArgb(200, 220, 240);
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            fiyatKaydet();
        }

        void fiyatGoster()
        {
            string komut = "SELECT * FROM haliFiyat WHERE Kimlik=11";

            connect.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                makineFiyatTextBox.Text = row["makine"].ToString();
                akrilikFiyatTextBox.Text = row["akrilik"].ToString();
                shaggyFiyatTextBox.Text = row["shaggy"].ToString();
                plastikFiyatTextBox.Text = row["plastik"].ToString();
                bambuFiyatTextBox.Text = row["bambu"].ToString();
                yunFiyatTextBox.Text = row["yun"].ToString();
                ispartaTextBox.Text = row["isparta"].ToString();
                ipekFiyatTextBox.Text = row["ipek"].ToString();
                storPerdeTextBox.Text = row["storPerde"].ToString();
                overlokFiyatTextBox.Text = row["overlok"].ToString();
                yorganTekFiyatTextBox.Text = row["yorganTek"].ToString();
                yorganCiftFiyatTextBox.Text = row["yorganCift"].ToString();
            }

            connect.Close();
        }

        void fiyatKaydet()
        {
            if (!string.IsNullOrWhiteSpace(makineFiyatTextBox.Text) && !string.IsNullOrWhiteSpace(akrilikFiyatTextBox.Text) && !string.IsNullOrWhiteSpace(shaggyFiyatTextBox.Text) && !string.IsNullOrWhiteSpace(plastikFiyatTextBox.Text) && !string.IsNullOrWhiteSpace(bambuFiyatTextBox.Text) && !string.IsNullOrWhiteSpace(yunFiyatTextBox.Text) && !string.IsNullOrWhiteSpace(ipekFiyatTextBox.Text) && !string.IsNullOrWhiteSpace(storPerdeTextBox.Text) && !string.IsNullOrWhiteSpace(overlokFiyatTextBox.Text) && !string.IsNullOrWhiteSpace(yorganTekFiyatTextBox.Text) && !string.IsNullOrWhiteSpace(yorganCiftFiyatTextBox.Text))
            {
                string komut = "UPDATE haliFiyat SET " +
                             "makine=" + makineFiyatTextBox.Text + ", " +
                             "akrilik=" + akrilikFiyatTextBox.Text + ", " +
                             "shaggy=" + shaggyFiyatTextBox.Text + ", " +
                             "plastik=" + plastikFiyatTextBox.Text + ", " +
                             "bambu=" + bambuFiyatTextBox.Text + ", " +
                             "yun=" + yunFiyatTextBox.Text + ", " +
                             "isparta=" + ispartaTextBox.Text + ", " +
                             "ipek=" + ipekFiyatTextBox.Text + ", " +
                             "storPerde=" + storPerdeTextBox.Text + ", " +
                             "overlok=" + overlokFiyatTextBox.Text + ", " +
                             "yorganTek=" + yorganTekFiyatTextBox.Text + ", " +
                             "yorganCift=" + yorganCiftFiyatTextBox.Text + " " +
                             "WHERE Kimlik=11";
                connect.Open();

                OleDbCommand kaydet = new OleDbCommand(komut, connect);
                kaydet.ExecuteNonQuery();

                MessageBox.Show("Fiyatlar Güncellendi!!");

                connect.Close();
            }
            else MessageBox.Show("Boş alan bırakmayınız!!");
        }
    }
}
