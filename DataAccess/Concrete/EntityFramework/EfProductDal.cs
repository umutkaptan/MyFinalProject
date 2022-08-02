using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{

    //Başkalarının yazdığı kodları da kullanıyor olucaz.Bu kodların ortak koyulduğu ve yönetildiği ortamın adı NuGet.    
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            using (NorthwindContext context= new NorthwindContext())    //using tab tab yaptım.using yazdığımız şeyin işimiz bitince bellekten atılmasını sağlar.
            {
                var addedEntity = context.Entry(entity);  
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
                //var karşısına herhangi bir veri tipi atayabileceğimiz şey.string,int gibi.addedEntity bizim verdiğimiz değişken adı.
                //Entry frameworke özel.Git veri kaynağından benim bu gönderdiğim producta bir tane nesneyi eşleştir.State:durum
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())    
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
               
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                //filtre vermemişse ona göre ilgili tablodaki tüm datayı getir.filtre vermişse uygula ve ona göre datayı getir.ternary operator
                return filter == null ? context.Set<Product>().ToList() : context.Set<Product>().Where(filter).ToList();
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
