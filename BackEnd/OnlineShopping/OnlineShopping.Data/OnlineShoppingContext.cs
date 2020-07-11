using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using OnlineShopping.Common.Entities;

namespace OnlineShopping.Data
{
    public class OnlineShoppingContext : DbContext
    {
        public DbSet<User> user { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=OnlineShopping;Trusted_Connection=True;");
        }
    }
}
