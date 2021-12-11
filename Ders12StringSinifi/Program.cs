using System;

namespace Ders12StringSinifi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Sinifi!");
            string degisken;
            char karakter = 'c';
            string metinlericin = "string ile metin yazabiliriz";

            Console.WriteLine(metinlericin);
            //Ornek1();
            Ornek2();
        }

        static void Ornek1()
        {
            string birMetin = "Angara başkanettir";
            String birSayi = "123456789";
            System.String tarih = "12.10.2021";

            string s = "Barış Manço";
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("s[" + i + "] = " + s[i]);
            }
            Console.WriteLine();
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
        }

        static void Ornek2()
        {
            string metin = "String Metotları ile Metin Düzenlemeleri";
            Console.WriteLine(metin);
            Console.WriteLine(metin.Length);
            Console.WriteLine(metin.EndsWith("i"));
            Console.WriteLine(metin.StartsWith("i"));
            Console.WriteLine(metin.IndexOf("i"));
            Console.WriteLine(metin.LastIndexOf("i"));
            Console.WriteLine(metin.Insert(0, "Konumuz : "));
            Console.WriteLine(metin.Substring(6, 10));
            Console.WriteLine(metin.ToLower());
            Console.WriteLine(metin.ToUpper());
            Console.WriteLine(metin.ToLower().Replace(" ", "-"));
            Console.WriteLine(metin.Remove(2, 5));
        }

    }
}
