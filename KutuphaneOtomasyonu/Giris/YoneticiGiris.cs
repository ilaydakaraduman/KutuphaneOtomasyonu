using KutuphaneOtomasyonu.YoneticiBilgi;
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
    public partial class YoneticiGiris : Form
    {
        yoneticiKod yoneticiKod = new yoneticiKod();
        List<Yonetici> yoneticiler = new List<Yonetici>();
        public YoneticiGiris()
        {
            InitializeComponent();
        }
        public void GirisYap()
        {
            yoneticiler = yoneticiKod.GetAll();
            bool eslestiMi = false;
            foreach (var yonetici in yoneticiler)
            {
                if (tbxSifre.Text == yonetici.YoneticiSifre && tbxTc.Text == yonetici.YoneticiTc)
                {
                    eslestiMi = true;
                    yoneticiIslem yoneticigir = new yoneticiIslem();
                    this.Hide();
                    yoneticigir.Show();
                }
            }
            if (eslestiMi == false)
            {
                MessageBox.Show("Girdiğiniz bilgilere ait yonetici bulunamadı");
            }
        }


        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        AnaGiris ana = new AnaGiris();
        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ana.Show();
        }

        private void btnGirisi_Click(object sender, EventArgs e)
        {
            GirisYap();

        }

        private void YoneticiGiris_Load(object sender, EventArgs e)
        {
            tbxSifre.PasswordChar = '*';
        }
    }
}
