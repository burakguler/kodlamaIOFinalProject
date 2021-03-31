using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    //databasecontext means that we are linking database tables with project's classes, these classes are the Entity classes
    public class DatabaseContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // this method's purpose is; you can declare which database you want to use in this project
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-9FLLE02\SQLEXPRESS;Database=Northwind;Integrated Security=True");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
