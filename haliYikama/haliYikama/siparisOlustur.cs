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
using System.Globalization;

namespace haliYikama
{
    public partial class siparisOlustur : Form
    {
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");

        public string AdSoyad { get; set; }
        public string TelNo { get; set; }
        public string Adres { get; set; }
        public int Kimlik { get; set; }

        /*
        return adSoyadLabel.Text;
        adSoyadLabel.Text = value;

        return telNoLabel.Text;
        telNoLabel.Text = value; 

        return adresLabel.Text; 
        adresLabel.Text = value;
        */


        public siparisOlustur()
        {
            InitializeComponent();
        }

        private void siparisOlustur_Load(object sender, EventArgs e)
        {

            veriGuncelle();
            //adSoyadLabel.Text = AdSoyad;
            //telNoLabel.Text = TelNo;
            //adresLabel.Text = Adres;
        }

        private void geriDonPictureBox_Click(object sender, EventArgs e)
        {
            musteriler musteriler = new musteriler();
            musteriler.Show();
            this.Hide();
        }

        private void musteriDuzenleButton_Click(object sender, EventArgs e)
        {
            musteriDuzenle musteriDuzenle = new musteriDuzenle();
            musteriDuzenle.adSoyad = AdSoyad;
            musteriDuzenle.telNo = TelNo;
            musteriDuzenle.adres = Adres;
            musteriDuzenle.kimlik = Kimlik;
            musteriDuzenle.Show();
            this.Hide();
        }

        private void siparisOlusturButton_Click(object sender, EventArgs e)
        {
            databaseSiparisOlustur();
        }

        private void musteriSilButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Müşteriyi silmek istediğinden emin misin?", "Sorgu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                musteriSil();
                musteriler musteriler = new musteriler();
                musteriler.Show();
                this.Hide();
            }
        }

        void databaseSiparisOlustur()
        {
            string adiSoyadi = adSoyadLabel.Text;
            string telNo = telNoLabel.Text;
            string adres = adresLabel.Text;
            string siparisTarihi = siparisTarihiDateTimePicker.Value.ToString("yyyy-MM-dd");
            string siparisNotu = siparisNotuTextBox.Text;
            string siparisDurum = "Alınacak";

            string komut = $"INSERT INTO siparisler (adiSoyadi, telNo, adres, siparisTarih, siparisNotu, siparisDurum) "
                         + $"VALUES ('{adiSoyadi}', '{telNo}', '{adres}', '{siparisTarihi}', '{siparisNotu}', '{siparisDurum}')";
            connect.Open();

            OleDbCommand cmd = new OleDbCommand(komut, connect);
            cmd.ExecuteNonQuery();

            connect.Close();
        }

        void musteriSil()
        {
            string komut = "DELETE FROM musteriler WHERE Kimlik=" + Kimlik + "";

            connect.Open();

            OleDbCommand cmd = new OleDbCommand(komut, connect);
            cmd.ExecuteNonQuery();

            connect.Close();
        }


        void veriGuncelle()
        {
            string komut = "SELECT * FROM musteriler WHERE Kimlik = " + Kimlik;

            connect.Open();

            OleDbCommand cmd = new OleDbCommand(komut, connect);
            OleDbDataReader oku = cmd.ExecuteReader();

            if (oku.Read())
            {
                adSoyadLabel.Text = oku.GetString(1).ToString();
                telNoLabel.Text = oku.GetString(2).ToString();
                adresLabel.Text = oku.GetString(3).ToString();
            }
            else
            {
                MessageBox.Show("Hata!!");
            }

            connect.Close();
            
            siparisTarihiDateTimePicker.Value = DateTime.Now;
        }
    }
}
