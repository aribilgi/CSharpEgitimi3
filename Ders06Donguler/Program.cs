using System;

namespace Ders06Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Döngüler!");
            //Console.WriteLine("1");
            //Console.WriteLine("2");
            //Console.WriteLine("3");
            //Console.WriteLine("4");
            //Console.WriteLine("5");

            /*Console.WriteLine("For Döngüsü");            
            for (int i = 0; i < 10; i++)//i değişkeni oluştur ve 0 değerini ata; i 10 dan küçük olduğu sürece dön; her dönüşte i yi 1 artır i++ ile
            {
                Console.WriteLine("i değişkeninin değeri {0}", i);
            }*/

            Console.WriteLine("While Döngüsü");
            int i = 0;
            while (i < 5) //While döngüsünün şartı bu şekilde, anlamı toplam küçükse 5 den sürekli dön
            {
                Console.WriteLine("While Sayı {0}", i);//toplamın değerini ekrana yazdırıyoruz
                i++;//toplam sayısını arttırıyoruz ki sonsuz döngüye girmesin program
            }

        }
    }
}
