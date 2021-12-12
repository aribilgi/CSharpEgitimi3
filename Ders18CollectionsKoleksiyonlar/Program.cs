using System;
using System.Collections;
using System.Collections.Specialized;

namespace Ders18CollectionsKoleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collections Koleksiyonlar!");
            //Ornek1();
            //Ornek2();
            //Ornek3();
            //Ornek4();
            Ornek5();
        }
        static void Ornek1()
        {
            ArrayList birDizi = new ArrayList();//Koleksiyonları kullanmak için System.Collections kütüphanesini using  kısmına eklememiz gerekiyor. ArrayList sınıf objelerinden oluşan array oluşturur.
            birDizi.Add(12);//Koleksiyona veri eklemek için Add() metodu kullanılıyor
            birDizi.Add(3);
            birDizi.Add(8);
            foreach (int n in birDizi)//Koleksiyondaki verileri ekrana yazmak için foreach döngüsü kullanıyoruz
            {
                Console.WriteLine(n);//Koleksiyon içindeki verileri döngüde tanımladığımız n değişkenine atayıp her dönüşte değerini ekrana yazdırıyoruz
            }
            Console.WriteLine(birDizi[0]);
        }
        static void Ornek2()
        {
            ArrayList birDizi = new ArrayList();
            birDizi.Add("Zonguldak");//Koleksiyona veriler atadık
            birDizi.Add("Sinop");
            birDizi.Add("Çankırı");
            birDizi.Add("Ankara");
            birDizi.Add("İstanbul");
            Console.WriteLine("Sıralanmamış Liste");
            foreach (var sehir in birDizi)
            {
                Console.WriteLine(sehir);//Koleksiyondaki verileri varsayılan haliyle ekrana yazdırdık
            }
            Console.WriteLine();

            Console.WriteLine("A dan Z ye Sıralanmış Liste");
            birDizi.Sort(); //Koleksiyondaki verileri Sort ile A dan Z ye sıraladık.
            foreach (var sehir in birDizi)
            {
                Console.WriteLine(sehir);//Koleksiyondaki verileri sıralanmış haliyle ekrana yazdırdık
            }
            Console.WriteLine();
            birDizi.Reverse(); //Koleksiyondaki verileri Reverse ile Z den A ya sıraladık.
            foreach (var item in birDizi)
            {
                Console.WriteLine(item);
            }
        }
        static void Ornek3()
        {
            //Koleksiyonlara farklı veri tiplerinden değerler atama
            int tamsayi = 10;
            double dabil = 18.8;
            ArrayList koleksiyon = new ArrayList();
            koleksiyon.Add("Başkent Angara");
            koleksiyon.Add(tamsayi);
            koleksiyon.Add(dabil);
            for (int index = 0; index < koleksiyon.Count; index++)
            {
                Console.WriteLine(koleksiyon[index]);
            }
        }
        static void Ornek4()
        {
            StringCollection strlist = new StringCollection();//string içeriklerden oluşacak koleksiyonlara özel StringCollection sınıfını kullanabiliriz
            strlist.Add("Çankırı");
            strlist.Add("Angara");
            strlist.Add("İstanbul");
            foreach (var item in strlist)
            {
                Console.WriteLine(item);
            }
        }
        static void Ornek5()
        {
            StringDictionary strlist = new StringDictionary();//string içeriklerden oluşacak koleksiyonlara özel StringDictionary sınıfını kullanabiliriz böylece verilere key ve value değerleri atanabilir
            strlist.Add("18", "Çankırı");
            strlist.Add("06", "Angara");
            strlist.Add("34", "İstanbul");
            strlist.Add("58", "Sivas");

            Console.WriteLine(strlist["06"]);

            foreach (var item in strlist.Values)
            {
                Console.WriteLine(item);
            }
            foreach (var item in strlist.Keys)
            {
                Console.WriteLine(item);
            }
        }
    }
}
