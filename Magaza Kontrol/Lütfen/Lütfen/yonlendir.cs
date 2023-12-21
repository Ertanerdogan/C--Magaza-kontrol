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
    public partial class yonlendir : Form
    {
        public yonlendir()
        {
            InitializeComponent();
        }

        private void BtnUrunListele_MouseEnter(object sender, EventArgs e)
        {
            BtnUrunListele.BackColor = Color.Gold;
        }

        private void BtnUrunListele_MouseLeave(object sender, EventArgs e)
        {
            BtnUrunListele.BackColor = Color.Khaki;
        }

        private void BtnUrunYonet_MouseEnter(object sender, EventArgs e)
        {
            BtnUrunYonet.BackColor = Color.Gold;
        }

        private void BtnUrunYonet_MouseLeave(object sender, EventArgs e)
        {
            BtnUrunYonet.BackColor= Color.Khaki;
        }

        private void BtnKategoriListele_MouseEnter(object sender, EventArgs e)
        {
            BtnKategoriListele.BackColor = Color.Gold;
        }

        private void BtnKategoriListele_MouseLeave(object sender, EventArgs e)
        {
            BtnKategoriListele.BackColor = Color.Khaki;
        }

        private void BtnKategoriYonet_MouseEnter(object sender, EventArgs e)
        {
            BtnKategoriYonet.BackColor = Color.Gold;
        }

        private void BtnKategoriYonet_MouseLeave(object sender, EventArgs e)
        {
            BtnKategoriYonet.BackColor = Color.Khaki;
        }

        private void BtnUrunListele_Click(object sender, EventArgs e)
        {
            urunlistele ekran = new urunlistele();
            ekran.Show();
            this.Dispose();
        }

        private void BtnUrunYonet_Click(object sender, EventArgs e)
        {
            urunyonet ekran = new urunyonet();
            ekran.Show();
            this.Dispose();
        }

        private void BtnKategoriListele_Click(object sender, EventArgs e)
        {
            kategorilistele ekran = new kategorilistele();
            ekran.Show();
            this.Dispose();
        }

        private void BtnKategoriYonet_Click(object sender, EventArgs e)
        {
            kategoriyonet ekran = new kategoriyonet();
            ekran.Show();
            this.Dispose();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnCikis_MouseEnter(object sender, EventArgs e)
        {
            BtnCikis.BackColor = Color.Gold;
        }

        private void BtnCikis_MouseLeave(object sender, EventArgs e)
        {
            BtnCikis.BackColor = Color.Khaki;
        }

        private void BtnMusteriListele_MouseEnter(object sender, EventArgs e)
        {
            BtnMusteriListele.BackColor = Color.Gold;
        }

        private void BtnMusteriListele_MouseLeave(object sender, EventArgs e)
        {
            BtnMusteriListele.BackColor = Color.Khaki;
        }

        private void BtnMusteriYonet_MouseEnter(object sender, EventArgs e)
        {
            BtnMusteriYonet.BackColor = Color.Gold;
        }

        private void BtnMusteriYonet_MouseLeave(object sender, EventArgs e)
        {
            BtnMusteriYonet.BackColor = Color.Khaki;
        }

        private void BtnMusteriListele_Click(object sender, EventArgs e)
        {
            musterilistele ekran = new musterilistele();
            ekran.Show();
            this.Dispose();
        }

        private void BtnMusteriYonet_Click(object sender, EventArgs e)
        {
            musteriyonet ekran = new musteriyonet();
            ekran.Show();
            this.Dispose();
        }

        private void BtnSatislariListele_MouseEnter(object sender, EventArgs e)
        {
            BtnSatislariListele.BackColor = Color.Gold;
        }

        private void BtnSatislariListele_MouseLeave(object sender, EventArgs e)
        {
            BtnSatislariListele.BackColor = Color.Khaki;
        }

        private void BtnSatislariListele_Click(object sender, EventArgs e)
        {
            satislarilistele ekran = new satislarilistele();
            ekran.Show();
            this.Dispose();
        }

        private void BtnBilgiler_Click(object sender, EventArgs e)
        {
            bilgiler ekran = new bilgiler();
            ekran.Show();
            this.Dispose();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            Form1 ekran = new Form1();
            ekran.Show();
            this.Dispose();
        }

        private void BtnAdmin_MouseEnter(object sender, EventArgs e)
        {
            BtnAdmin.BackColor = Color.Gold;
        }

        private void BtnAdmin_MouseLeave(object sender, EventArgs e)
        {
            BtnAdmin.BackColor = Color.Khaki;
        }
    }
}
