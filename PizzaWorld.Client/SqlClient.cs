using System;
using System.Collections.Generic;
using System.Linq;
using PizzaWorld.Domain.Models;
using PizzaWorld.Storing;

namespace PizzaWorld.Client
{
    public class SqlClient
    {
        private readonly PizzaWorldContext _db = new PizzaWorldContext();
        public List<Store> Stores { get; set; }
        public SqlClient()
        {
            while (ReadStores().Count() < 2)
            {
                CreateStore();
            }
        }
        public IEnumerable<Store> ReadStores()
        {
            return _db.Stores;
        }
        private void ReadListStores()
        {
            Stores = _db.Stores.ToList<Store>();
        }
        public void Save(Store store)
        {
            _db.Add(store);
            _db.SaveChanges();
        }
        public void CreateStore()
        {
            Save(new Store());
        }
        public Store SelectStore()
        {
            int.TryParse(Console.ReadLine(), out int input); // 0 or selection

            return Stores.ElementAtOrDefault(input - 1);

        }
    }
}