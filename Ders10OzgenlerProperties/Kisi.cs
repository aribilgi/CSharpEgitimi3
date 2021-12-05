using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10OzgenlerProperties
{
    class Kisi
    {
        private int yas;
        private string dogumyeri;
        private string meslek;
        private double maas;

        public double Maas
        {
            get { return maas; } // yukarda tanımladığımız private maas değişkeninin değerini dışarıya(Programımızda nerde çağırdıysak oraya) gönderir
            set
            {
                if (value <= 2825) //Eğer private double maas; değişkenine dışarıdan 0 dan küçük bir  değer gönderilirse maas değişkeninin değerini 1 yap
                {
                    maas = 2825;
                }
                else maas = value;//if şartı geçersizse dışardan gönderilen değeri içerdeki maas değişkenine ata
            }
        }

        public int Yas
        {
            get { return yas; }
            set
            {//set bloğunda dışarıdan gelen value değerine göre işlem yaptırabiliriz
                if (value <= 65 && value >= 18) yas = value;
                else yas = 18;
            }
        }

        public string DogumYeri
        {
            get { return dogumyeri; }
            set { dogumyeri = value; }
        }

    }
}
