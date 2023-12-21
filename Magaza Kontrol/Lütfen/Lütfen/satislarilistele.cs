using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lütfen
{
    public partial class satislarilistele : Form
    {
        DataSet1TableAdapters.DataTable2TableAdapter da = new DataSet1TableAdapters.DataTable2TableAdapter();
        public satislarilistele()
        {
            InitializeComponent();
        }

        private void satislarilistele_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = da.SatisListele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TxtID.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                TxtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                TxtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtUrun.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                TxtFiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void BtnYenile_MouseEnter(object sender, EventArgs e)
        {
            BtnYenile.BackColor = Color.Gold;
        }

        private void BtnYenile_MouseLeave(object sender, EventArgs e)
        {
            BtnYenile.BackColor = Color.Khaki;
        }


        private void BtnSil_MouseEnter(object sender, EventArgs e)
        {
            BtnSil.BackColor = Color.Gold;
        }

        private void BtnSil_MouseLeave(object sender, EventArgs e)
        {
            BtnSil.BackColor = Color.Khaki;
        }

        private void BtnYenile_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = da.SatisListele();
        }

        private void BtnGeri_MouseEnter(object sender, EventArgs e)
        {
            BtnGeri.BackColor = Color.Gold;
        }

        private void BtnGeri_MouseLeave(object sender, EventArgs e)
        {
            BtnGeri.BackColor = Color.Khaki;
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            yonlendir ekran = new yonlendir();
            ekran.Show();
            this.Dispose();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Satışı silmek istediğinize emin misiniz ?","Soru",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                da.SatisSil(int.Parse(TxtID.Text));
                MessageBox.Show("Satış başarıyla silindi");
            }
            else if(a == DialogResult.No)
            {
                MessageBox.Show("Hiçbir satış silinmedi");
            }

        }

        private void BtnAra_MouseEnter(object sender, EventArgs e)
        {
            BtnAra.BackColor = Color.Gold;
        }

        private void BtnAra_MouseLeave(object sender, EventArgs e)
        {
            BtnAra.BackColor = Color.Khaki;
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            if (RdbAd.Checked == true)
            {
                dataGridView1.DataSource = da.SatisAdListele(TxtAra.Text);
            }
            else if (RdbUrun.Checked == true)
            {
                dataGridView1.DataSource = da.SatisUrunListele(TxtAra.Text);
            }
            else
            {
                MessageBox.Show("Lütfen bir arama kriteri seçiniz");
            }
        }
    }
}
