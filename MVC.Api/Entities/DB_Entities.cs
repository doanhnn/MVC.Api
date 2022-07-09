using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using MVC.API.Models;

namespace MVC.API.Entities
{
    public class DB_Entities : DbContext
    {
        public DB_Entities() : base("Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;") { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
