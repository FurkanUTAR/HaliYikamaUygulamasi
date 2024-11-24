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
    public partial class girisEkrani : Form
    {

        OleDbConnection connect=new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");


        public girisEkrani()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
            parolaTextBox.UseSystemPasswordChar = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            parolaTextBox.UseSystemPasswordChar = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            kayitEkrani kayitOl = new kayitEkrani();
            this.Hide();
            kayitOl.Show();
        }

        private void girisYapButton_Click(object sender, EventArgs e)
        {
            kontrol();
        }

        void kontrol()
        {
            string komut = "SELECT COUNT(*) FROM kullanicilar WHERE firmaAdi='" + firmaAdiTextBox.Text + "' AND kullaniciAdi='" + kullaniciAdiTextBox.Text + "' AND parola='" + parolaTextBox.Text + "'  ";

            connect.Open();

            OleDbCommand kontrol = new OleDbCommand(komut,connect);

            int deger = (int)kontrol.ExecuteScalar();

            if (deger > 0)
            {

                anaSayfa anaSayfa = new anaSayfa();
                this.Hide();
                anaSayfa.Show();


            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız");
            }

            kontrol.ExecuteNonQuery();

            connect.Close();

            if (string.IsNullOrEmpty(firmaAdiTextBox.Text) || string.IsNullOrEmpty(kullaniciAdiTextBox.Text) || string.IsNullOrEmpty(parolaTextBox.Text))
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız");
            }
            else
            {

            }

        }
    }
}
