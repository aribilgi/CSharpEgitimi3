using System;
using System.Collections.Generic;

namespace Ders21Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generics!");

        }
    }
    //Generic kullanmadan interface yapısı
    interface IProductDal
    {
        List<Product> GetAll();
        Product Get(int id);
        void Add(Product entity);
        void Delete(Product entity);
        void Update(Product entity);
    }
    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
    interface ICategoryDal
    {
        List<Category> GetAll();
        Category Get(int id);
        void Add(Category entity);
        void Delete(Category entity);
        void Update(Category entity);
    }
    class CategoryDal : ICategoryDal
    {
        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public Category Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
    //Generic kullanarak interface yapısı
    interface IProductDal2 : IRepository<Product> //IRepository e parametre olarak product classını gönderdik böylece repositorydeki metotlar product için çalışacak
    {
        //Product a özel metot imzası ekleyebiliriz buraya
    }
    interface ICategoryDal2 : IRepository<Category> //IRepository e parametre olarak Category classını gönderdik böylece repositorydeki metotlar Category için çalışacak
    {
    }
    class ProductDal2 : IProductDal2
    {
        public void Add(Product entity)
        {
            Console.WriteLine("Ürün eklendi");
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
    class CategoryDal2 : ICategoryDal2
    {
        public void Add(Category entity)
        {
            Console.WriteLine("Kategori Eklendi");
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public Category Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
