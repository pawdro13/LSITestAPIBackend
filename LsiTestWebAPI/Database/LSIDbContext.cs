using LsiTestWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace LsiTestWebAPI.Database
{
    public class LSIDbContext : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlServer("ConnectionStrings:DefaultConnection");

        public LSIDbContext(DbContextOptions<LSIDbContext> options) : base(options)
        {
        }
        public DbSet<Report> Reports { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // reports
            modelBuilder.Entity<Report>().HasData(new Report[]
            {
            // reports
            new Report { Id = 1, Name = "Raport 1", DateOfRaport = DateTime.Now, LocalName = "Lokal 1", UserName = "User 1" },
            new Report { Id = 2, Name = "Raport 1", DateOfRaport = DateTime.Now, LocalName = "Lokal 1", UserName = "User 1" },
            new Report { Id = 3, Name = "Raport 1", DateOfRaport = DateTime.Now, LocalName = "Lokal 1", UserName = "User 1" },
            new Report { Id = 4, Name = "Raport 1", DateOfRaport = DateTime.Now, LocalName = "Lokal 1", UserName = "User 1" },
            new Report { Id = 5, Name = "Raport 1", DateOfRaport = DateTime.Now, LocalName = "Lokal 1", UserName = "User 1" },
            new Report { Id = 6, Name = "Raport 1", DateOfRaport = DateTime.Now, LocalName = "Lokal 1", UserName = "User 1" }
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}