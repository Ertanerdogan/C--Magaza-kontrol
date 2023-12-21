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
    public partial class Form1 : Form
    {
        //Data Source=ERTAN\SQLEXPRESS;Initial Catalog=DbYeni;Integrated Security=True

        string kullanici = "admin123";
        string sifre = "ertan123";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gold;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Khaki;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Gold;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Khaki;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(kullanici == TxtKullanici.Text && sifre == TxtSifre.Text)
            {
                yonlendir ekran = new yonlendir();
                ekran.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tekrar deneyin !");
            }
        }
    }
}
