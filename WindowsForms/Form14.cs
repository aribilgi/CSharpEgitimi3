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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Dosya Seçiniz";
            openFileDialog1.Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.bmp)|*.bmp";//dosya açma penceresinde listelenecek dosya uzantıları
            openFileDialog1.FilterIndex = 1;//varsayılan olarak jpg uzntılarını göster
            //openFileDialog1.InitialDirectory = "C:\\";//varsayılan olarak açılması istenen dizin ayarı
            //openFileDialog1.ShowDialog();//dosya seçme penceresini aç
            //label1.Text = openFileDialog1.FileName;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)//eğer dialog penceresi açılır ve bir dosya seçilirse
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;//seçilen resmi pictureBox1 kontrolüne sığdır
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);//pictureBox1 e seçilen resmi yükle
                label1.Text = openFileDialog1.FileName;//label1 e seçilen resmin adını yazdır
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Klasör seçiniz";
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                label2.Text = "Seçilen klasörün yolu : " + folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
