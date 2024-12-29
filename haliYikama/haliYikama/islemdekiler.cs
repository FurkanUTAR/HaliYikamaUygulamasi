using System;
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
    public partial class islemdekiler : Form
    {

        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");

        public islemdekiler()
        {
            InitializeComponent();
        }

        private void geriDonPictureBox_Click(object sender, EventArgs e)
        {
            anaSayfa anaSayfa = new anaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void islemdekiler_Load(object sender, EventArgs e)
        {
            goster();
        }

        private void islemdekilerDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            kontrol();
        }

        void kontrol()
        {
            var cellValue = islemdekilerDataGridView.CurrentRow.Cells[0].Value;
            if (cellValue != null && int.TryParse(cellValue.ToString(), out int siparisNo))
            {
                siparisDetay siparisDetay = new siparisDetay();
                siparisDetay.siparisNo = siparisNo;
                siparisDetay.Show();
                this.Hide();
            }
            else MessageBox.Show("Seçilen kaydın Sipariş Numarası geçerli bir sayı değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void goster()
        {
            string komut = "SELECT * FROM siparisler WHERE siparisDurum='Islemde'";

            connect.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            islemdekilerDataGridView.DataSource = dt;

            connect.Close();

            islemdekilerDataGridView.Columns["siparisNotu"].Visible = false;
            islemdekilerDataGridView.Columns["siparisDurum"].Visible = false;
            islemdekilerDataGridView.Columns["teslimTarih"].Visible = false;
            islemdekilerDataGridView.Columns["veresiyeTutar"].Visible = false;
        }
    }
}
