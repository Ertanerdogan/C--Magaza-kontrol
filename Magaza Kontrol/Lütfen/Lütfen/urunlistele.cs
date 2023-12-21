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
    public partial class urunlistele : Form
    {
        public urunlistele()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.DataTable1TableAdapter da = new DataSet1TableAdapters.DataTable1TableAdapter();
        private void BtnYenile_MouseEnter(object sender, EventArgs e)
        {
            BtnYenile.BackColor = Color.Gold;
        }

        private void BtnYenile_MouseLeave(object sender, EventArgs e)
        {
            BtnYenile.BackColor = Color.Khaki;
        }

        private void BtnGeri_MouseEnter(object sender, EventArgs e)
        {
            BtnGeri.BackColor = Color.Gold;
        }

        private void BtnGeri_MouseLeave(object sender, EventArgs e)
        {
            BtnGeri.BackColor = Color.Khaki;
        }

        private void urunlistele_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = da.UrunListele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TxtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                TxtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtAlis.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                TxtSatis.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                TxtStok.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                TxtKategori.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            
        }

        private void BtnYenile_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = da.UrunListele();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            yonlendir ekran = new yonlendir();
            ekran.Show();
            this.Dispose();
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
            if (RdbID.Checked == true)
            {
                dataGridView1.DataSource = da.IDListele(int.Parse(TxtAra.Text));
            }
            else if (RdbKategori.Checked == true) 
            {
                dataGridView1.DataSource = da.KategoriListele(TxtAra.Text);
            }
            else
            {
                MessageBox.Show("Lütfen bir arama türü seçiniz");
            }




        }
    }
}
