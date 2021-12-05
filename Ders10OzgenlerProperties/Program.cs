using System;

namespace Ders10OzgenlerProperties
{
    class Skorlar
    {
        private int skor;
        public int Skor //Örnek özgen yapısı
        {
            get { return skor; } //get bloğu geriye yukarıdaki skor değişkeninin değerini döndürür
            set { skor = value; } // set bloğu ise yukarıdaki skor değişkenine değer atamayı sağlar
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ozgenler Properties!");

            Skorlar skorlar = new Skorlar();
            skorlar.Skor = 5; //burada set bloğu çalışır

            Console.WriteLine("Skor değeri : " + skorlar.Skor); //skorlar.Skor ile değer okumaya kalkarsak get bloğu çalışır

            Kisi Aylin = new Kisi();
            Kisi Gizem = new Kisi();

            Aylin.DogumYeri = "Bodrum";
            Aylin.Yas = 25;
            Aylin.Maas = 3750;
            Gizem.DogumYeri = "Kuşadası";
            Gizem.Yas = 26;
            Gizem.Maas = -3000;

            Console.WriteLine("Aylin bilgiler ; Doğum yeri :" + Aylin.DogumYeri + ", Yaş = " + Aylin.Yas + ", Maaş : " + Aylin.Maas);
            Console.WriteLine($"Gizem bilgiler; Doğum yeri :{Gizem.DogumYeri}, Yaş = {Gizem.Yas}, Maaş: {Gizem.Maas}");

        }
    }
}
