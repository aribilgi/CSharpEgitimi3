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
    }
}
