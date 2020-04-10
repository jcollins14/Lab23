using System;
using System.Collections.Generic;
using System.Text;
using Lab23.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab23.DAL
{
    public class DALShopDBContext : DbContext
    {
        public DALShopDBContext()
        {

        }

        public DALShopDBContext(DbContextOptions<DALShopDBContext> options) : base(options)
        {
        }

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Item> Item { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Chocobo\\SQLEXPRESS;Database=ShopDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seed(modelBuilder);
        }

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .HasData((new Item[]
                {
                    new Item()
                    {
                        ID = 1,
                        CreatedOn = DateTime.Today,
                        LastUpdated = DateTime.Today,
                        Name = "Anodized Aluminum Case",
                        Quantity = 4,
                        Price = 88.37,
                        Desc = "An aluminum keyboard case colored via anodizing dye onto it."
                    },
                     new Item()
                    {
                        ID = 2,
                        CreatedOn = DateTime.Today,
                        LastUpdated = DateTime.Today,
                        Name = "60% Printed Circut Board (PCB)",
                        Quantity = 1,
                        Price = 45.30,
                        Desc = "A circuit board used to create a medium sized keyboard."
                    },
                      new Item()
                    {
                        ID = 3,
                        CreatedOn = DateTime.Today,
                        LastUpdated = DateTime.Today,
                        Name = "75% Printed Circuit Board (PCB)",
                        Quantity = 3,
                        Price = 52.99,
                        Desc = "A circuit board used to create a slightly larger keyboard."
                    },
                       new Item()
                    {
                        ID = 4,
                        CreatedOn = DateTime.Today,
                        LastUpdated = DateTime.Today,
                        Name = "Tactile Mechanical Switches",
                        Quantity = 300,
                        Price = 3.5,
                        Desc = "Keyboard switches to be used as buttons. Has a nice tactile bump to it. Moderately quiet. Comes in packs of 10!"
                    },
                        new Item()
                    {
                        ID = 5,
                        CreatedOn = DateTime.Today,
                        LastUpdated = DateTime.Today,
                        Name = "Linear Mechanical Switches",
                        Quantity = 0,
                        Price = 3.5,
                        Desc = "Keyboard switches to be used as buttons. No tactile feedback. Silent. Comes in packs of 10!"
                    },
                         new Item()
                    {
                        ID = 6,
                        CreatedOn = DateTime.Today,
                        LastUpdated = DateTime.Today,
                        Name = "Clicky Mechanical Switches",
                        Quantity = 100,
                        Price = 3.5,
                        Desc = "Keyboard switches to be used as buttons. Has tactile and auditory feedback. Loud. Comes in packs of 10!"
                    },
                }));
        }
    }

}
