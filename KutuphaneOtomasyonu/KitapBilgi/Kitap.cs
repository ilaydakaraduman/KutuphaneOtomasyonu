using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.KitapBilgi
{
    public class Kitap
    {
        public int KitapId { get; set; }
        public string Ad { get; set; }
        public string Kategori { get; set; }
        public int Barkod { get; set; }
        public int Adet { get; set; }
        public int Sayfa { get; set; }
        public string Yazar { get; set; }
    }
}
