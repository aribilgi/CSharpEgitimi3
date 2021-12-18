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

}
