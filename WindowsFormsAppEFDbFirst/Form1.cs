using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEFDbFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UrunYonetimiAdoNetEntities UrunYonetimi = new UrunYonetimiAdoNetEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            //Entity Framework
            /*
             * Entity Framework ORM(Object Relational Mapping) araçlarından biridir.
             * Entity Framework ile 4 farklı yöntem kullanarak proje geliştirebilirsiniz.
             * 
             * Model First
             * Database First (Var Olan Veritabanını Kullanma)
             * Code First (Yeni Veritabanı Kod Yazarak)
             * Code First (Var Olan Veritabanını Kullanma)
             */
            dataGridView1.DataSource = UrunYonetimi.Products.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            UrunYonetimi.Products.Add(new Products
            {
                StokMiktari = Convert.ToInt32(txtStokMiktari.Text),
                UrunAdi = txtUrunAdi.Text,
                UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text)
            });
            var eklendi = UrunYonetimi.SaveChanges();
            if (eklendi > 0)
            {
                dataGridView1.DataSource = UrunYonetimi.Products.ToList();
                MessageBox.Show("Kayıt Eklendi!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtUrunFiyati.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtStokMiktari.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            UrunYonetimi.Products.AddOrUpdate(new Products
            {
                Id = (int)dataGridView1.CurrentRow.Cells[0].Value,
                StokMiktari = Convert.ToInt32(txtStokMiktari.Text),
                UrunAdi = txtUrunAdi.Text,
                UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text)
            });
            var eklendi = UrunYonetimi.SaveChanges();
            if (eklendi > 0)
            {
                dataGridView1.DataSource = UrunYonetimi.Products.ToList();
                MessageBox.Show("Kayıt Güncellendi!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int kayitId = (int)dataGridView1.CurrentRow.Cells[0].Value;

            var silinecekKayit = UrunYonetimi.Products.Find(kayitId); //Find metodu ef de kayıt bulmamızı sağlar
            UrunYonetimi.Products.Remove(silinecekKayit);
            var sonuc = UrunYonetimi.SaveChanges();
            if (sonuc > 0)
            {
                dataGridView1.DataSource = UrunYonetimi.Products.ToList();
                MessageBox.Show("Kayıt Silindi!");
            }
        }
    }
}
