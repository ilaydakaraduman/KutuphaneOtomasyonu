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

namespace KutuphaneOtomasyonu.KitapBilgi
{
    public partial class KitapKayit : Form
    {
        int kitapId;
        int öncekiAdet;
        KitapKod kitapKod = new KitapKod();
        public KitapKayit()
        {
            InitializeComponent();
        }
        
        private void KitapKayit_Load(object sender, EventArgs e)
        {
            KitaplarıDoldur();

        }

        public void KitaplarıDoldur()
        {
            dgwKitaplar.DataSource = kitapKod.GetAll();
        }
        public bool barkodKontrol()
        {

            if (kitapKod.KitapAra(Convert.ToInt32(tbxBarkod.Text)).Count > 0) {
                MessageBox.Show("Bu kitap zaten mevcut");
                return false;
            }
            return true;

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (barkodKontrol())
                {
                    kitapKod.Add(new Kitap
                    {
                        Ad = tbxAd.Text.ToString(),
                        Kategori = cbxKategori.SelectedItem.ToString(),
                        Barkod = Convert.ToInt32(tbxBarkod.Text),
                        Adet = Convert.ToInt32(tbxAdet.Text),
                        Sayfa = Convert.ToInt32(tbxSayfa.Text),
                        Yazar = tbxYazar.Text.ToString(),

                    });
                    KitaplarıDoldur();
                    textBoxlarıBosalt();
                }
                
            }
            catch (NullReferenceException)
            {

                MessageBox.Show("Tüm değerleri eksiksiz giriniz.");
            }
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                kitapKod.Update(new Kitap
                {
                    KitapId = kitapId,
                    Ad = tbxAd.Text,
                    Kategori = cbxKategori.SelectedItem.ToString(),
                    Barkod = Convert.ToInt32(tbxBarkod.Text),
                    Adet = Convert.ToInt32(tbxAdet.Text) + öncekiAdet,
                    Sayfa = Convert.ToInt32(tbxSayfa.Text),
                    Yazar = tbxYazar.Text,

                });
                KitaplarıDoldur();
                textBoxlarıBosalt();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Tüm değerleri eksiksiz giriniz.");
            }
            catch (Exception err)
            {
                tbxAdet.Text = "1";
                MessageBox.Show("Adet boş bırakılamaz ya da sadece sayı girebilirsiniz.");
            }



        }
        public void textBoxlarıBosalt()
        {
            tbxAd.Text = "";
            tbxYazar.Text = "";
            tbxSayfa.Text = "";
            tbxAdet.Text = "";
            tbxBarkod.Text = "";
            
        }

        private void tbxBarkod_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(tbxBarkod.Text != "")
                {
                    int key = Convert.ToInt32(tbxBarkod.Text);
                    dgwKitaplar.DataSource = kitapKod.KitapAra(key);
                }
            }
            catch (FormatException err )
            {
                tbxBarkod.Text = "";
                MessageBox.Show("Lütfen sadece sayı yazınız.");
            }
        }

        private void dgwKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kitapId = Convert.ToInt32( dgwKitaplar.CurrentRow.Cells[0].Value.ToString());
            tbxAd.Text = dgwKitaplar.CurrentRow.Cells[1].Value.ToString();
            cbxKategori.SelectedItem = dgwKitaplar.CurrentRow.Cells[2].Value.ToString();
            tbxBarkod.Text = dgwKitaplar.CurrentRow.Cells[3].Value.ToString();
            öncekiAdet = Convert.ToInt32(dgwKitaplar.CurrentRow.Cells[4].Value.ToString());
            tbxSayfa.Text = dgwKitaplar.CurrentRow.Cells[5].Value.ToString();
            tbxYazar.Text = dgwKitaplar.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnSıfırla_Click(object sender, EventArgs e)
        {
            textBoxlarıBosalt();
            KitaplarıDoldur();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        yoneticiIslem yonetici = new yoneticiIslem();
        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            yonetici.Show();

        }

        private void btnKitap_Click(object sender, EventArgs e)
        {
            grafik graf = new grafik();
            graf.Show();
        }
    }
}
