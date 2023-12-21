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
    public partial class kategoriyonet : Form
    {
        public kategoriyonet()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.TblKategoriTableAdapter da = new DataSet1TableAdapters.TblKategoriTableAdapter();
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

        private void BtnGeri_MouseEnter(object sender, EventArgs e)
        {
            BtnGeri.BackColor = Color.Gold;
        }

        private void BtnGeri_MouseLeave(object sender, EventArgs e)
        {
            BtnGeri.BackColor = Color.Khaki;
        }

        private void BtnYenile_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = da.KategoriListele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Kategori eklemek istediğinize emin misiniz ?","Soru",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (a == DialogResult.Yes)
            {
                da.KategoriEkle(TxtAd.Text);
                MessageBox.Show("Kategori başarıyla eklendi");
            }
            else if(a == DialogResult.No)
            {
                MessageBox.Show("Hiçbir kategori eklenmedi");
            }
        }

        private void kategoriyonet_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = da.KategoriListele();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            yonlendir ekran = new yonlendir();
            ekran.Show();
            this.Dispose();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                TxtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                TxtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtUrun.Text = da.UrunKategoriSay(int.Parse(TxtID.Text)).ToString();
            }
            
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            TxtUrun.Text = da.UrunKategoriSay(int.Parse(TxtID.Text)).ToString();
            if(int.Parse(TxtUrun.Text) == 0)
            {
                DialogResult b = MessageBox.Show("Kategoriyi silmek istediğinize emin misiniz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(b == DialogResult.Yes)
                {
                    da.KategoriSil(int.Parse(TxtID.Text), TxtAd.Text);
                    MessageBox.Show("Kategori başarıyla silindi");
                }
                else if(b == DialogResult.No)
                {
                    MessageBox.Show("Hiçbir ürün silinmedi");
                }
            }
            else if(int.Parse(TxtUrun.Text) > 0)
            {
                MessageBox.Show("Bu kategoride bir ürün olduğun için silemezsin");
            }
            
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult c = MessageBox.Show("Kategoriyi guncellemek istediğinize emin misiniz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (c == DialogResult.Yes)
            {
                da.KategoriGuncelle(TxtAd.Text,int.Parse(TxtID.Text));
                MessageBox.Show("Kategori başarıyla güncellendi");
            }
            else if (c == DialogResult.No)
            {
                MessageBox.Show("Hiçbir ürün güncellenmedi");
            }
        }
    }
}
