using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context:Db tabloları ile proje classlarını bağlamak
    public class NorthwindContext:DbContext
    {
        //Projenin hangi veritabanıyla ilişkili olduğunu belirttiğimiz metot.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Başa @ konulduğunda \'ı normal bir karakter olarak algılar.
            optionsBuilder.UseSqlServer(@"Server =(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public  DbSet<Customer> Customers { get; set; }


    }
}
