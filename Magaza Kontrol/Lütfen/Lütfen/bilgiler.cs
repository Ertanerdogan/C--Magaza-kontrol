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
    public partial class bilgiler : Form
    {
        DataSet1TableAdapters.DataTable1TableAdapter urunler = new  DataSet1TableAdapters.DataTable1TableAdapter();
        DataSet1TableAdapters.TblKategoriTableAdapter kategoriler = new DataSet1TableAdapters.TblKategoriTableAdapter();
        DataSet1TableAdapters.TblMusterilerTableAdapter musteriler = new DataSet1TableAdapters.TblMusterilerTableAdapter();
        public bilgiler()
        {
            InitializeComponent();
        }

        private void bilgiler_Load(object sender, EventArgs e)
        {
            urunsayi.Text = urunler.ToplamUrunSayisi().ToString();
            kategorisayisi.Text = kategoriler.ToplamKategoriSayisi().ToString();
            müsterisayisi.Text = musteriler.ToplamMusteriSayisi().ToString();
            stoksayisi.Text = urunler.ToplamStokSayisi().ToString();
            karsayisi.Text = urunler.ToplamKar().ToString();
            enazstok.Text = urunler.EnAzStok().ToString();
            encokstok.Text = urunler.EnCokStok().ToString();
            enkaryapanurun.Text = urunler.EnCokKarYapanUrun().ToString();
            enazkaryapanurun.Text = urunler.EnAzKarYapanUrun().ToString();
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
    }
}
