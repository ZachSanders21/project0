using System;
using System.Collections.Generic;
using System.Linq;
using PizzaWorld.Domain.Models;
using PizzaWorld.Domain.Singletons;

namespace PizzaWorld.Client
{
    class Program
    {
        private static readonly ClientSingleton _client = ClientSingleton.Instance;
        private static readonly SqlClient _sql = new SqlClient();


        static void Main(string[] args)
        {
           UserView();

        }
        
        static void PrintAllStores()
        {
            foreach(var store in _sql.ReadStores())
            {
                Console.WriteLine(store);
            }
        }

        static void UserView()
        {
            var user = new User();

            PrintAllStores();

            user.SelectedStore =_sql.SelectStore();
           // user.SelectedStore.PrintPizza();
            user.SelectedStore.CreateOrder();
           // user.Orders.Add(user.SelectedStore.Orders.Last());
            // while user.SelectPizza()
           // user.Orders.Last().MakeMeatPizza();
            System.Console.WriteLine(user);

        }
    }
}
