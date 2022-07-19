using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Giris
{
    public partial class AnaGiris : Form
    {
        public AnaGiris()
        {
            InitializeComponent();
        }

        private void Lbl_Click(object sender, EventArgs e)
        {
            KullaniciGirisi Kullanici = new KullaniciGirisi();

            this.Hide();
            Kullanici.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            YoneticiGiris yonetici = new YoneticiGiris();

            this.Hide();
            yonetici.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void AnaGiris_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
