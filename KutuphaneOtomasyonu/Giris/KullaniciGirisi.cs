using KutuphaneOtomasyonu.AlinanKitapBilgi;
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

namespace KutuphaneOtomasyonu.Giris
{
    public partial class KullaniciGirisi : Form
    {
        KullaniciKod kullaniciKod = new KullaniciKod();
        List<Kullanici> kullanicilar = new List<Kullanici>();
        public KullaniciGirisi()
        {
            InitializeComponent();
        }

        private void KullaniciGirisi_Load(object sender, EventArgs e)
        {
            kullanicilar = kullaniciKod.GetAll();
            tbxSifre.PasswordChar = '*';
        }
        public void GirisYap()
        {
            bool eslestiMi = false;
            foreach (var kullanici in kullanicilar)
            {
                if(tbxSifre.Text == kullanici.KullaniciSifre && tbxTc.Text == kullanici.KullaniciTc)
                {
                    eslestiMi = true;
                    KullaniciIslem kullaniciIslem = new KullaniciIslem();
                    kullaniciIslem.kullaniciTc = tbxTc.Text;
                    kullaniciIslem.Show();
                    this.Hide();
                }
            }
            if(eslestiMi==false)
            {
                MessageBox.Show("Girdiğiniz bilgilere ait kullanıcı bulunamadı");
            }
        }

     

        private void btnGirisi_Click(object sender, EventArgs e)
        {
            GirisYap();
        }

      

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        AnaGiris ana = new AnaGiris();
        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ana.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

       
    }
}
