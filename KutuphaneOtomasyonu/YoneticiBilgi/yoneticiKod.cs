using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.YoneticiBilgi
{
    public class yoneticiKod
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
            SqlCommand command = new SqlCommand("Delete from Yonetici where YoneticiId=@YoneticiId", _connection);

            command.Parameters.AddWithValue("@YoneticiId", id);
            command.ExecuteNonQuery();

            _connection.Close();

        }

        public void Add(Yonetici yonetici)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("insert into Yonetici values(@YoneticiAd,@YoneticiSoyad,@YoneticiTc,@YoneticiSifre,@Cinsiyet, @DogumTarihi)", _connection);
            command.Parameters.AddWithValue("@YoneticiAd", yonetici.YoneticiAd);
            command.Parameters.AddWithValue("@YoneticiSoyad", yonetici.YoneticiSoyad);
            command.Parameters.AddWithValue("@YoneticiTc", yonetici.YoneticiTc);
            command.Parameters.AddWithValue("@YoneticiSifre", yonetici.YoneticiSifre);
            command.Parameters.AddWithValue("@Cinsiyet", yonetici.Cinsiyet);
            command.Parameters.AddWithValue("@DogumTarihi", yonetici.DogumTarihi);


            command.ExecuteNonQuery();

            _connection.Close();

        }
        public void Update(Yonetici yonetici)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Yonetici set YoneticiAd=@YoneticiAd,YoneticiSoyad=@YoneticiSoyad ,YoneticiTc=@YoneticiTc, YoneticiSifre=@YoneticiSifre, Cinsiyet=@Cinsiyet, DogumTarihi=@DogumTarihi  where YoneticiId=@YoneticiId", _connection);
            command.Parameters.AddWithValue("@YoneticiAd", yonetici.YoneticiAd);
            command.Parameters.AddWithValue("@YoneticiSoyad", yonetici.YoneticiSoyad);
            command.Parameters.AddWithValue("@YoneticiTc", yonetici.YoneticiTc);
            command.Parameters.AddWithValue("@YoneticiSifre", yonetici.YoneticiSifre);
            command.Parameters.AddWithValue("@Cinsiyet", yonetici.Cinsiyet);
            command.Parameters.AddWithValue("@DogumTarihi", yonetici.DogumTarihi);
            command.Parameters.AddWithValue("@YoneticiId", yonetici.YoneticiId);
            command.ExecuteNonQuery();

            _connection.Close();

        }

        public List<Yonetici> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Yonetici", _connection);

            SqlDataReader reader = command.ExecuteReader();
            List<Yonetici> yoneticiler = new List<Yonetici>();
            while (reader.Read())
            {
                Yonetici yonetici = new Yonetici
                {
                    YoneticiId = Convert.ToInt32(reader["YoneticiId"]),
                    YoneticiAd = reader["YoneticiAd"].ToString(),
                    YoneticiSoyad = reader["YoneticiSoyad"].ToString(),
                    YoneticiTc = reader["YoneticiTc"].ToString(),
                    YoneticiSifre = reader["YoneticiSifre"].ToString(),
                    Cinsiyet = reader["Cinsiyet"].ToString(),
                    DogumTarihi = reader["DogumTarihi"].ToString(),
                };
                yoneticiler.Add(yonetici);
            }
            reader.Close();
            _connection.Close();
            return yoneticiler;
        }
        public List<Yonetici> Search(string key)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Yonetici where YoneticiAd like '%" + key + "%'", _connection);

            SqlDataReader reader = command.ExecuteReader();
            List<Yonetici> yoneticiler = new List<Yonetici>();
            while (reader.Read())
            {
                Yonetici yonetici = new Yonetici
                {
                    YoneticiId = Convert.ToInt32(reader["YoneticiId"]),
                    YoneticiAd = reader["YoneticiAd"].ToString(),
                    YoneticiSoyad = reader["YoneticiSoyad"].ToString(),
                    YoneticiTc = reader["YoneticiTc"].ToString(),
                    YoneticiSifre = reader["YoneticiSifre"].ToString(),
                    Cinsiyet = reader["Cinsiyet"].ToString(),
                    DogumTarihi = reader["DogumTarihi"].ToString(),
                };
                yoneticiler.Add(yonetici);
            }
            reader.Close();
            _connection.Close();
            return yoneticiler;
        }
    }
}
