using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        //bu method senin projen hangi veritabanı ile ilişkiyi belirteceğin yer olacak. OnConfiguring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //override on yaz, bu method bloğu gelir
        {
            //base.OnConfiguring(optionsBuilder); //DbContext'in OnConfiguring'ini çalıştırır, buna ihtiyacımız yok. Yorum satırına aldım.
            //optionsBuilder.UseSqlServer(@"Server=175.42.2.12"); //Normalde böyle olur ama biz direkt localden alacağımız için böyle yapmayacaz.
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true;") ;
        }
        public DbSet<Product> Products { get; set; } //Benim Product nesnemi veritabanındaki Products ile bağla.
        public DbSet<Category> Categories { get; set; } //Benim Category nesnemi veritabanındaki Categories ile bağla.
        public DbSet<Customer> Customers { get; set; } //Benim Customer nesnemi veritabanındaki Customers ile bağla.
    }
}
