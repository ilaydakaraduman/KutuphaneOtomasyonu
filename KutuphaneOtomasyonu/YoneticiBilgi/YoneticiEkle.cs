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

namespace KutuphaneOtomasyonu.YoneticiBilgi
{
    public partial class YoneticiEkle : Form
    {
        public YoneticiEkle()
        {
            InitializeComponent();
        }

        yoneticiIslem yonetici = new yoneticiIslem();
        int YoneticiId;
        string ResimYer = "";
        string ResimDestination = "";
        string Path = "";
        string directory = AppDomain.CurrentDomain.BaseDirectory;
        public string dgwTc;
        bool ResimSecildiMi;
        Regex regex = new Regex(@"^(\d{11,11}$)");
        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            yonetici.Show();
        }

        yoneticiKod _yonetici = new yoneticiKod();

        void YoneticiDoldur()
        {
            dgwYonetici.DataSource = _yonetici.GetAll();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (regex.Match(tbxTc.Text).Success)
            {
                if (MessageBox.Show("Çalışanın bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _yonetici.Add(new Yonetici
                    {
                        YoneticiAd = tbxAd.Text,
                        YoneticiSoyad = tbxSoyad.Text,
                        YoneticiTc = tbxTc.Text,
                        YoneticiSifre = tbxSifre.Text,
                        Cinsiyet = cbxCinsiyet.SelectedItem.ToString(),
                        DogumTarihi = tbxDogumTarihi.Text,

                    });
                    ResimSec();
                    MessageBox.Show("Çalışan Sistemimize Başarıyla Eklenmiştir..");
                    YoneticiDoldur();

                }

            }
            else
            {
                MessageBox.Show("Uygun olmayan bir tc girdiniz yeniden deneyin");      
            }



        }

        private void YoneticiEkle_Load(object sender, EventArgs e)
        {
            Path = directory + @"YoneticiResim\";
            YoneticiDoldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _yonetici.Delete(YoneticiId);
            YoneticiDoldur();
        }

        private void dgwYonetici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            YoneticiId = Convert.ToInt32(dgwYonetici.CurrentRow.Cells[0].Value);
            tbxAd.Text = dgwYonetici.CurrentRow.Cells[1].Value.ToString();
            tbxSoyad.Text = dgwYonetici.CurrentRow.Cells[2].Value.ToString();
            cbxCinsiyet.SelectedItem = dgwYonetici.CurrentRow.Cells[5].Value.ToString();
            tbxDogumTarihi.Text = dgwYonetici.CurrentRow.Cells[6].Value.ToString();
            tbxSifre.Text = dgwYonetici.CurrentRow.Cells[4].Value.ToString();
            tbxTc.Text = dgwYonetici.CurrentRow.Cells[3].Value.ToString();
            pcbKullanici.ImageLocation = Path + dgwYonetici.CurrentRow.Cells[3].Value.ToString() + ".jpg";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            yonetici.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void tbxArama_TextChanged(object sender, EventArgs e)
        {
            dgwYonetici.DataSource = _yonetici.Search(tbxArama.Text);
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (regex.Match(tbxTc.Text).Success)
            {
                if (MessageBox.Show("Çalışanın bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _yonetici.Update(new Yonetici
                    {
                        YoneticiId = YoneticiId,
                        YoneticiAd = tbxAd.Text,
                        YoneticiSoyad = tbxSoyad.Text,
                        YoneticiTc = tbxTc.Text,
                        YoneticiSifre = tbxSifre.Text,
                        Cinsiyet = cbxCinsiyet.SelectedItem.ToString(),
                        DogumTarihi = tbxDogumTarihi.Text,
                    }) ;
                    if (ResimSecildiMi)
                    {
                        File.Delete(Path + tbxTc.Text + ".jpg");
                        ResimSec(tbxTc.Text);
                    }
                    MessageBox.Show("Çalışan Sistemimize Başarıyla Güncellenmiştir..");
                    YoneticiDoldur();
                }
            }
            else
            {
                MessageBox.Show("Uygun olmayan bir tc girdiniz yeniden deneyin");
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

        private void tbxAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxlarıBosalt();
        }
        public void textBoxlarıBosalt()
        {

            tbxAd.Text = "";
            tbxSoyad.Text = "";
            tbxTc.Text = "";
            tbxSifre.Text = "";
            tbxDogumTarihi.Text = "";

        }
    }
}
