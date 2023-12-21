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
    public partial class musterilistele : Form
    {
        public musterilistele()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.TblMusterilerTableAdapter da = new DataSet1TableAdapters.TblMusterilerTableAdapter();

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

        private void musterilistele_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = da.MusteriListele();
        }

        private void BtnYenile_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = da.MusteriListele();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            if(RdbAd.Checked == true)
            {
                dataGridView1.DataSource = da.MusteriAdListele(TxtAra.Text);
            }
            else if(RdbSehir.Checked == true)
            {
                dataGridView1.DataSource = da.MusteriSehirListele(TxtAra.Text);
            }
            else
            {
                MessageBox.Show("Lütfen bir arama kriteri seçiniz");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                TxtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                TxtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                TxtSehir.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                TxtBakiye.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            
        }
    }
}
