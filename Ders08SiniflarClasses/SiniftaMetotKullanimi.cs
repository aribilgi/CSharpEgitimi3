using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders08SiniflarClasses
{
    public class SiniftaMetotKullanimi
    {
        string mesaj = "";
        public SiniftaMetotKullanimi() //klavyeden ctor tab tab kurucu metot oluşturur
        {
            //Burası kurucu metot
            mesaj = "Kurucu metot çalıştı";
            Console.WriteLine(mesaj);
        }

        public void ToplamaYap()
        {
            Console.WriteLine(10 + 8);
        }
        public static void ToplamaYap(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }
        public static string StatikDegisken = "Sınıfta statik değişken kullanımı";

    }
}
