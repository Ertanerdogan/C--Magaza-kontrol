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
    public partial class musteriyonet : Form
    {
        public musteriyonet()
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

        private void BtnEkle_MouseEnter(object sender, EventArgs e)
        {
            BtnEkle.BackColor = Color.Gold;
        }

        private void BtnEkle_MouseLeave(object sender, EventArgs e)
        {
            BtnEkle.BackColor = Color.Khaki;
        }

        private void BtnSil_MouseEnter(object sender, EventArgs e)
        {
            BtnSil.BackColor = Color.Gold;
        }

        private void BtnSil_MouseLeave(object sender, EventArgs e)
        {
            BtnSil.BackColor = Color.Khaki;
        }

        private void BtnGuncelle_MouseEnter(object sender, EventArgs e)
        {
            BtnGuncelle.BackColor = Color.Gold;
        }

        private void BtnGuncelle_MouseLeave(object sender, EventArgs e)
        {
            BtnGuncelle.BackColor = Color.Khaki;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gold;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Khaki;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yonlendir ekran = new yonlendir();
            ekran.Show();
            this.Dispose();
        }

        private void BtnYenile_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = da.MusteriListele();
        }

        private void musteriyonet_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = da.MusteriListele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Müşteriyi eklemek istediğinize emin misiniz ?","Soru",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                da.MusteriEkle(TxtAd.Text,TxtSoyad.Text,TxtSehir.Text,decimal.Parse(TxtBakiye.Text));
                MessageBox.Show("Başarıyla eklendi");
            }
            else if(a == DialogResult.No)
            {
                MessageBox.Show("Hiçbir üye eklenmedi");
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult b = MessageBox.Show("Müşteriyi silmek istediğinize emin misiniz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (b == DialogResult.Yes)
            {
                da.MusteriSil(int.Parse(TxtID.Text));
                MessageBox.Show("Başarıyla silindi");
            }
            else if (b == DialogResult.No)
            {
                MessageBox.Show("Hiçbir üye silinmedi");
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult c = MessageBox.Show("Müşterinin bilgilerini güncellemek istediğinize emin misiniz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (c == DialogResult.Yes)
            {
                da.MusteriGuncelle(TxtAd.Text, TxtSoyad.Text, TxtSehir.Text, decimal.Parse(TxtBakiye.Text),int.Parse(TxtID.Text));
                MessageBox.Show("Başarıyla güncellendi");
            }
            else if (c == DialogResult.No)
            {
                MessageBox.Show("Hiçbir üye güncellenmedi");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
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
