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
             * 
            for (int i = 0; i < 10; i++)//i değişkeni oluştur ve 0 değerini ata; i 10 dan küçük olduğu sürece dön; her dönüşte i yi 1 artır i++ ile
            {
                Console.WriteLine("i değişkeninin değeri {0}", i);
            }

            Console.WriteLine("While Döngüsü");
            int i = 0;
            while (i < 5) //While döngüsünün şartı bu şekilde, anlamı toplam küçükse 5 den sürekli dön
            {
                Console.WriteLine("While Sayı {0}", i);//toplamın değerini ekrana yazdırıyoruz
                i++;//toplam sayısını arttırıyoruz ki sonsuz döngüye girmesin program
            }
            
            Console.WriteLine("Do While Döngüsü");
            int toplam = 1;
            do
            {
                //Console.WriteLine("Veritabanına bağlan");
                //Console.WriteLine("Verileri Çek");
                Console.WriteLine("Do while Sayı {0}", toplam);//toplamın değerini ekrana yazdırıyoruz
                toplam++;//toplam sayısını arttırıyoruz ki sonsuz döngüye girmesin program
            }
            while (toplam < 1); //Do While döngüsünün şartı bu şekilde, anlamı toplam küçükse 10 dan sürekli dön
            */
            Console.WriteLine("Foreach Döngüsü");

            string[] kategoriler = { "Bilgisayar", "Elektronik", "Cep Telefonu", "Beyaz Eşya", "Kitap" };
            int[] ogrenciler2 = { 100, 200, 300 };
            Console.WriteLine("Kategoriler");
            foreach (var item in kategoriler)
            {
                Console.WriteLine(item);
            }
            foreach (var ogrenciNo in ogrenciler2)
            {
                Console.WriteLine("Öğrenci Numarası : " + ogrenciNo);
            }
            
            Console.WriteLine("İç İçe Foreach Döngüsü");

            string[] urunler = { "Klavye", "Mouse", "Monitör" };

            foreach (var isim in kategoriler)
            {
                Console.WriteLine("Kategori Adı : " + isim);
                foreach (var urun in urunler)
                {
                    Console.WriteLine("     Ürün Adı : " + urun);
                }
            }

            Console.WriteLine("İç İçe For Döngüsü");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("i değişkeninin değeri {0}", i);
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("\t j değişkeninin değeri {0} dır", j);
                }
            }


        }
    }
}
