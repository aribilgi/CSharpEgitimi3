using System;

namespace Ders16InterfacesArayuzler
{
    //Arayüzler (Interfaces)
    /* Arayüz nedir?
     * C# dilinde arayüz soyut bir veri tipidir. Sınıfa benzer şekilde bildirilir ancak içerdiği öğelerin tanımı değil yalnızca imzaları vardır.
     ** Interface ler öğe olarak şunları içerebilir;
     * Özgen imzaları(properties)
     * Metot imzaları
     * Delegeler
     * Olaylar(events)
     * İndexçiler
     * *Arayüzler öğe olarak şunları içeremezler!
     * Alan-değişken(field)
     * Kurucu
     * Yokedici
     * -Arayüz asla içerdiği öğeleri tanımlamaz; öyle olmasının nedeni bir arayüz farklı sınıflar tarafından farklı amaçlarla kullanılabilir. Her sınıf kullandığı (implement) arayüzün öğelerini kendi amacına göre tanımlar.
     * 
     * Arayüzler için geçerli kurallar
     * 
     * Bir arayüzün erişim belirteci public tir
     * Bir arayüzün bütün öğelerinin erişim belirteci public tir
     * Bir arayüz bir yapı(struct) dan veya bir sınıf(class) tan kalıtımla türetilemez
     * Bir arayüz başka bir arayüzden veya başka arayüzlerden kalıtımsal olarak türetilebilir
     * Arayüz öğeleri static nitelemesini alamaz
     * Arayüzü kullanan bir sınıf arayüzün bütün öğelerinin açık tanımlarını vermek zorundadır
     * Arayüzü kullanan sınıfta arayüzün bütün öğeleri public erişim belirtecini alır
     * arayüz, nesnelere erişimi standart biçime sokar, nesnenin iç yapısını bilmeden nesneyi kullanma imkanı sunar
     */
    interface OrnekArayuz //Örnek arayüz oluşturma
    {
        int Id { get; set; }
    }
    interface IDemo
    {
        //Arayüz tanımlaması interface ifadesi ile yapılır ve yapacağı işleme göre I harfiyle başlayan bir isim verilir
        void Goster();//Interface lerde sadece metot imzaları yer alır, metotlar bu interface den miras alan class larda kullanılır
    }
    interface icerebilecekleri : IDemo//Bir interface in içerebileceği özellikler
    {
        public int sayi1 { get; set; }
        int sayi { get; set; }
        static int sayi2 { get; set; }
        void Topla();//interface ler metot imzalarını barındırabilir
        int ToplamaYap();
        //İçeremedikleri
        //string metin; //interfaceler içerisinde değişken kullanılamaz
        //interfaceler class lardaki kurucu metotları da kullanamaz
        int CikarmaYap()
        {
            int sayi1 = 5; int sayi2 = 10;
            return sayi2 - sayi1;
        }/**/
    }
    class arayuzKullanimi : icerebilecekleri
    {
        public int sayi1 { get; set; }

        public int sayi { get; set; }

        public void Goster()
        {
            Console.WriteLine(sayi);
        }

        public void Topla()
        {

        }

        public int ToplamaYap()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interfaces Arayuzler!");

            arayuzKullanimi arayuz = new();
            arayuz.sayi = 18;
            arayuz.Goster();

        }
    }
    interface ISinifGereksinimleri
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        DateTime CreateDate { get; set; }
        DateTime ChangeDate { get; set; }
        string User { get; set; }
    }
    interface IVeritabaniIslemleri
    {
        void Add();
        void Update();
        void Delete();
        void Get();
        void GetAll();
    }
    class Kategori : ISinifGereksinimleri, IVeritabaniIslemleri
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime ChangeDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string User { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Get()
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
    class Urun : ISinifGereksinimleri, IVeritabaniIslemleri
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime ChangeDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string User { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Get()
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }

}
