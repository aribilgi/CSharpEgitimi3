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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random renk = new Random();//renk isminde rasgele sayı üreten random nesnesi oluşturuldu
            this.BackColor = Color.FromArgb(renk.Next(1, 100), renk.Next(1, 100), renk.Next(1, 100));//Burada this sınıfı geçerli formu i temsil ediyor. Form3 ün arkaplan rengine rasgele 1 ile 100 arası RGB renk kodlarını oluşturacak sayılar üretilecek
        }
    }
}
