using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.KullaniciBilgi
{
    public class KullaniciKod
    {
        SqlConnection _connection = new SqlConnection(@"Data Source =(localdb)\MSSQLLocalDB; initial catalog=KutuphaneOtomasyonu;integrated security=true");
        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Kullanici where KullaniciId=@KullaniciId", _connection);

            command.Parameters.AddWithValue("@KullaniciId", id);
            command.ExecuteNonQuery();

            _connection.Close();

        }

        public void Add(Kullanici kullanici)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("insert into Kullanici values(@KullaniciAd,@KullaniciSoyad,@KullaniciTc,@KullaniciSifre,@KullaniciDogumTarihi,@KullaniciCinsiyet,@CezaDurumu,@CezaOdendiMi)", _connection);
            command.Parameters.AddWithValue("@KullaniciAd", kullanici.KullaniciAd);
            command.Parameters.AddWithValue("@KullaniciSoyad", kullanici.KullaniciSoyad);
            command.Parameters.AddWithValue("@KullaniciTc", kullanici.KullaniciTc);
            command.Parameters.AddWithValue("@KullaniciSifre", kullanici.KullaniciSifre);
            command.Parameters.AddWithValue("@KullaniciDogumTarihi", kullanici.KullaniciDogumTarihi);
            command.Parameters.AddWithValue("@KullaniciCinsiyet", kullanici.KullaniciCinsiyet);
            command.Parameters.AddWithValue("@CezaDurumu", kullanici.CezaDurumu);
            command.Parameters.AddWithValue("@CezaOdendiMi", kullanici.CezaOdendiMi);


            command.ExecuteNonQuery();

            _connection.Close();

        }
        public void Update(Kullanici kullanici)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Kullanici set KullaniciAd=@KullaniciAd, KullaniciSoyad=@KullaniciSoyad, KullaniciTc=@KullaniciTc, KullaniciSifre=@KullaniciSifre, KullaniciDogumTarihi=@KullaniciDogumTarihi, KullaniciCinsiyet=@KullaniciCinsiyet, CezaDurumu=@CezaDurumu, CezaOdendiMi=@CezaOdendiMi where KullaniciId=@KullaniciId", _connection);
            command.Parameters.AddWithValue("@KullaniciAd", kullanici.KullaniciAd);
            command.Parameters.AddWithValue("@KullaniciSoyad", kullanici.KullaniciSoyad);
            command.Parameters.AddWithValue("@KullaniciTc", kullanici.KullaniciTc);
            command.Parameters.AddWithValue("@KullaniciSifre", kullanici.KullaniciSifre);
            command.Parameters.AddWithValue("@KullaniciDogumTarihi", kullanici.KullaniciDogumTarihi);
            command.Parameters.AddWithValue("@KullaniciCinsiyet", kullanici.KullaniciCinsiyet);
            command.Parameters.AddWithValue("@CezaDurumu", kullanici.CezaDurumu);
            command.Parameters.AddWithValue("@CezaOdendiMi", kullanici.CezaOdendiMi);
            command.Parameters.AddWithValue("@KullaniciId", kullanici.KullaniciId);
            command.ExecuteNonQuery();

            _connection.Close();

        }

        public List<Kullanici> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Kullanici", _connection);

            SqlDataReader reader = command.ExecuteReader();
            List<Kullanici> kullanicilar = new List<Kullanici>();
            while (reader.Read())
            {
                Kullanici kullanici = new Kullanici
                {
                    KullaniciId = Convert.ToInt32(reader["KullaniciId"]),
                    KullaniciAd = reader["KullaniciAd"].ToString(),
                    KullaniciSoyad = reader["KullaniciSoyad"].ToString(),
                    KullaniciTc = reader["KullaniciTc"].ToString(),
                    KullaniciSifre = reader["KullaniciSifre"].ToString(),
                    KullaniciDogumTarihi = reader["KullaniciDogumTarihi"].ToString(),
                    KullaniciCinsiyet = reader["KullaniciCinsiyet"].ToString(),
                    CezaDurumu = Convert.ToDecimal( reader["CezaDurumu"].ToString()),
                    CezaOdendiMi =   reader["CezaOdendiMi"].ToString(),
                };
                kullanicilar.Add(kullanici);
            }
            reader.Close();
            _connection.Close();
            return kullanicilar;
        }
        public List<Kullanici> Search(string key)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Kullanici where KullaniciAd like '%" + key + "%'", _connection);

            SqlDataReader reader = command.ExecuteReader();
            List<Kullanici> kullanicilar = new List<Kullanici>();
            while (reader.Read())
            {
                Kullanici kullanici = new Kullanici
                {
                    KullaniciId = Convert.ToInt32(reader["KullaniciId"]),
                    KullaniciAd = reader["KullaniciAd"].ToString(),
                    KullaniciSoyad = reader["KullaniciSoyad"].ToString(),
                    KullaniciTc = reader["KullaniciTc"].ToString(),
                    KullaniciSifre = reader["KullaniciSifre"].ToString(),
                    KullaniciDogumTarihi = reader["KullaniciDogumTarihi"].ToString(),
                    KullaniciCinsiyet = reader["KullaniciCinsiyet"].ToString(),
                    CezaDurumu = Convert.ToDecimal(reader["CezaDurumu"].ToString()),
                    CezaOdendiMi = reader["CezaOdendiMi"].ToString(),
                };
                kullanicilar.Add(kullanici);
            }
            reader.Close();
            _connection.Close();
            return kullanicilar;
        }
        //public List<Kitap> KitapAra(int key)
        //{

        //    ConnectionControl();
        //    SqlCommand command = new SqlCommand("Select * from Kitaplar where Barkod like '%" + key + "%'", _connection);

        //    SqlDataReader reader = command.ExecuteReader();
        //    List<Kitap> kitaplar = new List<Kitap>();
        //    while (reader.Read())
        //    {
        //        Kitap ogrenci = new Kitap
        //        {
        //            KitapId = Convert.ToInt32(reader["KitapId"]),
        //            Ad = reader["Ad"].ToString(),
        //            Kategori = reader["Kategori"].ToString(),
        //            Barkod = Convert.ToInt32(reader["Barkod"].ToString()),
        //            Adet = Convert.ToInt32(reader["Adet"].ToString()),
        //            Sayfa = Convert.ToInt32(reader["Sayfa"].ToString()),
        //            Yazar = reader["Yazar"].ToString(),
        //        };
        //        kitaplar.Add(ogrenci);
        //    }
        //    reader.Close();
        //    _connection.Close();
        //    return kitaplar;

        //}
    }
}
