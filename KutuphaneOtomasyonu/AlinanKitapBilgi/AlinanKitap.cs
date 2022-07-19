using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.AlinanKitapBilgi
{
    public class AlinanKitap
    {
        public int Id { get; set; }
        public string AlanAd { get; set; }
        public string AlanSoyad { get; set; }
        public string AlanTc { get; set; }
        public DateTime AlımTarih { get; set; }
        public DateTime TeslimTarih { get; set; }
        public int KitapId { get; set; }
        public int Sayfa { get; set; }
        public string Yazar { get; set; }
        public int Barkod { get; set; }
        public string KitapAdı { get; set; }
        public string KitapKategori { get; set; }
        public DateTime KitapSonTeslimTarihi { get; set; }
        public string ErtelendiMi { get; set; }
    }
}
