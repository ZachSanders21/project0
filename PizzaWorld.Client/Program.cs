using System;
using System.Collections.Generic;
using System.Linq;
using PizzaWorld.Domain.Abstracts;
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
            UserStore();
            //UserView();

        }
        static void UserStore()
        {
            Console.WriteLine("Are you a 1. User\n2. Store");
            bool isvalid = false;
            while (isvalid == false)
            {
                int.TryParse(Console.ReadLine(), out int input);
                switch (input)
                {
                    case 1:
                        LogIn();
                        isvalid = true;
                        break;
                    case 2:
                        StoreLogIn();
                        isvalid = true;
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        UserStore();
                        break;
                }
            }
        }
        static void StoreLogIn()
        {
            PrintAllStores();
            //user.SelectedStore =_sql.SelectStore();

        }
        static void LogIn()
        {
            Console.WriteLine("Welcome!  Are you a new customer? (Y/n)");
            var input = Console.ReadLine();
            if (input == "y")
            {
                NewCustomerInfo();
            }
            else if (input == "n")
            {
                ReturningUser();
            }
            else 
            {
                Console.WriteLine("Invalid Input. Please Try again");
                LogIn(); // user while loops?
            }
        }
        static void NewCustomerInfo()
        {
            Console.WriteLine("Please Create a User");
            var input = Console.ReadLine().ToLower();
            User user = new User(input);
            _sql.NewUser(user);
            UserView(user);
        }
        static void ReturningUser()
        {
            Console.WriteLine("Please Log In");
            var input = Console.ReadLine().ToLower();
            User user = _sql.GetUser(input);
            if (user != null)
            {
                UserView(user);
            }
            else
            {
                Console.WriteLine("Invalid User. Please Try again");
                ReturningUser();
            }
        }
        static void PrintAllStores()
        {
            Console.WriteLine("Select Store:");
            foreach(var store in _sql.ReadStores())
            {
                Console.WriteLine(store);
            }
        }
        static void SelectPizza(User user)
        {
            Console.WriteLine("Please select your pizza \n1. Hawaian Pizza \n2. Meat Lovers Pizza \n3. Supreme Pizza \n4. Veggie Pizza");
            bool isvalidated = false;
            Size size; 
            string crust; 
            while (isvalidated == false)
            {
                int.TryParse(Console.ReadLine(), out int input);
                switch (input)
                {
                    case 1:
                        size = GetSize();
                        crust = GetCrust();
                        user.Orders.Last().MakeHawaianPizza(size, crust);
                        isvalidated = true;
                        break;
                    case 2:
                        size = GetSize();
                        crust = GetCrust();
                        user.Orders.Last().MakeMeatPizza(size, crust);
                        isvalidated = true;
                        break;
                    case 3:
                        size = GetSize();
                        crust = GetCrust();
                        user.Orders.Last().MakeSupremePizza(size, crust);
                        isvalidated = true;
                        break;
                    case 4:
                        size = GetSize();
                        crust = GetCrust();
                        user.Orders.Last().MakeVeggiePizza(size, crust);
                        isvalidated = true;
                        break;
                    default:
                        Console.WriteLine("Invalid selection.  Please try again.");
                        break;
                }
            }
            MultiplePizzas(user);
        }
        static void MultiplePizzas(User user)
        {
            Console.WriteLine("Would You like to: \n1. Buy more pizza \n2. Checkout \n3. Restart order");
            bool isvalid = false;
            while (isvalid == false)
            {
                int.TryParse(Console.ReadLine(), out int input);
                switch (input)
                {
                    case 1:
                        {
                            SelectPizza(user);
                            isvalid = true;
                            break;
                        }
                    case 2:
                        {
                            Checkout(user);
                            isvalid = true;
                            break;
                        }
                    case 3:
                        {
                            user.SelectedStore.DeleteOrder(user.SelectedStore.Orders.Last());
                            user.SelectedStore.CreateOrder();
                            user.Orders.Add(user.SelectedStore.Orders.Last());
                            SelectPizza(user);
                            isvalid = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid seelction. Please try again.");
                            break;
                        }
                }
            }
        }
        static void Checkout(User user)
        {
            Console.WriteLine($"This is your order: {user}\nWould you like to complete checkout? (Y/n)");
            var input = Console.ReadLine().ToLower();
            if (input == "y")
            {
                var test = user.Orders.Last().Pizzas;
                double totalsize = 0;
                foreach (APizzaModel Pizza in test)
                {
                    totalsize += Pizza.Size.Price;
                    foreach (Topping topping in Pizza.Toppings)
                    {
                        totalsize += topping.Price;
                    }
                }
                Console.WriteLine($"This is your price: {totalsize}");
            }
            else if (input == "n")
            {
                user.SelectedStore.DeleteOrder(user.SelectedStore.Orders.Last());
                user.SelectedStore.CreateOrder();
                user.Orders.Add(user.SelectedStore.Orders.Last());
                SelectPizza(user);
            }
            else 
            {
                Console.WriteLine("Invalid selection. Please try again");
                Checkout(user);
            }
        }
        static Size GetSize()
        {
            Console.WriteLine("Select Size \n1. Small \n2. Medium \n3. Large");
            while (true)
            {
                int.TryParse(Console.ReadLine(), out int size);
                switch (size)
                {
                    case 1:
                        return new Size("Small");
                    case 2:
                        return new Size("Medium");
                    case 3:
                        return new Size("Large");
                    default:
                        Console.WriteLine("Invalid selection.  Please try again.");
                        break;
                }
            }
        }
        
        static string GetCrust()
        {
            Console.WriteLine("Select Crust \n1. Garlic \n2. Sesame \n3. Butter \n4. Plain");
            while (true)
            {
                int.TryParse(Console.ReadLine(), out int size);
                switch (size)
                {
                    case 1:
                        return "Garlic";
                    case 2:
                        return "Sesame";
                    case 3:
                        return "Butter";
                    case 4:
                        return "Plain";  
                    default:
                        Console.WriteLine("Invalid selection.  Please try again.");
                        break;
                }
            }


        }
        static void NewOrder(User user)
        {
            Console.WriteLine("Would you like to make another order? (Y/n)");
            var input = Console.ReadLine().ToLower();
            if (input == "y")
            {
                UserView(user);
            }
            else if (input == "n")
            {
                Console.WriteLine("Have a nice day!");
            }
            else 
            {
                Console.WriteLine("Invalid selection. Please try again");
                NewOrder(user);
            }
        }
        

        static void UserView(User user)
        {

            PrintAllStores();

            user.SelectedStore =_sql.SelectStore();
            user.SelectedStore.CreateOrder();
            user.Orders.Add(user.SelectedStore.Orders.Last());
            SelectPizza(user);


            _sql.Update();
            
            System.Console.WriteLine("Order Successful!");
            NewOrder(user);
        }
    }
}
