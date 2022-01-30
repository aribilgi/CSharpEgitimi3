using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppEFCodeFirst.Entities;

namespace WindowsFormsAppEFCodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UrunDbContext context = new UrunDbContext();
        ProductDal productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             * EFCodeFirst kullanma
             * Entities klasörü oluşturup içine projede kullanacağımız class ları oluşturduk
             * Nugettan entity framework (Core olmayan!!!) paketini yükledik
             * UrunDbContext classını oluşturduk
             * App.config e connectionString ekledik (veritabanı bağlantı adresi için)
             */
            //dataGridView1.DataSource = context.Products.ToList();
            dataGridView1.DataSource = productDal.GetAll();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var eklendi = productDal.Add(new Product
            {
                StokMiktari = Convert.ToInt32(txtStokMiktari.Text),
                UrunAdi = txtUrunAdi.Text,
                UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text)
            });
            
            if (eklendi > 0)
            {
                dataGridView1.DataSource = productDal.GetAll();
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
            var sonuc = productDal.Update(new Product
            {
                Id = (int)dataGridView1.CurrentRow.Cells[0].Value,
                StokMiktari = Convert.ToInt32(txtStokMiktari.Text),
                UrunAdi = txtUrunAdi.Text,
                UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text)
            });

            if (sonuc > 0)
            {
                dataGridView1.DataSource = productDal.GetAll();
                MessageBox.Show("Kayıt Güncellendi!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var sonuc = productDal.Delete(new Product
            {
                Id = (int)dataGridView1.CurrentRow.Cells[0].Value
            });

            if (sonuc > 0)
            {
                dataGridView1.DataSource = productDal.GetAll();
                MessageBox.Show("Kayıt Silindi!");
            }
        }
    }
}
