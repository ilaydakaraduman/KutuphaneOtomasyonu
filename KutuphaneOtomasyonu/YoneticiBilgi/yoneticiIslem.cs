using KutuphaneOtomasyonu.Giris;
using KutuphaneOtomasyonu.KitapBilgi;
using KutuphaneOtomasyonu.KullaniciBilgi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.YoneticiBilgi
{
    public partial class yoneticiIslem : Form
    {
        public yoneticiIslem()
        {
            InitializeComponent();
        }

       
        private void btnKullanici_Click(object sender, EventArgs e)
        {
            KullaniciBilgi.KullaniciBilgi Kullanici = new KullaniciBilgi.KullaniciBilgi();

            this.Hide();
            Kullanici.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YoneticiEkle Yonetici = new YoneticiEkle();

            this.Hide();
            Yonetici.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KitapKayit kayit = new KitapKayit();

            this.Hide();
            kayit.Show();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            YoneticiGiris giris = new YoneticiGiris();

            this.Hide();
            giris.Show();

        }

        private void label17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
