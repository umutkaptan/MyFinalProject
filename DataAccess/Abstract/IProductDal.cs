﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>       //Veri erişim işlerini yapacak interface..
    {
        //List<Product> GetAll();
        //void Add(Product product);
        //void Update(Product product);
        //void Delete(Product product);

        //List<Product> GetAllByCategory(int categoryId);         //Ürünleri kategoriye göre filtrelemek için yazdık.
         
        //Bu kodları kestik IEntityRepository'e attık.
    }
}