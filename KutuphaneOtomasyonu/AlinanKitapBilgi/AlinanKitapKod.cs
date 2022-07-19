using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.AlinanKitapBilgi
{
    public class AlinanKitapKod
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
            SqlCommand command = new SqlCommand("Delete from AlinanKitaplar where Id=@Id", _connection);

            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();

            _connection.Close();

        }

        public void Add(AlinanKitap alinanKitap)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("insert into AlinanKitaplar values(@AlanAd,@AlanSoyad,@AlanTc,@AlımTarih,@TeslimTarih,@KitapId,@Sayfa,@Yazar,@Barkod,@KitapAdı,@KitapKategori,@KitapSonTeslimTarihi,@ErtelendiMi)", _connection);
            command.Parameters.AddWithValue("@AlanAd", alinanKitap.AlanAd);
            command.Parameters.AddWithValue("@AlanSoyad", alinanKitap.AlanSoyad);
            command.Parameters.AddWithValue("@AlanTc", alinanKitap.AlanTc);
            command.Parameters.AddWithValue("@AlımTarih", alinanKitap.AlımTarih);
            command.Parameters.AddWithValue("@TeslimTarih", alinanKitap.TeslimTarih);
            command.Parameters.AddWithValue("@KitapId", alinanKitap.KitapId);
            command.Parameters.AddWithValue("@Sayfa", alinanKitap.Sayfa);
            command.Parameters.AddWithValue("@Yazar", alinanKitap.Yazar);
            command.Parameters.AddWithValue("@Barkod", alinanKitap.Barkod);
            command.Parameters.AddWithValue("@KitapAdı", alinanKitap.KitapAdı);
            command.Parameters.AddWithValue("@KitapKategori", alinanKitap.KitapKategori);
            command.Parameters.AddWithValue("@KitapSonTeslimTarihi", alinanKitap.KitapSonTeslimTarihi);
            command.Parameters.AddWithValue("@ErtelendiMi", alinanKitap.ErtelendiMi);

            command.ExecuteNonQuery();

            _connection.Close();

        }
        public void Update(AlinanKitap alinanKitap)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update AlinanKitaplar set AlanAd=@AlanAd, AlanSoyad=@AlanSoyad, AlanTc=@AlanTc, AlımTarih=@AlımTarih, TeslimTarih=@TeslimTarih, KitapId=@KitapId, Sayfa=@Sayfa, Yazar=@Yazar, Barkod=@Barkod, KitapAdı=@KitapAdı, KitapKategori=@KitapKategori, KitapSonTeslimTarihi=@KitapSonTeslimTarihi, ErtelendiMi=@ErtelendiMi where Id=@Id", _connection);
            command.Parameters.AddWithValue("@AlanAd", alinanKitap.AlanAd);
            command.Parameters.AddWithValue("@AlanSoyad", alinanKitap.AlanSoyad);
            command.Parameters.AddWithValue("@AlanTc", alinanKitap.AlanTc);
            command.Parameters.AddWithValue("@AlımTarih", alinanKitap.AlımTarih);
            command.Parameters.AddWithValue("@TeslimTarih", alinanKitap.TeslimTarih);
            command.Parameters.AddWithValue("@KitapId", alinanKitap.KitapId);
            command.Parameters.AddWithValue("@Sayfa", alinanKitap.Sayfa);
            command.Parameters.AddWithValue("@Yazar", alinanKitap.Yazar);
            command.Parameters.AddWithValue("@Barkod", alinanKitap.Barkod);
            command.Parameters.AddWithValue("@KitapAdı", alinanKitap.KitapAdı);
            command.Parameters.AddWithValue("@KitapKategori", alinanKitap.KitapKategori);
            command.Parameters.AddWithValue("@KitapSonTeslimTarihi", alinanKitap.KitapSonTeslimTarihi);
            command.Parameters.AddWithValue("@Id", alinanKitap.Id);
            command.Parameters.AddWithValue("@ErtelendiMi", alinanKitap.ErtelendiMi);
            command.ExecuteNonQuery();

            _connection.Close();

        }
        public List<AlinanKitap> GetPersonalBooks(string key)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from AlinanKitaplar where AlanTc like '%" + key + "%'", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<AlinanKitap> alinanKitaplar = new List<AlinanKitap>();
            while (reader.Read())
            {
                AlinanKitap alinanKitap = new AlinanKitap
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    AlanAd = reader["AlanAd"].ToString(),
                    AlanSoyad = reader["AlanSoyad"].ToString(),
                    AlanTc = reader["AlanTc"].ToString(),
                    AlımTarih = Convert.ToDateTime(reader["AlımTarih"].ToString()),
                    Barkod = Convert.ToInt32(reader["Barkod"].ToString()),
                    KitapAdı = reader["KitapAdı"].ToString(),
                    KitapId = Convert.ToInt32(reader["KitapId"].ToString()),
                    KitapKategori = reader["KitapKategori"].ToString(),
                    KitapSonTeslimTarihi = Convert.ToDateTime(reader["KitapSonTeslimTarihi"].ToString()),
                    Sayfa = Convert.ToInt32(reader["Sayfa"].ToString()),
                    TeslimTarih = Convert.ToDateTime(reader["TeslimTarih"].ToString()),
                    Yazar = reader["Yazar"].ToString(),
                    ErtelendiMi = reader["ErtelendiMi"].ToString(),

                };
                alinanKitaplar.Add(alinanKitap);
            }
            reader.Close();
            _connection.Close();
            return alinanKitaplar;
        }
        public List<AlinanKitap> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from AlinanKitaplar", _connection);

            SqlDataReader reader = command.ExecuteReader();
            List<AlinanKitap> alinanKitaplar = new List<AlinanKitap>();
            while (reader.Read())
            {
                AlinanKitap alinanKitap = new AlinanKitap
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    AlanAd = reader["AlanAd"].ToString(),
                    AlanSoyad = reader["AlanSoyad"].ToString(),
                    AlanTc = reader["AlanTc"].ToString(),
                    AlımTarih = Convert.ToDateTime( reader["AlımTarih"].ToString()),
                    Barkod  = Convert.ToInt32( reader["Barkod"].ToString()),
                    KitapAdı = reader["KitapAdı"].ToString(),
                    KitapId = Convert.ToInt32(reader["KitapId"].ToString()),
                    KitapKategori = reader["KitapKategori"].ToString(),
                    KitapSonTeslimTarihi = Convert.ToDateTime(reader["KitapSonTeslimTarihi"].ToString()),
                    Sayfa = Convert.ToInt32(reader["Sayfa"].ToString()),
                    TeslimTarih = Convert.ToDateTime(reader["TeslimTarih"].ToString()),
                    Yazar = reader["Yazar"].ToString(),
                    ErtelendiMi = reader["ErtelendiMi"].ToString(),

                };
                alinanKitaplar.Add(alinanKitap);
            }
            reader.Close();
            _connection.Close();
            return alinanKitaplar;
        }
    }
}
