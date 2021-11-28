using System;

namespace Ders08SiniflarClasses
{
    class Ev //C# ta kendi sınıflarımızı bu şekilde oluşturabiliriz
    {
        public int KapiNo;
        public string SokakAdi;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sınıflar!");
            Ev evAdresi = new Ev();//Sınıftan nesne oluşturma
            evAdresi.KapiNo = 18; //Sınıftan oluşan nesnelere değer atama işlemi
            evAdresi.SokakAdi = "Arı sokak"; //Sınıftan oluşan nesnelere değer atama işlemi
            Console.WriteLine("Aylinin adresi : {0} No : {1} İstanbul", evAdresi.SokakAdi, evAdresi.KapiNo); //Sınıftan oluşan nesnelerin değerlerini okuma işlemi

            Ev yazlik = new()
            {
                SokakAdi = "Yalıkavak sokak",
                KapiNo = 1
            };
            Console.WriteLine($"Aylinin yazlık adresi : {yazlik.SokakAdi} No : {yazlik.KapiNo} Bodrum");

        }
    }
}
