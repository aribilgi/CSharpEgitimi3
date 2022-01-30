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
    public partial class Form2Kategoriler : Form
    {
        public Form2Kategoriler()
        {
            InitializeComponent();
        }
        KategoriDAL kategoriDAL = new KategoriDAL();        
        private void Form2Kategoriler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = kategoriDAL.GetAll();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            kategoriDAL.Add(new Kategori { Durum = cbDurum.Checked, KategoriAdi = txtKategoriAdi.Text });
            dataGridView1.DataSource = kategoriDAL.GetAll();
            MessageBox.Show("Kategori Eklendi!");
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKategoriAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cbDurum.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[2].Value);
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            kategoriDAL.Update(
                new Kategori
                {
                    Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                    KategoriAdi = txtKategoriAdi.Text,
                    Durum = Convert.ToBoolean(cbDurum.Checked)
                }
                );
            dataGridView1.DataSource = kategoriDAL.GetAll();
            MessageBox.Show("Kategori Başarıyla Güncellendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                kategoriDAL.Delete(new Kategori
                {
                    Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)
                });
                dataGridView1.DataSource = kategoriDAL.GetAll();
                MessageBox.Show("Kategori Başarıyla Silindi");
            }
        }
    }
}
