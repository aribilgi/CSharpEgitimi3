using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppAdoNet
{
    public class KategoriDAL
    {
        SqlConnection connection = new SqlConnection(@"server=(LocalDB)\MSSQLLocalDB; initial catalog=UrunYonetimiAdoNet; integrated security=true");

        void ConnectionKontrol()//Veritabanı bağlantısının açık olup olmadığını kontrol eden metot
        {
            if (connection.State == ConnectionState.Closed) //Yukardaki _connection bağlantı nesnemizin durumu bağlantı durumlarından kapalıya eşitse
            {
                connection.Open(); // Bağlantıyı aç
            }
        }

        public DataTable GetAllDataTable()
        {
            ConnectionKontrol();//Bağlantı kontrolü yaptık
            SqlCommand komut = new SqlCommand("select * from kategoriler", connection);//veritabanına sorgumuzu gönderdik
            SqlDataReader reader = komut.ExecuteReader();//veritabanındaki kayıtları okuduk
            DataTable dataTable = new DataTable();//Okuduğumuz kayıtları yükleyeceğimiz data tabloyu oluşturduk
            dataTable.Load(reader);//data tabloya veritabanından çektiğimiz kayıtları yükledik
            reader.Close();//veri okuyucuyu kapattık
            connection.Close();
            return dataTable;//kayıtların yüklendiği data tabloyu geriye döndürdük
        }

        public void Add(Kategori kategori)
        {
            ConnectionKontrol();
            SqlCommand command = new SqlCommand("Insert into Kategoriler values (@KategoriAdi,@Durum)", connection);
            command.Parameters.AddWithValue("@KategoriAdi", kategori.KategoriAdi);
            command.Parameters.AddWithValue("@Durum", kategori.Durum);
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
        }
        public void Update(Kategori kategori)
        {
            ConnectionKontrol();
            SqlCommand command = new SqlCommand("Update Kategoriler set KategoriAdi=@KatAdi, Durum=@Durum where Id=@id", connection);
            command.Parameters.AddWithValue("@KatAdi", kategori.KategoriAdi);
            command.Parameters.AddWithValue("@Durum", Convert.ToBoolean(kategori.Durum));
            command.Parameters.AddWithValue("@id", kategori.Id);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Delete(int id)
        {
            ConnectionKontrol();
            SqlCommand command = new SqlCommand("delete from Kategoriler where Id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            connection.Close();
        }

    }
}
