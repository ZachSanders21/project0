using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;
using PizzaWorld.Storing;

namespace PizzaWorld.Client
{
    public class SqlClient
    {
        private readonly PizzaWorldContext _db = new PizzaWorldContext();

        public IEnumerable<Store> ReadStores()
        {
            return _db.Stores;
        }
        public IEnumerable<Topping> ReadToppings()
        {
            return _db.Toppings; 
        }

        public Store ReadOne(string name)
        {
            var s = _db.Stores.FirstOrDefault(s => s.Name == name);
            return s;
        }
        public IEnumerable<Order> ReadOrders(Store store)
        {
            var s = ReadOne(store.Name);

            return s.Orders;
        }
        // public IEnumerable<APizzaModel> ListPizzas()
        // {
        //     return _db.Pizzas;
        // }
        public void Update()
        {
            _db.SaveChanges();
        }

        public Store SelectStore()
        {
            string input = Console.ReadLine();
            return ReadOne(input);
        }
        public void UserOrderHistroy(User user)
        {
            var u = _db.Users
                       .Include(u => u.Orders)
                       .ThenInclude(o => o.Pizzas)
                       .ThenInclude(p => p.Crust)
                       .FirstOrDefault(u => u.EntityID == user.EntityID);
            var o = u.Orders.LastOrDefault();
            var p = o.Pizzas.LastOrDefault().Crust;
            
        }
    }
}