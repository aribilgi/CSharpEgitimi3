using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsAppAdoNet
{
    public class ProductDAL
    {
        SqlConnection connection = new SqlConnection(@"server=(LocalDB)\MSSQLLocalDB; initial catalog=UrunYonetimiAdoNet; integrated security=true");

        void ConnectionKontrol()//Veritabanı bağlantısının açık olup olmadığını kontrol eden metot
        {
            if (connection.State == ConnectionState.Closed) //Yukardaki _connection bağlantı nesnemizin durumu bağlantı durumlarından kapalıya eşitse
            {
                connection.Open(); // Bağlantıyı aç
            }
        }

        public List<Product> GetAll()
        {
            ConnectionKontrol();
            List<Product> products = new List<Product>();
            SqlCommand command = new SqlCommand("select * from products", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    UrunAdi = reader["UrunAdi"].ToString(),
                    StokMiktari = Convert.ToInt32(reader["StokMiktari"]),
                    UrunFiyati = Convert.ToDecimal(reader["UrunFiyati"])
                };
                products.Add(product);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return products;
        }

        public DataTable GetAllDataTable()
        {
            ConnectionKontrol();//Bağlantı kontrolü yaptık
            SqlCommand komut = new SqlCommand("select * from products", connection);//veritabanına sorgumuzu gönderdik
            SqlDataReader reader = komut.ExecuteReader();//veritabanındaki kayıtları okuduk
            DataTable dataTable = new DataTable();//Okuduğumuz kayıtları yükleyeceğimiz data tabloyu oluşturduk
            dataTable.Load(reader);//data tabloya veritabanından çektiğimiz kayıtları yükledik
            reader.Close();//veri okuyucuyu kapattık
            connection.Close();
            return dataTable;//kayıtların yüklendiği data tabloyu geriye döndürdük
        }

        public int Add(Product product)
        {
            ConnectionKontrol();
            SqlCommand command = new SqlCommand("Insert into Products values (@UrunAdi, @UrunFiyati, @StokMiktari)", connection);
            command.Parameters.AddWithValue("@UrunAdi", product.UrunAdi);
            command.Parameters.AddWithValue("@UrunFiyati", product.UrunFiyati);
            command.Parameters.AddWithValue("@StokMiktari", product.StokMiktari);
            var sonuc = command.ExecuteNonQuery(); // sorguyu çalıştır
            command.Dispose();
            connection.Close();
            return sonuc;
        }

        public int Update(Product product)
        {
            ConnectionKontrol();
            SqlCommand command = new SqlCommand("Update Products set UrunAdi=@Adi, UrunFiyati=@UrunFiyati, StokMiktari=@StokMiktari where Id=@id", connection);
            command.Parameters.AddWithValue("@Adi", product.UrunAdi);
            command.Parameters.AddWithValue("@UrunFiyati", product.UrunFiyati);
            command.Parameters.AddWithValue("@StokMiktari", product.StokMiktari);
            command.Parameters.AddWithValue("@id", product.Id);
            var sonuc = command.ExecuteNonQuery(); // sorguyu çalıştır
            command.Dispose();
            connection.Close();
            return sonuc;
        }

        public int Delete(int id)
        {
            ConnectionKontrol();
            SqlCommand command = new SqlCommand("Delete from Products where Id=@id", connection);
            command.Parameters.AddWithValue("@id", id);
            var sonuc = command.ExecuteNonQuery(); // sorguyu çalıştır
            command.Dispose();
            connection.Close();
            return sonuc;
        }

    }
}
