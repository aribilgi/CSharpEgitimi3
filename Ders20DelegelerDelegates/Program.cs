using System;

namespace Ders20DelegelerDelegates
{
    class Vergiler
    {
        public double BrutOku()
        {
            Console.WriteLine("Brüt gelirinizi giriniz");
            return Double.Parse(Console.ReadLine());
        }
        public double GelirVergisiHesapla(double d)
        {
            if (d > 2825) return d * 0.40;
            else return d * 0.25;
        }
    }
    public delegate void BasitDelege();//Delege tanımlaması bu şekilde yapılıyor
    class Program
    {
        static void Topla()//Toplama yapan basit bir program
        {
            Console.WriteLine("10+8 = " + (10 + 8));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Delegeler Delegates!");
            //Delegeler metot işaret eden referanslardır
            //Vergiler vergi = new();
            //Console.WriteLine("Ödediğiniz Vergi : " + vergi.GelirVergisiHesapla(vergi.BrutOku()));
            //BasitDelege obj = new(Topla);//Delege ile statik metot çağırma işlemi yaptık
            //obj();
            Program u = new();
            ParametreliDelege pd = new(u.Topla);
            pd(10, 8);
        }
        public void Topla(int x, int y)
        {
            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
        }
        public delegate void ParametreliDelege(int a, int b);
        public delegate double Delege01();
        public delegate double Delege02(double dd);
    }
}
