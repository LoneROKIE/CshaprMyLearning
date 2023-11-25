using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContosoPizza.Models;  

namespace ContosoPizza.Data
{
    public class ContosoPizzaContext : DbContext // DbContext es una clase que nos permite conectarnos a la base de datos
    {
        public DbSet<Customer> Customers { get; set; } = null!; // DbSet es una clase que nos permite crear una tabla en la base de datos 
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source =DuncanPC; Initial Catalog = ContosoPizza-Part1; Integrated Security = True; TrustServerCertificate=True");
        }


    }
}
