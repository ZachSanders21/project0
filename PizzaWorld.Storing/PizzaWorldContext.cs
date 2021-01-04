using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Storing
{
    public class PizzaWorldContext : DbContext
    {
        public DbSet<Store> Stores { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Topping> Toppings { get; set; }
        //public DbSet<APizzaModel> Pizzas { get; set; }
        public DbSet<Size> Sizes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=pizzaworldsanders.database.windows.net,1433;Initial Catalog=PizzaWorldDB;User ID=sqladmin;Password={};");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Store>().HasKey(s => s.EntityID);
            builder.Entity<User>().HasKey(u => u.EntityID);
            builder.Entity<APizzaModel>().HasKey(p => p.EntityID);
            builder.Entity<Order>().HasKey(o => o.EntityID);
            builder.Entity<Topping>().HasKey(t => t.EntityID);
            builder.Entity<Size>().HasKey(z => z.EntityID);

            SeedData(builder);
        }
        protected void SeedData(ModelBuilder builder)
        {
            builder.Entity<Store>().HasData(new List<Store>
            {
                new Store() { EntityID = 1, Name = "one"},
                new Store() { EntityID = 2, Name = "two"}
            }
            );
            // builder.Entity<Topping>().HasData(new List<Topping>
            // {
            //     new Topping() { EntityID = 1,  Name = "Pepperoni",  Price = 2},
            //     new Topping() { EntityID = 2,  Name = "Pineapple",  Price = 1},
            //     new Topping() { EntityID = 3,  Name = "Cheese",     Price = 3},
            //     new Topping() { EntityID = 4,  Name = "Sausage",    Price = 2},
            //     new Topping() { EntityID = 5,  Name = "Ham",        Price = 1},
            //     new Topping() { EntityID = 6,  Name = "Onion",      Price = 1},
            //     new Topping() { EntityID = 7,  Name = "Bacon",      Price = 3},
            //     new Topping() { EntityID = 8,  Name = "Chicken",    Price = 3},
            //     new Topping() { EntityID = 9,  Name = "Anchovi",    Price = 2},
            //     new Topping() { EntityID = 10, Name = "Cucumber",   Price = 1},
            //     new Topping() { EntityID = 11, Name = "Mushroom",   Price = 1},
            //     new Topping() { EntityID = 12, Name = "Spinach",    Price = 1}
            // }
            // );
            // builder.Entity<Size>().HasData(new List<Size>
            // {
            //     new Size() {EntityID = 1, Name = "Small", Price = 0},
            //     new Size() {EntityID = 2, Name = "Medium", Price = 2},
            //     new Size() {EntityID = 3, Name = "Large", Price = 4}
            // }
            // );

        }
    }
}