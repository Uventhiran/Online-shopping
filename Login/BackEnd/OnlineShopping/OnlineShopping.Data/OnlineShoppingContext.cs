using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using OnlineShopping.Common.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Hosting;

namespace OnlineShopping.Data
{
    public class OnlineShoppingContext : DbContext
    {
        public OnlineShoppingContext(DbContextOptions<OnlineShoppingContext> options, IHostEnvironment host) : base(options)
        {
            if (host.IsDevelopment() || host.IsEnvironment("Test"))
            {
                return;
            }
            var conn = (SqlConnection)Database.GetDbConnection();
            
        }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=.;Database=OnlineShopping;Trusted_Connection=True;");
        }
    }
}
