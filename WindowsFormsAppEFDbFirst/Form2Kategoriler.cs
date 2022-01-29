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
    public partial class Form2Kategoriler : Form
    {
        public Form2Kategoriler()
        {
            InitializeComponent();
        }
        UrunYonetimiAdoNetEntities UrunYonetimi = new UrunYonetimiAdoNetEntities();
        private void Form2Kategoriler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = UrunYonetimi.Kategoriler.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            UrunYonetimi.Kategoriler.Add(new Kategoriler
            {
                Durum = cbDurum.Checked,
                KategoriAdi = txtKategoriAdi.Text
            });
            var eklendi = UrunYonetimi.SaveChanges();
            if (eklendi > 0)
            {
                dataGridView1.DataSource = UrunYonetimi.Kategoriler.ToList();
                MessageBox.Show("Kayıt Eklendi");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            UrunYonetimi.Kategoriler.AddOrUpdate(new Kategoriler
            {
                Id = (int)dataGridView1.CurrentRow.Cells[0].Value,
                Durum = cbDurum.Checked,
                KategoriAdi = txtKategoriAdi.Text
            });
            var eklendi = UrunYonetimi.SaveChanges();
            if (eklendi > 0)
            {
                dataGridView1.DataSource = UrunYonetimi.Kategoriler.ToList();
                MessageBox.Show("Kayıt Güncelendi");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKategoriAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cbDurum.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[2].Value);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int KayitId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            var silinecekKayit = UrunYonetimi.Kategoriler.Find(KayitId);
            UrunYonetimi.Kategoriler.Remove(silinecekKayit);
            var sonuc = UrunYonetimi.SaveChanges();
            if (sonuc > 0)
            {
                dataGridView1.DataSource = UrunYonetimi.Kategoriler.ToList();
                MessageBox.Show("Kayıt Silindi");
            }
        }
    }
}
