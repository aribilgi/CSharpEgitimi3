using System;

namespace Ders04Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operatorler!");
            //1-Aritmetik Operatörler
            int a = 50;
            int b = 20;
            int c = 30;

            int sonuc = a + b;
            int sonuc1 = a - b;
            int sonuc2 = a * b;
            float sonuc3 = (float)a / (float)b;

            int sonuc4 = a % b;
            c--; //c nin değerini 1 azalt
            int sonuc5 = c;

            b++; //b nin değerini 1 artır
            int sonuc6 = b;

            Console.WriteLine("a + b " + sonuc);
            Console.WriteLine("a - b " + sonuc1);
            Console.WriteLine("a * b " + sonuc2);
            Console.WriteLine("a / b " + sonuc3);
            Console.WriteLine("a % b " + sonuc4);
            Console.WriteLine("c-- " + sonuc5);
            Console.WriteLine("b++ " + sonuc6);

            Console.WriteLine("2- Atama Operatörleri (=,+=,-=,*=,/=,%=)"); //

            Console.WriteLine(a = a + b);
            Console.WriteLine(a += b);
            Console.WriteLine(a -= b);
            Console.WriteLine(a *= b);
            Console.WriteLine(a /= b);
            Console.WriteLine(a %= b);

            Console.WriteLine("3-İlişkisel Operatörler (==,!=,<,>,<=,>=,?:)");//

            Console.WriteLine($"a({a}) b({b}) ye eşit mi " + (a == b)); //
            Console.WriteLine($"a({a}) b({b}) ye eşit değil mi " + (a != b)); //
            Console.WriteLine($"a({a}) b({b}) den büyük mü " + (a > b)); //
            Console.WriteLine($"a({a}) b({b}) den küçük mü " + (a < b));// 
            Console.WriteLine($"a({a}) b({b}) den küçük mü veya b ye eşit mi" +(a <= b)); //
            Console.WriteLine($"a({a}) b({b}) den büyük mü veya eşit mi " + (a >= b)); //

            Console.WriteLine((a == b) ? "a b ye eşit" : "a b ye eşit değil");

            //Mantıksal Operatörler
            Console.WriteLine((5 > 3) && (4 > 5)); // && Ve operatörü

            Console.WriteLine((5 > 3) || (5 > 7)); // || Veya Operatörü (altgr + <)

            Console.WriteLine(!(5 > 3));
        }
    }
}
