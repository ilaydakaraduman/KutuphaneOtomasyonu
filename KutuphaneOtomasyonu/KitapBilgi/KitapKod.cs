using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.KitapBilgi
{
    public class KitapKod
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
            SqlCommand command = new SqlCommand("Delete from Kitaplar where KitapId=@KitapId", _connection);

            command.Parameters.AddWithValue("@KitapId", id);
            command.ExecuteNonQuery();

            _connection.Close();

        }

        public void Add(Kitap kitap)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("insert into Kitaplar values(@Ad,@Kategori,@Barkod,@Adet,@Sayfa,@Yazar)", _connection);
            command.Parameters.AddWithValue("@Ad", kitap.Ad);
            command.Parameters.AddWithValue("@Kategori", kitap.Kategori);
            command.Parameters.AddWithValue("@Barkod", kitap.Barkod);
            command.Parameters.AddWithValue("@Adet", kitap.Adet);
            command.Parameters.AddWithValue("@Sayfa", kitap.Sayfa);
            command.Parameters.AddWithValue("@Yazar", kitap.Yazar);
            

            command.ExecuteNonQuery();

            _connection.Close();

        }
        public void Update(Kitap kitap)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Kitaplar set Ad=@Ad, Kategori=@Kategori, Barkod=@Barkod, Adet=@Adet, Sayfa=@Sayfa, Yazar=@Yazar where KitapId=@KitapId", _connection);
            command.Parameters.AddWithValue("@Ad", kitap.Ad);
            command.Parameters.AddWithValue("@Kategori", kitap.Kategori);
            command.Parameters.AddWithValue("@Barkod", kitap.Barkod);
            command.Parameters.AddWithValue("@Adet", kitap.Adet);
            command.Parameters.AddWithValue("@Sayfa", kitap.Sayfa);
            command.Parameters.AddWithValue("@Yazar", kitap.Yazar);
            command.Parameters.AddWithValue("@KitapId", kitap.KitapId);
            command.ExecuteNonQuery();

            _connection.Close();

        }

        public List<Kitap> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Kitaplar", _connection);

            SqlDataReader reader = command.ExecuteReader();
            List<Kitap> kitaplar = new List<Kitap>();
            while (reader.Read())
            {
                Kitap kitap = new Kitap
                {
                    KitapId = Convert.ToInt32(reader["KitapId"]),
                    Ad = reader["Ad"].ToString(),
                    Kategori = reader["Kategori"].ToString(),
                    Barkod = Convert.ToInt32(reader["Barkod"].ToString()),
                    Adet = Convert.ToInt32(reader["Adet"].ToString()),
                    Sayfa = Convert.ToInt32(reader["Sayfa"].ToString()),
                    Yazar = reader["Yazar"].ToString(),
                };
                kitaplar.Add(kitap);
            }
            reader.Close();
            _connection.Close();
            return kitaplar;
        }
        public List<Kitap> KitapAra(int key)
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Kitaplar where Barkod like '%" + key + "%'", _connection);

            SqlDataReader reader = command.ExecuteReader();
            List<Kitap> kitaplar = new List<Kitap>();
            while (reader.Read())
            {
                Kitap ogrenci = new Kitap
                {
                    KitapId = Convert.ToInt32(reader["KitapId"]),
                    Ad = reader["Ad"].ToString(),
                    Kategori = reader["Kategori"].ToString(),
                    Barkod = Convert.ToInt32(reader["Barkod"].ToString()),
                    Adet = Convert.ToInt32(reader["Adet"].ToString()),
                    Sayfa = Convert.ToInt32(reader["Sayfa"].ToString()),
                    Yazar = reader["Yazar"].ToString(),
                };
                kitaplar.Add(ogrenci);
            }
            reader.Close();
            _connection.Close();
            return kitaplar;

        }
        public List<Kitap> KitapAra(string key)
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Kitaplar where Ad like '%" + key + "%'", _connection);

            SqlDataReader reader = command.ExecuteReader();
            List<Kitap> kitaplar = new List<Kitap>();
            while (reader.Read())
            {
                Kitap ogrenci = new Kitap
                {
                    KitapId = Convert.ToInt32(reader["KitapId"]),
                    Ad = reader["Ad"].ToString(),
                    Kategori = reader["Kategori"].ToString(),
                    Barkod = Convert.ToInt32(reader["Barkod"].ToString()),
                    Adet = Convert.ToInt32(reader["Adet"].ToString()),
                    Sayfa = Convert.ToInt32(reader["Sayfa"].ToString()),
                    Yazar = reader["Yazar"].ToString(),
                };
                kitaplar.Add(ogrenci);
            }
            reader.Close();
            _connection.Close();
            return kitaplar;

        }
    }
}
