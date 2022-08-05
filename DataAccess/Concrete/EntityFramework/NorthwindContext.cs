using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //context:Veri tabanı ile kendi oluşturduğum classları ilişkilendirdiğimiz yapıdır.
   public class NorthwindContext:DbContext    //DbContext entity frameworkden gelen bir kod
    {
        //Bu method benim projem hangi veritabanıyla ilişki belirteceğimiz yerdir.override'i araştır.override üzerine yazmak demek."virtual-override"
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

    }


}
