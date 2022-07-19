using KutuphaneOtomasyonu.YoneticiBilgi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.KullaniciBilgi
{
    public partial class KullaniciBilgi : Form
    {
        int kullaniciId;
        KullaniciKod kullaniciKod = new KullaniciKod();
        string ResimYer = "";
        string ResimDestination = "";
        string Path = "";
        string directory = AppDomain.CurrentDomain.BaseDirectory;
        public string dgwTc;
        bool ResimSecildiMi;
        yoneticiIslem yonetici = new yoneticiIslem();
        Regex regex = new Regex(@"^(\d{11,11}$)");

        public KullaniciBilgi()
        {
            InitializeComponent();
        }

        private void KullaniciBilgi_Load(object sender, EventArgs e)
        {
            Path = directory + @"KullaniciResim\";
            kullanicilariDoldur();
        }
        public void kullanicilariDoldur()
        {
            dgwKullanici.DataSource = kullaniciKod.GetAll();
        }

        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string kontrol = " ";
            if (checkCeza.Checked.ToString()=="True")
            {
                kontrol = "Evet";
            }
            else
            {
                kontrol = "Hayır";
            }
            if (regex.Match(tbxTc.Text).Success)
            {
               
                if (MessageBox.Show("Kullanıcının bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    kullaniciKod.Add(new Kullanici
                    {
                        KullaniciAd = tbxAd.Text,
                        KullaniciSoyad = tbxSoyad.Text,
                        KullaniciTc = tbxTc.Text,
                        KullaniciSifre = tbxSifre.Text,
                        CezaDurumu = Convert.ToDecimal(tbxCeza.Text),
                        CezaOdendiMi = kontrol,
                        KullaniciCinsiyet = cbxCinsiyet.SelectedItem.ToString(),
                        KullaniciDogumTarihi = tbxDogumTarihi.Text,

                    });
                    ResimSec();
                    MessageBox.Show("Kullanıcı Sistemimize Başarıyla Eklenmiştir");
                }
                kullanicilariDoldur();
            }
            else
            {
                MessageBox.Show("Girdiğiniz tc uygun değildir"); 
            }
           
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            kullaniciKod.Delete(kullaniciId);
            kullanicilariDoldur();
        }

        private void dgwKullanici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kullaniciId = Convert.ToInt32( dgwKullanici.CurrentRow.Cells[0].Value);
            tbxAd.Text = dgwKullanici.CurrentRow.Cells[1].Value.ToString();
            tbxSoyad.Text = dgwKullanici.CurrentRow.Cells[2].Value.ToString();
            cbxCinsiyet.SelectedItem = dgwKullanici.CurrentRow.Cells[6].Value.ToString();
            tbxDogumTarihi.Text = dgwKullanici.CurrentRow.Cells[5].Value.ToString();
            tbxSifre.Text = dgwKullanici.CurrentRow.Cells[4].Value.ToString();
            tbxTc.Text = dgwKullanici.CurrentRow.Cells[3].Value.ToString();
            tbxCeza.Text = dgwKullanici.CurrentRow.Cells[7].Value.ToString();
            checkCeza.Checked = ChegDegitir();
            pcbKullanici.ImageLocation = Path + dgwKullanici.CurrentRow.Cells[3].Value.ToString() + ".jpg";
        }
        bool ChegDegitir()
        {

            if (dgwKullanici.CurrentRow.Cells[8].Value.ToString()=="Evet")
            {
                return true;
            }
            return false;

        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (regex.Match(tbxTc.Text).Success)
            {
                if (MessageBox.Show("Kullanıcının bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    kullaniciKod.Update(new Kullanici
                    {
                        KullaniciAd = tbxAd.Text,
                        KullaniciSoyad = tbxSoyad.Text,
                        KullaniciId = kullaniciId,
                        KullaniciCinsiyet = cbxCinsiyet.SelectedItem.ToString(),
                        KullaniciDogumTarihi = tbxDogumTarihi.Text,
                        KullaniciSifre = tbxSifre.Text,
                        KullaniciTc = tbxTc.Text,
                        CezaDurumu = Convert.ToDecimal(tbxCeza.Text),
                        CezaOdendiMi = checkCeza.Checked.ToString()

                    });
                    if (ResimSecildiMi)
                    {
                        File.Delete(Path + tbxTc.Text + ".jpg");
                        ResimSec(tbxTc.Text);
                    }
                    MessageBox.Show("Kullanıcı Sistemimize Başarıyla Güncellenmiştir..");
                    kullanicilariDoldur();

                }
            }
            else
            {
                MessageBox.Show("Tc sisteme uygun değildir");
                   
            }
           
        }
        public void ResimSec(string resim)
        {
            ResimDestination = Path + resim + ".jpg";
            File.Copy(ResimYer, ResimDestination);

        }
        public void ResimSec()
        {
            string resim = tbxTc.Text;
            ResimDestination = Path + resim + ".jpg";
            File.Copy(ResimYer, ResimDestination);


        }


        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            yonetici.Show();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            yonetici.Show();
           
        }

        private void tbxArama_TextChanged(object sender, EventArgs e)
        {
            dgwKullanici.DataSource = kullaniciKod.Search(tbxArama.Text);
        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();

                dialog.Filter = "Image Files(*.JPG;)|*.JPG;";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    ResimYer = dialog.FileName;
                    pcbKullanici.ImageLocation = ResimYer;

                }

            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResimGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files(*.JPG;)|*.JPG;";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ResimSecildiMi = true;
                    ResimYer = dialog.FileName;
                    pcbKullanici.ImageLocation = ResimYer;

                }

            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
