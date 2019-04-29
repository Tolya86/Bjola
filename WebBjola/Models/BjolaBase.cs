using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace WebBjola.Models
{
    public class BjolaBase: DbContext
    {
        public DbSet<Test> Tests { get; set; }

        public BjolaBase()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //DbConnection db;

           // optionsBuilder.UseMySQL()
            optionsBuilder.UseMySQL(@"server=localhost;database=bjola;user=root;password=");
        }


    }
}
