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
    public partial class anaSayfa : Form
    {
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");

        public anaSayfa()
        {
            InitializeComponent();
        }

        private void anaSayfa_Load(object sender, EventArgs e)
        {
            anaSayfaPanel.Visible = true;
            ayarlarPanel.Visible = false;


            if (anaSayfaPanel.Visible) anaSayfaButton.BackColor = Color.FromArgb(150, 150, 180);
            else anaSayfaButton.BackColor = Color.FromArgb(200, 200, 220);

            ayarlarPanel.Location = anaSayfaPanel.Location;
        }

        private void fiyatButton_Click(object sender, EventArgs e)
        {
            fiyat fiyat = new fiyat();
            fiyat.Show();
           
        }

        private void mesajlarButton_Click(object sender, EventArgs e)
        {
            mesajlar mesajlar = new mesajlar();
            mesajlar.ShowDialog();
            
        }

        private void musterilerButton_Click(object sender, EventArgs e)
        {
            musteriler musteriler = new musteriler();
            musteriler.Show();
            this.Hide();
        }

        private void siparislerButton_Click(object sender, EventArgs e)
        {
            siparisler siparisler = new siparisler();
            siparisler.Show();
            this.Hide();
        }

        private void aramaGecmisiButton_Click(object sender, EventArgs e)
        {
            aramaGecmisi aramaGecmisi = new aramaGecmisi();
            aramaGecmisi.Show();
            this.Hide();
        }

        private void gelirGiderButton_Click(object sender, EventArgs e)
        {
            gelirGiderTakip gelirGiderTakip = new gelirGiderTakip();
            gelirGiderTakip.ShowDialog();
        }

        private void ozetlerButton_Click(object sender, EventArgs e)
        {
            ozetler ozetler = new ozetler();
            ozetler.ShowDialog();
        }

        private void islemdekilerButton_Click(object sender, EventArgs e)
        {
            islemdekiler islemdekiler = new islemdekiler();
            islemdekiler.Show();
            this.Hide();
        }

        private void tamamlandiButton_Click(object sender, EventArgs e)
        {
            tamamlandi tamamlandi = new tamamlandi();
            tamamlandi.Show();
            this.Hide();
        }

        private void anaSayfaButton_Click(object sender, EventArgs e)
        {
            anaSayfaPanel.Visible = true;
            ayarlarPanel.Visible = false;

            if (anaSayfaPanel.Visible) { anaSayfaButton.BackColor = Color.FromArgb(150, 150, 180); ayarlarButton.BackColor = Color.FromArgb(200, 200, 220); }
            else anaSayfaButton.BackColor = Color.FromArgb(200, 200, 220);
        }

        private void ayarlarButton_Click(object sender, EventArgs e)
        {
            anaSayfaPanel.Visible = false;
            ayarlarPanel.Visible = true;

            if (ayarlarPanel.Visible) { ayarlarButton.BackColor = Color.FromArgb(150, 150, 180); anaSayfaButton.BackColor = Color.FromArgb(200, 200, 220); }
            else ayarlarPanel.BackColor = Color.FromArgb(200, 200, 220);
        }


        private void musterilerButton_MouseEnter(object sender, EventArgs e)
        {
            musterilerButton.BackColor = Color.FromArgb(160, 190, 210);
        }

        private void siparislerButton_MouseEnter(object sender, EventArgs e)
        {
            siparislerButton.BackColor = Color.FromArgb(160, 190, 210);
        }

        private void ozetlerButton_MouseEnter(object sender, EventArgs e)
        {
            ozetlerButton.BackColor = Color.FromArgb(160, 190, 210);
        }

        private void gelirGiderButton_MouseEnter(object sender, EventArgs e)
        {
            gelirGiderButton.BackColor = Color.FromArgb(160, 190, 210);
        }

        private void islemdekilerButton_MouseEnter(object sender, EventArgs e)
        {
            islemdekilerButton.BackColor = Color.FromArgb(160, 190, 210);
        }

        private void aramaGecmisiButton_MouseEnter(object sender, EventArgs e)
        {
            aramaGecmisiButton.BackColor = Color.FromArgb(160, 190, 210);
        }

        private void tamamlandiButton_MouseEnter(object sender, EventArgs e)
        {
            tamamlandiButton.BackColor = Color.FromArgb(160, 190, 210);
        }

        private void fiyatButton_MouseEnter(object sender, EventArgs e)
        {
            fiyatButton.BackColor = Color.FromArgb(160, 190, 210);
        }

        private void mesajlarButton_MouseEnter(object sender, EventArgs e)
        {
            mesajlarButton.BackColor = Color.FromArgb(160, 190, 210);
        }


        private void musterilerButton_MouseLeave(object sender, EventArgs e)
        {
            musterilerButton.BackColor = Color.FromArgb(200, 220, 240);
        }

        private void siparislerButton_MouseLeave(object sender, EventArgs e)
        {
            siparislerButton.BackColor = Color.FromArgb(200, 220, 240);
        }

        private void ozetlerButton_MouseLeave(object sender, EventArgs e)
        {
            ozetlerButton.BackColor = Color.FromArgb(200, 220, 240);
        }

        private void gelirGiderButton_MouseLeave(object sender, EventArgs e)
        {
            gelirGiderButton.BackColor = Color.FromArgb(200, 220, 240);
        }

        private void islemdekilerButton_MouseLeave(object sender, EventArgs e)
        {
            islemdekilerButton.BackColor = Color.FromArgb(200, 220, 240);
        }

        private void aramaGecmisiButton_MouseLeave(object sender, EventArgs e)
        {
            aramaGecmisiButton.BackColor = Color.FromArgb(200, 220, 240);
        }

        private void tamamlandiButton_MouseLeave(object sender, EventArgs e)
        {
            tamamlandiButton.BackColor = Color.FromArgb(200, 220, 240);
        }

        private void fiyatButton_MouseLeave(object sender, EventArgs e)
        {
            fiyatButton.BackColor = Color.FromArgb(200, 220, 240);
        }

        private void mesajlarButton_MouseLeave(object sender, EventArgs e)
        {
            mesajlarButton.BackColor = Color.FromArgb(200, 220, 240);
        }
    }
}
