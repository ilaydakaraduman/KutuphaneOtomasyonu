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
    public partial class grafik : Form
    {
        public grafik()
        {
            InitializeComponent();
        }

        List<Kitap> kitapsay = new List<Kitap>();
       
        int TarihSayac=0, RomanSayac = 0, Fantastiksayac = 0, KisiselGelisimsayac = 0, Gizemsayac = 0, Polisiyesayasc = 0;

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        KitapKod Kitap = new KitapKod();
       public void kitaphesapla()
        {
            kitapsay = Kitap.GetAll();
            foreach (var kategori in kitapsay)
            {
                if (kategori.Kategori== "TARİH")
                {
                    TarihSayac += kategori.Adet;

                }
                if (kategori.Kategori == "ROMAN")
                {
                    RomanSayac+= kategori.Adet;

                }
                if (kategori.Kategori == "FANTASTİK")
                {
                    Fantastiksayac+= kategori.Adet;

                }
                if (kategori.Kategori == "KİŞİSEL GELİŞİM")
                {
                    KisiselGelisimsayac += kategori.Adet;

                }
                if (kategori.Kategori == "GİZEM")
                {
                    Gizemsayac+= kategori.Adet;

                }
                if (kategori.Kategori == "POLİSİYE")
                {

                    Polisiyesayasc+= kategori.Adet;
                }
            }
        }
        private void grafik_Load(object sender, EventArgs e)
        {
            kitaphesapla();
            //textboxdan verileri çekmek için değişkenlerimi tanımladım.
            int Tarih, Roman, Fantastik, KisiselGelisim, Gizem, Polisiye;

            //Akabinde bu değişkenlerin veri dönüşüm işlemi yaptım.
            Tarih = TarihSayac;
            Roman = RomanSayac;
            Fantastik = Fantastiksayac;
            KisiselGelisim = KisiselGelisimsayac;
            Gizem = Gizemsayac;
            Polisiye = Polisiyesayasc;


            //grafiğimdeki serilerin sıfırlanması için Clear butonu ile temizleme işlemim
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            //Daha sonra grafikte göstereceğim verileri tanımlama işlemlerimi yapıyorum.
            chart1.Series["KitapKategori"].Points.AddXY("Tarih", Tarih);
            chart1.Series["KitapKategori"].Points.AddXY("Roman", Roman);
            chart1.Series["KitapKategori"].Points.AddXY("Fantastik", Fantastik);
            chart1.Series["KitapKategori"].Points.AddXY("KisiselGelisim", KisiselGelisim);
            chart1.Series["KitapKategori"].Points.AddXY("Gizem", Gizem);
            chart1.Series["KitapKategori"].Points.AddXY("Polisiye", Polisiye);
        }
    }
}
