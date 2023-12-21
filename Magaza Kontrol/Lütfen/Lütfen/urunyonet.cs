using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lütfen
{
    public partial class urunyonet : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source = ERTAN\SQLEXPRESS; Initial Catalog = DbYeni; Integrated Security = True");
        public urunyonet()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.DataTable1TableAdapter dataset = new DataSet1TableAdapters.DataTable1TableAdapter();
        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.ValueMember = "KategoriID";
            comboBox1.DisplayMember = "KategoriAd";
            SqlCommand komut = new SqlCommand("SELECT * FROM TblKategori",baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            dataGridView1.DataSource = dataset.UrunListele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                TxtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                TxtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtAlis.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                TxtSatis.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                TxtStok.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
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

        private void BtnGüncelle_MouseEnter(object sender, EventArgs e)
        {
            BtnGüncelle.BackColor = Color.Gold;
        }

        private void BtnGüncelle_MouseLeave(object sender, EventArgs e)
        {
            BtnGüncelle.BackColor = Color.Khaki;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gold;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
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
            dataGridView1.DataSource = dataset.UrunListele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            DialogResult a =  MessageBox.Show("Ürünü eklemek istediğinize emin misiniz ?","Soru",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(a == DialogResult.Yes)
            {
                dataset.UrunEkle(TxtAd.Text, decimal.Parse(TxtAlis.Text), decimal.Parse(TxtSatis.Text), int.Parse(TxtStok.Text), int.Parse(comboBox1.SelectedValue.ToString()));
                MessageBox.Show("Ürün başarıyla eklendi !");
            }
            else if(a == DialogResult.No)
            {
                MessageBox.Show("Hiçbir ürün eklenmedi !");
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult b = MessageBox.Show("Ürünü silmek istediğinize emin misiniz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (b == DialogResult.Yes)
            {
                dataset.UrunSil(int.Parse(TxtID.Text));
                MessageBox.Show("Ürün başarıyla silindi !");
            }
            else if(b == DialogResult.No)
            {
                MessageBox.Show("Hiçbir ürün silinmedi !");
            }

        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            DialogResult c = MessageBox.Show("Ürünü güncellemek istediğinize emin misiniz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (c == DialogResult.Yes)
            {
                dataset.UrunGuncelle(TxtAd.Text, decimal.Parse(TxtAlis.Text), decimal.Parse(TxtSatis.Text), int.Parse(TxtStok.Text), int.Parse(comboBox1.SelectedValue.ToString()),int.Parse(TxtID.Text));
                MessageBox.Show("Ürün başarıyla güncellendi !");
            }
            else if (c == DialogResult.No)
            {
                MessageBox.Show("Hiçbir ürün güncellenmedi !");
            }
        }
    }
}
