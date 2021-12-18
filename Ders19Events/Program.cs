using System;

namespace Ders19Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Events!");

            Product laptop = new(30);
            laptop.ProductName = "Monster notebook";

            Product telefon = new(45);
            telefon.ProductName = "AyFon";
            telefon.StockControlEvent += Gsm_StockControlEvent;
            Console.WriteLine("Satış yapmak için adet girip enter a basın");
            int satisMiktari = int.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                laptop.Satis(satisMiktari);
                telefon.Satis(satisMiktari);
                satisMiktari = int.Parse(Console.ReadLine());
            }
        }
        private static void Gsm_StockControlEvent()
        {
            Console.WriteLine("Telefon stokları tükendi!");
        }

    }
}
