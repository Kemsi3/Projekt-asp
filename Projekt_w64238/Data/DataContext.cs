using Microsoft.EntityFrameworkCore;
using Projekt_w64238.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projekt_w64238
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-BC3PM33\\SQLEXPRESS;database=Projekt;trusted_connection=true");
        }


        public DbSet<Car> Cars { get; set; }

        public DbSet<Rent> Rents { get; set; }

    }
}

