using System;
using ClassLibrary_SinifKutuphanesi;

namespace Ders22ClassLibraryKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class Library Kullanımı!");

            Product product = new() { Name = "Klavye" };
            ProductDal productDal = new();
            productDal.Add(product);

            Console.WriteLine("Email adresinizi giriniz:");
            var email = Console.ReadLine();
            bool mailGonderildiMi = Metotlar.MailGonder(email);
            if (mailGonderildiMi == true)
            {
                Console.WriteLine(email + " adresine mail gönderildi!");
            }
            else Console.WriteLine(email + " adresine mail gönderilemedi!");

        }
    }
}
