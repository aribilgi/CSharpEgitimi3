using System;

namespace Ders15KapsullemeEncapsulation
{
    //Metot kullanarak kapsülleme
    public class Bolum
    {
        private string BolumAdi;//dışarıdan erişime kapalı değişkenimiz. 
        //Accessor (Getter)
        public string GetBolumAdi()
        {
            return BolumAdi;//Geriye private BolumAdi değişkenini döndüren metot
        }
        //Mutator (Setter)
        public void SetBolumAdi(string a)//Dışarıdan aldığı a parametresini BolumAdi değişkenine atayan metot
        {
            if (a == "Yazılım Mühendisliği")
            {
                Console.WriteLine("Üniversitemizde {0} bölümü bulunmamaktadır!", a);
            }
            else BolumAdi = a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kapsülleme Encapsulation!");

            //Bolum bolum = new();
            //Console.WriteLine("Lütfen Bölüm Adını Giriniz;");
            //var bolumAdi = Console.ReadLine();//ekrandan alınan değeri okuyup var  ile oluşturduğumuz bolumadi değişkenine atadık
            //bolum.SetBolumAdi(bolumAdi);//bolum içerisindeki SetBolumAdi metoduna bölüm adını gönderdik, private değişkene atama yapıldı
            //Console.WriteLine("Bölüm adı : " + bolum.GetBolumAdi());//bolum içerisindeki GetBolumAdi() metodunu direk ekrana yazdırdık çünkü GetBolumAdi()

            //Fakulte fakulte = new();
            //fakulte.Bolum = "Bilgisayar Mühendisliği";

            //Console.WriteLine("Fakülte = {0} {1}", fakulte.Bolum, "2.değer");

            Universite universite = new("Maliye");//Universite classında bir nesne oluşturduğumuzda artık bu nesneye bir değer göndermeliyiz çünkü class ın kurucu metodunda parametrik hale getirdik sınıfı
            //universite.Bolum = "Yazılım";
            Console.WriteLine("Universite Bölümü : " + universite.Bolum);

        }
    }
    //Özgen (Property) kullanarak kapsülleme
    public class Fakulte
    {
        private string bolum;//Fakülte sınıfının içindeki bolum değişkenini private tanımlayarak kapsüllemiş olduk, böylece bu değişkene sadece aşağıdaki get, set metotlarıyla erişilebilir
        public string Bolum
        {
            get { return bolum; }//get bloğu içindeki return(dön) komutundan anlaşılacağı üzere geriye içerdeki private tanımladığımız kapsüllenen bolum değişkenine atanan veriyi döndürür
            set
            {
                if (value == "Yazılım Mühendisliği")
                {
                    Console.WriteLine("Üniversitemizde {0} bölümü bulunmamaktadır!", value);
                }
                else bolum = value;
            }//set bloğu ise dışarıya açık Bolum değişkenine atanan veriyi alıp içerde kapsüllediğimiz private bolum değişkenine atar
        }
    }

    //Yalnız okunur (Read only property)
    public class Universite
    {
        private string bolum;
        public Universite(string str)
        {
            bolum = str;
        }
        public string Bolum
        {
            get { return bolum; }//burada set bloğu kullanmadık o yüzden dışarıdan veri atamasına kapalıdır 
        }
    }

}
