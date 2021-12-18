using System;
using System.Collections;
using System.Collections.Generic;
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
            //Ornek5();
            //Ornek6();
            //Ornek7();
            //Ornek8();
            //Ornek9();
            ListKullanimi();
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
        static void Ornek6()
        {
            //Stack sınıfı programlamada LIFO (last in first out) son giren ilk çıkar diye bilinen önemli bir yapıdır
            Stack stekobje = new Stack();
            stekobje.Push("Çankırı");//Stack e bir öğe eklemek için push metodu kullanılır
            stekobje.Push("İstanbul");
            stekobje.Push("Angara");
            stekobje.Push("Sivas");
            stekobje.Push("Balıkesir");

            while (stekobje.Count > 0)
            {
                Console.WriteLine(stekobje.Pop());//Stack in üstünden bir öğe çekmek için pop metodu kullanılır
            }
        }
        static void Ornek7()
        {
            Queue queue = new Queue();//Queue sınıfı programlamada FIFO(First in first out, ilk giren ilk çıkar) diye bilinen bir yapısıdır.
            queue.Enqueue("Lale");
            queue.Enqueue("Gül");
            queue.Enqueue("Sümbül");
            queue.Enqueue("Menekşe");
            queue.Enqueue("Çiğdem");
            while (queue.Count > 0) Console.WriteLine(queue.Dequeue());
        }
        static void Ornek8()
        {
            //HashTable sınıfı object tiplerin hızla depolanması ve depodan hızla çekilmesi için kullanılan bir yöntemdir
            Hashtable hst = new();
            hst.Add(1, "Adana");
            hst.Add(2, "Adıyaman");
            hst.Add(3, "Afyon");
            hst.Add(4, "İztanbul");
            hst.Add(5, "Amasya");
            Console.WriteLine("Anahtarlar : ");
            foreach (var item in hst.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Aramak İçin Anahtar Girin : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(hst[n]);
        }
        static void Ornek9()
        {
            Dictionary<string, string> dictionary = new();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "masa");
            dictionary.Add("computer", "bilgisayar");
            Console.WriteLine(dictionary["table"]);
            Dictionary<int, string> keyValues = new();
            keyValues.Add(1, "Adana");
            keyValues.Add(18, "Çankırı");
            keyValues.Add(34, "İstanbul");
            Console.WriteLine(keyValues[18]);
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }
            Console.WriteLine(dictionary.ContainsKey("gozluk"));
            Console.WriteLine(dictionary.ContainsKey("table"));
        }
        class User
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        static void ListKullanimi()
        {
            List<string> sehirler = new(); // veri tipi string olan sehirler isminde liste oluşturduk
            sehirler.Add("Ankara");
            sehirler.Add("İstanbul");
            sehirler.Add("Çankırı");

            //Console.WriteLine(sehirler.Contains("Adana")); //sehirler listesi adana yı içeriyor mu?
            //Console.WriteLine(sehirler.Contains("İstanbul"));
            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }

            Console.WriteLine();
            List<User> users = new();

            users.Add(new User { Id = 1, FirstName = "Mesut" });
            users.Add(new User { Id = 2, FirstName = "Mahmut" });

            List<User> kullanicilar = new()
            {
                new User {Id = 1, FirstName = "Murat"},
                new User {Id = 2, FirstName = "Ömer"}
            };

            var yeniKullanici = new User
            {
                Id = 3,
                FirstName = "Pusat"
            };

            Console.WriteLine("kullanicilar listesinde yeniKullanici var mı : " + kullanicilar.Contains(yeniKullanici));
            kullanicilar.Add(yeniKullanici); // kullanicilar listesine yeniKullanici yı ekle
            Console.WriteLine("kullanicilar listesinde yeniKullanici var mı : " + kullanicilar.Contains(yeniKullanici));
            // AddRange metoduyla çoklu kayıt ekleyebiliriz
            kullanicilar.AddRange(new User[2]
            {
                new User {Id = 4, FirstName = "Murat", LastName = "Yılmaz"},
                new User {Id = 5, FirstName = "Yunus", LastName = "Bektaş"}
            });

            kullanicilar.AddRange(users); // Bir listeye bir başka listeyi ekleyebiliriz

            Console.WriteLine();

            var index = kullanicilar.IndexOf(yeniKullanici);//kullanicilar listesinde yeniKullanici nesnesinin kaçıncı sırada(index olarak) geçtiğini yakalayıp index değişkenine atadık
            Console.WriteLine("yeniKullanici Index No : {0}", index);

            kullanicilar.Add(yeniKullanici);
            var index2 = kullanicilar.LastIndexOf(yeniKullanici);
            Console.WriteLine("yeniKullanici Son Index No : {0}", index2);

            kullanicilar.Insert(2, yeniKullanici); // Insert metodu listede istediğim sıraya ekleme yapmamızı sağlar

            Console.WriteLine();

            kullanicilar.Remove(yeniKullanici); // Remove metodu ile listeden eleman silinir

            var count = kullanicilar.Count; // Count metodu listedeki eleman sayısını verir
            Console.WriteLine("Listedeki kullanıcı sayısı : {0}", count);
        }
    }
}
