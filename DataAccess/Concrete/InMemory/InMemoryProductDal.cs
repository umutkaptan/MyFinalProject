﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal       //Ürünle ilgili veri erişim kodlarının yazılacağı yer
    {

        List<Product> _products;         //Global değişkenleri alt çizgi ile veririz.Classın içinde methodların dışında tanımlananlara denir.
        public InMemoryProductDal()       //Constructor bellekte referans aldığı zaman çalışıcak blok idi.
        {
           // Oracle, Sql Server, Postgres, MongoDb den geliyormuş gibi simüle ediyoruz.
            _products = new List<Product> { 
            new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
            new Product{ProductId=2,CategoryId=1,ProductName="Kamera",UnitPrice=500,UnitsInStock=3},
            new Product{ProductId=3,CategoryId=2,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2},
            new Product{ProductId=4,CategoryId=2,ProductName="Klavye",UnitPrice=150,UnitsInStock=65},
            new Product{ProductId=5,CategoryId=2,ProductName="Fare",UnitPrice=85,UnitsInStock=1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ - Language Integrated  Query

            Product productToDelete =  _products.SingleOrDefault(p=>p.ProductId==product.ProductId);

            _products.Remove(productToDelete);      //Remove kaldırma kodu productToDelete bizim verdiğimiz kaldırılacak ürün demek.
            //SingleOrDefault tek bir eleman bulmaya yarar.Bizim yerimize productı tek tek dolaşmaya yarar.p tek tek dolaşırken verdiğimiz takma isim.Kod foreach gibi çalışıyor.
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();    //Where içindeki şarta uyan bütün elemanları yeni bir liste haline getirir ve onu döndürür.
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            
        }
    }
}
