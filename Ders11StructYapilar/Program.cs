using System;

namespace Ders11StructYapilar
{
    struct Yapi
    {
        //string ad = "ali";//struct kullanımında class dan farklı olarak öğelere başlangıç değeri atanamaz
        public int sayi;
        public string metin;
        public void Metot()
        {
            Console.WriteLine("yapı içindeki metot çalıştı");
        }
    }
    public struct StatikDegiskenKullanimi
    {
        public static string isim = "Veli"; //struct kullanımında oluşturduğumuz değişkenlere başlangıç değeri vermek istiyorsak değişkenlere static niteliği eklememiz gerekiyor
        public static int yas = 18;
        struct Kimlik // StatikDegiskenKullanimi struct ının içine Kimlik isminde bir struct daha oluşturduk
        {
            //Kimlik struct'ının değişkenleri
            public string ad;
            public string soyad;
            public int yas;
            public string dogumyeri;
        }
    }
    class Program
    {
        string ad = "ali";
        static void Main(string[] args)
        {
            Console.WriteLine("Struct Yapılar!");
            Yapi ilkyapi = new();
            ilkyapi.metin = "yapı metni";
            ilkyapi.sayi = 18;
            ilkyapi.Metot();
            Console.WriteLine(ilkyapi.metin);

            Console.WriteLine("StatikDegiskenKullanimi.isim : " + StatikDegiskenKullanimi.isim);
            Console.WriteLine("StatikDegiskenKullanimi.yas : " + StatikDegiskenKullanimi.yas);
        }
    }
}
