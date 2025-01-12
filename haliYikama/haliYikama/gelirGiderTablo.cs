using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace haliYikama
{
    public partial class gelirGiderTablo : Form
    {
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");

        public gelirGiderTablo()
        {
            InitializeComponent();
        }

        private void gelirGiderTablo_Load(object sender, EventArgs e)
        {
            yukle();
            goster();
            hesap();
        }

        private void geriDonPictureBox_Click(object sender, EventArgs e)
        {
            gelirGiderTakip gelirGiderTakip = new gelirGiderTakip();
            gelirGiderTakip.Show();
            this.Hide();
        }

        private void filtreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filtreComboBox.SelectedIndex == 0) secilenTarih();
            else if (filtreComboBox.SelectedIndex == 1) tarihAzalan();
            else if (filtreComboBox.SelectedIndex == 2) tarihArtan();
            else if (filtreComboBox.SelectedIndex == 3) fiyatAzalan();
            else if (filtreComboBox.SelectedIndex == 4) fiyatArtan();
            else if (filtreComboBox.SelectedIndex == 5) gelirGoster();
            else if (filtreComboBox.SelectedIndex == 6) giderGoster();
            else goster();
        }

        private void silButton_MouseEnter(object sender, EventArgs e)
        {
            silButton.BackColor = Color.FromArgb(160, 190, 210);
        }

        private void silButton_MouseLeave(object sender, EventArgs e)
        {
            silButton.BackColor = Color.FromArgb(200, 220, 240);
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            sil();
        }

        private void tarihDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (filtreComboBox.SelectedIndex == 0) secilenTarih();
        }

        void yukle()
        {
            filtreComboBox.Items.Add("Seçilen Tarihe Göre");
            filtreComboBox.Items.Add("Tarih Azalan");
            filtreComboBox.Items.Add("Tarih Artan");
            filtreComboBox.Items.Add("Fiyat Azalan");
            filtreComboBox.Items.Add("Fiyat Artan");
            filtreComboBox.Items.Add("Sadece Gelir");
            filtreComboBox.Items.Add("Sadece Gider");

            gelirGiderDataGridView.BackgroundColor = Color.FromArgb(240, 245, 250);
            gelirGiderDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 245, 250);
            gelirGiderDataGridView.EnableHeadersVisualStyles = false;
            gelirGiderDataGridView.RowHeadersVisible = false;
            gelirGiderDataGridView.ReadOnly = true;
            gelirGiderDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gelirGiderDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            gelirGiderDataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 245, 250);
            gelirGiderDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 235, 245);
            gelirGiderDataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 220, 240);
            gelirGiderDataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 220, 240);
            gelirGiderDataGridView.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
        }

        void hesap()
        {
            string toplamGelirkomut = "SELECT SUM(miktar) FROM gelirGiderTakip WHERE tur = 'Gelir'";
            string toplamGiderkomut = "SELECT SUM(miktar) FROM gelirGiderTakip WHERE tur = 'Gider'";

            connect.Open();

            OleDbCommand cmdGelir = new OleDbCommand(toplamGelirkomut, connect);
            OleDbCommand cmdGider = new OleDbCommand(toplamGiderkomut, connect);

            object gelirSonuc = cmdGelir.ExecuteScalar();
            double toplamGelir = gelirSonuc != DBNull.Value ? Convert.ToDouble(gelirSonuc) : 0;

            object giderSonuc = cmdGider.ExecuteScalar();
            double toplamGider = giderSonuc != DBNull.Value ? Convert.ToDouble(giderSonuc) : 0;

            connect.Close();

            double netkazanc = toplamGelir - toplamGider;

            gelirLabel.Text = gelirSonuc.ToString();
            giderLabel.Text = giderSonuc.ToString();
            karLabel.Text = netkazanc.ToString();
        }

        void sil()
        {
            string kimlik = gelirGiderDataGridView.CurrentRow.Cells[0].Value.ToString();

            string komut = "DELETE FROM gelirGiderTakip WHERE Kimlik=" + kimlik;

            connect.Open();

            OleDbCommand cmd = new OleDbCommand(komut, connect);
            cmd.ExecuteNonQuery();

            connect.Close();
            hesap();
            goster();
        }

        void goster()
        {
            string komut = "SELECT * FROM gelirGiderTakip";
            OleDbCommand cmd = new OleDbCommand(komut, connect);

            connect.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connect.Close();

            gelirGiderDataGridView.DataSource = dt;
            kontrol();
            gelirGiderDataGridView.Columns["Kimlik"].Visible = false;
        }

        void secilenTarih()
        {

            string tarih = tarihDateTimePicker.Value.ToString("yyyy-MM-dd");

            string komut = "SELECT * FROM gelirGiderTakip WHERE tarih = ?";
            OleDbCommand cmd = new OleDbCommand(komut, connect);
            cmd.Parameters.AddWithValue("?", tarihDateTimePicker.Value.Date);

            connect.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connect.Close();

            gelirGiderDataGridView.DataSource = dt;
            gelirGiderDataGridView.Columns["Kimlik"].Visible = false;
        }

        void tarihAzalan()
        {
            string komut = "SELECT * FROM gelirGiderTakip ORDER BY tarih DESC";
            OleDbCommand cmd = new OleDbCommand(komut, connect);

            connect.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connect.Close();

            gelirGiderDataGridView.DataSource = dt;
            gelirGiderDataGridView.Columns["Kimlik"].Visible = false;
        }

        void tarihArtan()
        {
            string komut = "SELECT * FROM gelirGiderTakip ORDER BY tarih ASC";
            OleDbCommand cmd = new OleDbCommand(komut, connect);

            connect.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connect.Close();

            gelirGiderDataGridView.DataSource = dt;
            gelirGiderDataGridView.Columns["Kimlik"].Visible = false;
        }

        void fiyatAzalan()
        {
            string komut = "SELECT * FROM gelirGiderTakip ORDER BY miktar DESC";
            OleDbCommand cmd = new OleDbCommand(komut, connect);

            connect.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connect.Close();

            gelirGiderDataGridView.DataSource = dt;
            gelirGiderDataGridView.Columns["Kimlik"].Visible = false;
        }

        void fiyatArtan()
        {
            string komut = "SELECT * FROM gelirGiderTakip ORDER BY miktar ASC";
            OleDbCommand cmd = new OleDbCommand(komut, connect);

            connect.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connect.Close();

            gelirGiderDataGridView.DataSource = dt;
            gelirGiderDataGridView.Columns["Kimlik"].Visible = false;

        }

        void gelirGoster()
        {
            string komut = "SELECT * FROM gelirGiderTakip WHERE tur='Gelir'";
            OleDbCommand cmd = new OleDbCommand(komut, connect);

            connect.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connect.Close();

            gelirGiderDataGridView.DataSource = dt;
            gelirGiderDataGridView.Columns["Kimlik"].Visible = false;
        }

        void giderGoster()
        {
            string komut = "SELECT * FROM gelirGiderTakip WHERE tur='Gider'";
            OleDbCommand cmd = new OleDbCommand(komut, connect);

            connect.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connect.Close();

            gelirGiderDataGridView.DataSource = dt;
            gelirGiderDataGridView.Columns["Kimlik"].Visible = false;
        }

        void kontrol()
        {
            if (gelirGiderDataGridView != null && gelirGiderDataGridView.Columns.Count > 0)
            {
                if (gelirGiderDataGridView.Columns.Contains("tarih")) gelirGiderDataGridView.Columns["tarih"].HeaderText = "Tarih";
                if (gelirGiderDataGridView.Columns.Contains("tur")) gelirGiderDataGridView.Columns["tur"].HeaderText = "Tür";
                if (gelirGiderDataGridView.Columns.Contains("kategori")) gelirGiderDataGridView.Columns["kategori"].HeaderText = "Kategori";
                if (gelirGiderDataGridView.Columns.Contains("miktar")) gelirGiderDataGridView.Columns["miktar"].HeaderText = "Miktar";
                if (gelirGiderDataGridView.Columns.Contains("aciklama")) gelirGiderDataGridView.Columns["aciklama"].HeaderText = "Açıklama";
            }
            else MessageBox.Show("DataGridView başlatılmadı veya sütunları yok.");
        }
    }
}
