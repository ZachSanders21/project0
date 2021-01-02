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
            Console.WriteLine("Select Store:");
            foreach(var store in _sql.ReadStores())
            {
                Console.WriteLine(store);
            }
        }
        static void PrintAllTopping()
        {
            foreach(var topping in _sql.ReadToppings())
            {
                Console.WriteLine(topping);
            }
        }
        static void PrintPizzas()
        {
            Console.WriteLine("Select Pizza:");
            Console.WriteLine("Hawaian Pizza");
            Console.WriteLine("Meat Pizza");
            Console.WriteLine("Supreme Pizza");
            Console.WriteLine("Veggie Pizza");
        }

        static void UserView()
        {
            User user = new User();

            PrintAllStores();

            user.SelectedStore =_sql.SelectStore();
            user.SelectedStore.CreateOrder();
            PrintPizzas();
            PrintAllTopping();
            user.Orders.Add(user.SelectedStore.Orders.Last());
            user.Orders.Last().MakeMeatPizza("Small");
            user.Orders.Last().MakeHawaianPizza("Medium");

            _sql.Update();
            
            System.Console.WriteLine(user);

        }
    }
}
