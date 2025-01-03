﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace haliYikama
{
    public partial class veresiye : Form
    {
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");

        public int siparisNo { get; set; }
        double veresiyeKalan = 0.0;
        double veresiyeTutar = 0.0;
        double odenenTutar = 0;

        public veresiye()
        {
            InitializeComponent();
        }

        private void veresiye_Load(object sender, EventArgs e)
        {
            yukle();
            goster();
            veresiyeHesap();
            odenenTutarBul();

            veresiyeFiyatLabel.Text = veresiyeTutar.ToString() + " ₺";
        }

        private void geriDonPictureBox_Click(object sender, EventArgs e)
        {
            siparisler siparisler = new siparisler();
            siparisler.Show();
            this.Hide();
        }

        private void gonderButton_Click(object sender, EventArgs e)
        {
            kontrol();
        }
        
        void yukle()
        {
            odemeYontemiComboBox.Items.Add("Nakit");
            odemeYontemiComboBox.Items.Add("Kart");
            odemeYontemiComboBox.Items.Add("Havale");
        }

        void goster()
        {
            string komut = "SELECT * FROM haliBilgi WHERE siparisNo=" + siparisNo;

            connect.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            veresiyeDataGridView.DataSource = dt;

            connect.Close();

            veresiyeDataGridView.Columns["Kimlik"].Visible = false;
        }

        void kontrol()
        {
            if (!string.IsNullOrWhiteSpace(alinanTutarTextBox.Text) && !string.IsNullOrWhiteSpace(odemeYontemiComboBox.Text))
            {
                int alinanTutar = Convert.ToInt32(alinanTutarTextBox.Text);
                veresiyeKalan = veresiyeTutar - alinanTutar;
                if (alinanTutar > veresiyeTutar)
                {
                    MessageBox.Show("Alınan tutar toplam fiyattan büyük olamaz!!");
                }
                else if (alinanTutar == veresiyeTutar)
                {
                    DialogResult result = MessageBox.Show("Teslim etmek istediğinden emin misin?", "Sorgu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (result == DialogResult.Yes)
                    {
                        string komutSiparis = "UPDATE siparisler SET" +
                        "        siparisDurum='Tamamlandı'," +
                        "        veresiyeTutar=0" +
                        "        WHERE siparisNo=" + siparisNo;

                        string komutOdeme = "UPDATE odemeler SET " +
                        "        odenenTutar=" + (odenenTutar + alinanTutar) + "" +
                        "        WHERE siparisNo=" + siparisNo;

                        connect.Open();

                        OleDbCommand cmdSiparis = new OleDbCommand(komutSiparis, connect);
                        OleDbCommand cmdOdeme = new OleDbCommand(komutOdeme, connect);
                        cmdSiparis.ExecuteNonQuery();
                        cmdOdeme.ExecuteNonQuery();

                        connect.Close();

                        siparisler siparisler = new siparisler();
                        siparisler.Show();
                        this.Hide();
                    }
                    else
                    {

                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Veresiye almak ister misin?", "Sorgu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (result == DialogResult.Yes)
                    {
                        string komutSiparis = "UPDATE siparisler SET" +
                           "           veresiyeTutar=" + veresiyeKalan + " " +
                           "           WHERE siparisNo=" + siparisNo;

                        string komutOdeme = "UPDATE odemeler SET " +
                        "        odenenTutar=" + (odenenTutar + alinanTutar) + "" +
                        "        WHERE siparisNo=" + siparisNo;

                        connect.Open();

                        OleDbCommand cmdSiparis = new OleDbCommand(komutSiparis, connect);
                        OleDbCommand cmdOdeme = new OleDbCommand(komutOdeme, connect);
                        cmdSiparis.ExecuteNonQuery();
                        cmdOdeme.ExecuteNonQuery();

                        connect.Close();

                        siparisler siparisler = new siparisler();
                        siparisler.Show();
                        this.Hide();
                    }
                    else
                    {
                        string komutGuncelle = "UPDATE siparisler SET " +
                        "        siparisDurum='Tamamlandı'" +
                        "        WHERE siparisNo=" + siparisNo;

                        string komutOdeme = "UPDATE odemeler SET " +
                        "        odenenTutar=" + (odenenTutar + alinanTutar) + "" +
                        "        WHERE siparisNo=" + siparisNo;

                        connect.Open();

                        OleDbCommand guncelle = new OleDbCommand(komutGuncelle, connect);
                        OleDbCommand cmdOdeme = new OleDbCommand(komutOdeme, connect);
                        guncelle.ExecuteNonQuery();
                        cmdOdeme.ExecuteNonQuery();

                        connect.Close();

                        siparisler siparisler = new siparisler();
                        siparisler.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Alınan Tutar veya Ödeme Yöntemi kısmı boş bırakılamaz!!!");
            }
        }

        void veresiyeHesap()
        {
            string komut = "SELECT veresiyeTutar FROM siparisler WHERE siparisNo =" + siparisNo;

            connect.Open();

            OleDbCommand cmd = new OleDbCommand(komut, connect);
            OleDbDataReader oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                veresiyeTutar = oku["veresiyeTutar"] != DBNull.Value ? Convert.ToDouble(oku["veresiyeTutar"]) : 0.0;
            }
            connect.Close();
        }

        void odenenTutarBul()
        {
            string komut = "SELECT * FROM odemeler WHERE siparisNo = " + siparisNo;

            connect.Open();

            OleDbCommand cmd = new OleDbCommand(komut, connect);
            OleDbDataReader oku = cmd.ExecuteReader();

            if (oku.Read())
            {
                if (!oku.IsDBNull(4))
                {
                    decimal tutar = oku.GetDecimal(4);
                    odenenTutar = (double)tutar;
                }
                else odenenTutar = 0;
            }

            connect.Close();
        }
    }
}
