using KutuphaneOtomasyonu.Giris;
using KutuphaneOtomasyonu.KitapBilgi;
using KutuphaneOtomasyonu.KullaniciBilgi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.AlinanKitapBilgi
{
    public partial class KullaniciIslem : Form
    {
        public string kullaniciTc;
        int kitapId;
        decimal cezaMiktar;
        KitapKod kitapKod = new KitapKod();
        AlinanKitapKod alinanKitapKod = new AlinanKitapKod();
        KullaniciKod kullaniciKod = new KullaniciKod();
        List<Kullanici> kullanicilar = new List<Kullanici>();
        List<Kitap> kitaplar = new List<Kitap>();
        List<AlinanKitap> alinanKitaplar = new List<AlinanKitap>();
        List<AlinanKitap> alinanKitaplarHepsi = new List<AlinanKitap>();
        Kullanici kullanici = new Kullanici();
        string Path = "";
        string directory = AppDomain.CurrentDomain.BaseDirectory;


        public KullaniciIslem()
        {
            InitializeComponent();
        }

        private void KullaniciIslem_Load(object sender, EventArgs e)
        {
            kullanicilar = kullaniciKod.GetAll();
            KullaniciTut();
            ResimDoldur();
            lblCezaMiktar.Text = kullanici.CezaDurumu.ToString();
            teslimTarihpick.Value = alimTarihpick.Value.AddDays(15);
            kitaplar = kitapKod.GetAll();
            KitaplariDoldur();
            AlinanKitapListGuncelle();
            AlinanKitapDoldur();
            KullaniciGoruntule();


        }
        void ResimDoldur()
        {
            Path = directory + @"KullaniciResim\";
            pcbResim.ImageLocation = Path + kullanici.KullaniciTc.ToString() + ".jpg";

        }
       
        public void AlinanKitapDoldur()
        {
            dgwAlinan.DataSource = alinanKitaplar;
        }
        public void AlinanKitapListGuncelle()
        {
            alinanKitaplar = alinanKitapKod.GetPersonalBooks(kullanici.KullaniciTc);
        }
        public void KitaplariDoldur()
        {
            dgwKitaplar.DataSource = kitapKod.GetAll();
        }
        public void KullaniciTut()
        {
            foreach (var kullanici in kullanicilar)
            {
                if(kullanici.KullaniciTc == this.kullaniciTc)
                {
                    this.kullanici = kullanici;
                }
            }
        }

        private void alimTarihpick_ValueChanged(object sender, EventArgs e)
        {
            
            if (DateTime.Compare( alimTarihpick.Value, DateTime.Today) != -1 && alimTarihpick.Value != DateTime.Today)
            {
                MessageBox.Show("Şuanki tarihten daha ileri bir seçim yapamazsınız.");
                alimTarihpick.Value = DateTime.Today;
            }
            else
            {
                teslimTarihpick.Value = alimTarihpick.Value.AddDays(15);
            }
        }
        private void btnKitapAl_Click(object sender, EventArgs e)
        {
            try
            {
                if (!AlinanKitapKontrol(kitapId) && AdetKontrol(kitapId) && !cezaKontrol()){
                    AlinanKitap alinanKitap = new AlinanKitap {

                        AlanAd = kullanici.KullaniciAd,
                        AlanSoyad = kullanici.KullaniciSoyad,
                        AlanTc = kullanici.KullaniciTc,
                        AlımTarih = alimTarihpick.Value,
                        Barkod = Convert.ToInt32(dgwKitaplar.CurrentRow.Cells[3].Value),
                        KitapAdı = dgwKitaplar.CurrentRow.Cells[1].Value.ToString(),
                        KitapId = Convert.ToInt32(dgwKitaplar.CurrentRow.Cells[0].Value.ToString()),
                        KitapKategori = dgwKitaplar.CurrentRow.Cells[2].Value.ToString(),
                        KitapSonTeslimTarihi = teslimTarihpick.Value,
                        TeslimTarih = teslimTarihpick.Value,
                        Sayfa = Convert.ToInt32(dgwKitaplar.CurrentRow.Cells[5].Value.ToString()),
                        Yazar = dgwKitaplar.CurrentRow.Cells[6].Value.ToString(),
                        ErtelendiMi = "Hayır",                    };
                    alinanKitapKod.Add(alinanKitap);
                    KitapAdetGuncelle(kitapId);
                    KitaplariDoldur();
                    AlinanKitapListGuncelle();
                    AlinanKitapDoldur();
                }
               
            }
            catch (Exception)
            {

                MessageBox.Show("Bir hata oluştu.");
            }
            
        }
        public bool AlinanKitapKontrol(int kitapId)
        {
            bool isFind=false;
            AlinanKitapListGuncelle();
            foreach (var kitap in alinanKitaplar)
            {
                if(kitapId == kitap.KitapId)
                {
                    MessageBox.Show("Zaten bu kitaba sahipsiniz");
                    isFind = true;
                    return isFind;
                }
                
            }
            return isFind;
        }
        public bool cezaKontrol()
        {
            bool varMı=true;
            if( kullanici.CezaDurumu.ToString() == "0")
            {
                varMı = false;
                return varMı;
            }
            else
            {
                MessageBox.Show("Cezanızı ödemeden kitap alamazsınız.");
            }
            return varMı;
        }
        public bool AdetKontrol(int id)
        {
            bool stoktaVarMı = true;
            foreach (var kitap in kitaplar)
            {
                if(kitap.Adet <= 0 && id == kitap.KitapId)
                {
                    MessageBox.Show("Stoklarımızda " + kitap.Ad +" tükenmiştir.");
                    stoktaVarMı = false;
                }

            }
            return stoktaVarMı;
        }
        public void KitapAdetGuncelle(int id)
        {
            foreach (var kitap in kitaplar)
            {
                if(kitap.KitapId == id)
                {
                    kitapKod.Update(new Kitap
                    {
                        KitapId = id,
                        Ad = dgwKitaplar.CurrentRow.Cells[1].Value.ToString(),
                        Adet = Convert.ToInt32( dgwKitaplar.CurrentRow.Cells[4].Value)-1,
                        Barkod = Convert.ToInt32(dgwKitaplar.CurrentRow.Cells[3].Value.ToString()),
                        Kategori = dgwKitaplar.CurrentRow.Cells[2].Value.ToString(),
                        Sayfa = Convert.ToInt32(dgwKitaplar.CurrentRow.Cells[5].Value.ToString()),
                        Yazar = dgwKitaplar.CurrentRow.Cells[6].Value.ToString(),
                    });
                }
            }
        }
        private void dgwKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kitapId = Convert.ToInt32(dgwKitaplar.CurrentRow.Cells[0].Value);
        }

      
        public void Ertele(int id)
        {
            bool girdiMi = false;
            foreach (var kitap in alinanKitaplar)
            {
                if(kitap.Id == id && kitap.ErtelendiMi == "Hayır")
                {
                    girdiMi = true;
                    kitap.TeslimTarih = kitap.TeslimTarih.AddDays(5);
                    kitap.ErtelendiMi = "Evet";
                    alinanKitapKod.Update(kitap);
                    AlinanKitapListGuncelle();
                    AlinanKitapDoldur();
                    break;
                }
            }
            if (girdiMi == false)
            {
                MessageBox.Show("Sadece bir kere erteleme yapabilirsiniz.");
            }
            
        }
        private void btnErtele_Click(object sender, EventArgs e)
        {
            Ertele(kitapId);
        }

        private void dgwAlinan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kitapId = Convert.ToInt32( dgwAlinan.CurrentRow.Cells[0].Value);
           pickerAlinanTarih.Value =  Convert.ToDateTime( dgwAlinan.CurrentRow.Cells[4].Value);
            pickerTeslimEt.Value = Convert.ToDateTime(dgwAlinan.CurrentRow.Cells[5].Value);
        }
        public void TeslimEt(int id)
        {
            foreach (var kitap in alinanKitaplar)
            {
                if (kitap.Id == id)
                {
                    if (kitap.TeslimTarih < DateTime.Today)
                    {
                        kullanici.CezaOdendiMi = "Hayır";
                        TimeSpan cezaMiktar = DateTime.Today.Date - kitap.TeslimTarih.Date;
                        decimal ceza = Convert.ToDecimal(cezaMiktar.Days);
                        kullanici.CezaDurumu += ceza;
                        MessageBox.Show("Geç teslim sebebiyle " + ceza +" tutarında ceza tutarı oluşturuldu");
                    }
                        kullaniciKod.Update(kullanici);
                        KullaniciTut();
                        lblCezaMiktar.Text = kullanici.CezaDurumu.ToString();
                        alinanKitapKod.Delete(id);
                        AlinanKitapListGuncelle();
                        AlinanKitapDoldur();
                    foreach (var _kitap in kitaplar)
                        {
                            if (_kitap.KitapId == kitap.KitapId)
                            {
                                _kitap.Adet++;
                                kitapKod.Update(_kitap);
                                KitaplariDoldur();
                                break;
                            }
                        }
                    break;
                }
            }
        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            TeslimEt(kitapId);
        }

        void KullaniciGoruntule()
        {
            lblAd.Text=kullanici.KullaniciAd;
            lblSoyad.Text = kullanici.KullaniciSoyad;
            lblCinsiyet.Text = kullanici.KullaniciCinsiyet;
            lblDogum.Text = kullanici.KullaniciDogumTarihi;
            lblTc.Text = kullanici.KullaniciTc;
            lblCezadur.Text = kullanici.CezaOdendiMi.ToString();


        }
        private void btnCezaOde_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(tbxCezaTutar.Text) == kullanici.CezaDurumu)
                {
                    kullanici.CezaDurumu = 0;
                    kullanici.CezaOdendiMi = "Evet";
                    kullaniciKod.Update(kullanici);
                    KullaniciTut();
                    lblCezaMiktar.Text = kullanici.CezaDurumu.ToString();

                    MessageBox.Show("Tüm borcunuz ödenmiştir.");
                }
                else if (Convert.ToDecimal(tbxCezaTutar.Text) < kullanici.CezaDurumu)
                {
                    kullanici.CezaDurumu -= Convert.ToDecimal(tbxCezaTutar.Text);
                    kullanici.CezaOdendiMi = "Hayır";
                    kullaniciKod.Update(kullanici);
                    KullaniciTut();
                    lblCezaMiktar.Text = kullanici.CezaDurumu.ToString();
                    MessageBox.Show("Kalan borcunuz " + kullanici.CezaDurumu + " TL'dir.");

                }
                else if (Convert.ToDecimal(tbxCezaTutar.Text) > kullanici.CezaDurumu)
                {

                    MessageBox.Show("Ceza tutarından yüksek bir değer girişi yaptınız.");

                }
            }
            catch (FormatException exception)
            {

                 MessageBox.Show("Sadece sayı girişi yapınız veya boş bırakmayınız");
            }
            catch (Exception exception)
            {

                MessageBox.Show("Giriş değerlerinizi kontrol ediniz.");
            }

           
        }

        private void tbxArama_TextChanged(object sender, EventArgs e)
        {
            dgwKitaplar.DataSource = kitapKod.KitapAra(tbxArama.Text);
        }

        private void label15_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        KullaniciGirisi Kullanici = new KullaniciGirisi();
        private void label18_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kullanici.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kullanici.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblCezadur_Click(object sender, EventArgs e)
        {

        }
    }
}
