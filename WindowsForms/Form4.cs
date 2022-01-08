using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Merhaba"); //winform ile ekrana mesaj verme
            DialogResult sonuc;//Mesaj penceresinde basılan tuşun değerini tutacak değişken
            sonuc = MessageBox.Show("Çıkmak İstiyor Musunuz?", "Uyarı", MessageBoxButtons.OKCancel);//MessageBox penceremize uyarıların yanısıra ok ve iptal tuşlarının çıkmasını sağlıyoruz
            if (sonuc == DialogResult.OK) this.Close();//Eğer mesaj penceresinde basılan tuş ok tuşu ise formu kapat
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstiyor Musunuz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK) this.Close();
        }
    }
}
