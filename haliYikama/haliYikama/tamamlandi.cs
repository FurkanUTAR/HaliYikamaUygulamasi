using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace haliYikama
{
    public partial class tamamlandi : Form
    {
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");

        public tamamlandi()
        {
            InitializeComponent();
        }

        private void tamamlandi_Load(object sender, EventArgs e)
        {
            butunSiparisleriGoster();
        }

        private void geriDonPictureBox_Click(object sender, EventArgs e)
        {
            anaSayfa anaSayfa = new anaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void musteriAdiRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (musteriAdiRadioButton.Checked) araTextBox.KeyPress -= araTextBox_KeyPress;
        }

        private void araTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) e.Handled = true;
        }

        private void telNoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (telNoRadioButton.Checked) araTextBox.KeyPress += araTextBox_KeyPress;
            else araTextBox.KeyPress -= araTextBox_KeyPress;
        }

        private void siparisNoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (siparisNoRadioButton.Checked) araTextBox.KeyPress += araTextBox_KeyPress;
            else araTextBox.KeyPress -= araTextBox_KeyPress;
        }

        private void araButton_Click(object sender, EventArgs e)
        {
            if (musteriAdiRadioButton.Checked)
            {
                if (string.IsNullOrWhiteSpace(araTextBox.Text)) butunSiparisleriGoster();
                else musteriAdiAra();

            }
            else if (telNoRadioButton.Checked)
            {
                if (string.IsNullOrWhiteSpace(araTextBox.Text)) butunSiparisleriGoster();
                else telNoAra();
            }
            else if (siparisNoRadioButton.Checked)
            {
                if (string.IsNullOrWhiteSpace(araTextBox.Text)) butunSiparisleriGoster();
                else siparisNoAra();
            }
            else butunSiparisleriGoster();
        }

        void musteriAdiAra()
        {
            string arama = "%" + araTextBox.Text + "%";
            string komut = "SELECT * FROM siparisler WHERE adiSoyadi LIKE '" + arama + "' AND siparisDurum='Tamamlandı'";

            connect.Open();


            OleDbDataAdapter da = new OleDbDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Aradığını kriterlere uygun müşteri bulunamadı!!");
            }
            else
            {
                tamamlandiDataGridView.DataSource = dt;
            }

            connect.Close();

            tamamlandiDataGridView.Columns["veresiyeTutar"].Visible = false;
        }

        void telNoAra()
        {
            string arama = "%" + araTextBox.Text + "%";
            string komut = "SELECT * FROM siparisler WHERE telNo LIKE '" + arama + "' AND siparisDurum='Tamamlandı'";

            connect.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Aradığını kriterlere uygun müşteri bulunamadı!!");
            }
            else
            {
                tamamlandiDataGridView.DataSource = dt;
            }

            connect.Close();

            tamamlandiDataGridView.Columns["veresiyeTutar"].Visible = false;
        }

        void butunSiparisleriGoster()
        {
            string komut = "SELECT * FROM siparisler WHERE siparisDurum='Tamamlandı' ";

            connect.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0) MessageBox.Show("Aradığını kriterlere uygun müşteri bulunamadı!!");
            else
            {
                tamamlandiDataGridView.DataSource = dt;
                tamamlandiDataGridView.Columns["veresiyeTutar"].Visible = false;
            }

            connect.Close();
        }

        void siparisNoAra()
        {
            int arama = int.Parse(araTextBox.Text);
            string komut = "SELECT * FROM siparisler WHERE siparisNo LIKE '%" + arama + "%' AND siparisDurum='Tamamlandı'";

            connect.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Aradığını kriterlere uygun müşteri bulunamadı!!");
            }
            else
            {
                tamamlandiDataGridView.DataSource = dt;
            }

            connect.Close();

            tamamlandiDataGridView.Columns["veresiyeTutar"].Visible = false;
        }
    }
}
