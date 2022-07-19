using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.KullaniciBilgi
{
   public class Kullanici
    {
        public int KullaniciId { get; set; }
        public string KullaniciAd { get; set; }
        public string KullaniciSoyad { get; set; }
        public string KullaniciTc { get; set; }
        public string KullaniciSifre { get; set; }
        public string KullaniciDogumTarihi { get; set; }
        public string KullaniciCinsiyet { get; set; }
        public decimal CezaDurumu { get; set; }
        public string CezaOdendiMi { get; set; }
    }
}
