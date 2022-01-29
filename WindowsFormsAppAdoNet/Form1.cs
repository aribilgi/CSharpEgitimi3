using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppAdoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDAL productDAL = new ProductDAL();
        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = productDAL.GetAll();
            dataGridView1.DataSource = productDAL.GetAllDataTable();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            /*Product product = new Product
            {
                StokMiktari = Convert.ToInt32(txtStokMiktari.Text),
                UrunAdi = txtUrunAdi.Text,
                UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text)
            };
            productDAL.Add(product);
            */

            var eklendi = productDAL.Add(new Product
            {
                StokMiktari = Convert.ToInt32(txtStokMiktari.Text),
                UrunAdi = txtUrunAdi.Text,
                UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text)
            });
            if (eklendi > 0)
            {
                dataGridView1.DataSource = productDAL.GetAllDataTable();
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
            var sonuc = productDAL.Update(new Product
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                StokMiktari = Convert.ToInt32(txtStokMiktari.Text),
                UrunAdi = txtUrunAdi.Text,
                UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text)
            });
            if (sonuc > 0)
            {
                dataGridView1.DataSource = productDAL.GetAllDataTable();
                MessageBox.Show("Kayıt Güncellendi!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                var sonuc = productDAL.Delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                if (sonuc > 0)
                {
                    dataGridView1.DataSource = productDAL.GetAllDataTable();
                    MessageBox.Show("Kayıt Silindi!");
                }
            }
        }
    }
}
