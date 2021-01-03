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
            LogIn();
            //UserView();

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
                LogIn();
            }
        }
        static void NewCustomerInfo()
        {
            // User Transaction????
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
            while (isvalidated == false)
            {
                int.TryParse(Console.ReadLine(), out int input);
                switch (input)
                {
                    case 1:
                        {
                            Console.WriteLine("Select Size \n1. Large \n2. Medium \n3. Small");
                            bool isvalid = false;
                            while (isvalid == false)
                            {
                                int.TryParse(Console.ReadLine(), out int size);
                                switch (size)
                                {
                                    case 1:
                                        {
                                            user.Orders.Last().MakeHawaianPizza("Large");
                                            isvalid = true;
                                            break;
                                        }
                                    case 2:
                                        {
                                            user.Orders.Last().MakeHawaianPizza("Medium");
                                            isvalid = true;
                                            break;
                                        }
                                    case 3:
                                        {
                                            user.Orders.Last().MakeHawaianPizza("Small");
                                            isvalid = true;
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Invalid selection.  Please try again.");
                                            break;
                                        }
                                }
                            }
                            isvalidated = true;
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Select Size \n1. Large \n2. Medium \n3. Small");
                            bool isvalid = false;
                            while (isvalid == false)
                            {
                                int.TryParse(Console.ReadLine(), out int size);
                                switch (size)
                                {
                                    case 1:
                                        {
                                            user.Orders.Last().MakeMeatPizza("Large");
                                            isvalid = true;
                                            break;
                                        }
                                    case 2:
                                        {
                                            user.Orders.Last().MakeMeatPizza("Medium");
                                            isvalid = true;
                                            break;
                                        }
                                    case 3:
                                        {
                                            user.Orders.Last().MakeMeatPizza("Small");
                                            isvalid = true;
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Invalid selection.  Please try again.");
                                            break;
                                        }
                                }
                            }
                            isvalidated = true;
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Select Size \n1. Large \n2. Medium \n3. Small");
                            bool isvalid = false;
                            while (isvalid == false)
                            {
                                int.TryParse(Console.ReadLine(), out int size);
                                switch (size)
                                {
                                    case 1:
                                        {
                                            user.Orders.Last().MakeSupremePizza("Large");
                                            isvalid = true;
                                            break;
                                        }
                                    case 2:
                                        {
                                            user.Orders.Last().MakeSupremePizza("Medium");
                                            isvalid = true;
                                            break;
                                        }
                                    case 3:
                                        {
                                            user.Orders.Last().MakeSupremePizza("Small");
                                            isvalid = true;
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Invalid selection.  Please try again.");
                                            break;
                                        }
                                }
                            }
                            isvalidated = true;
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Select Size \n1. Large \n2. Medium \n3. Small");
                            bool isvalid = false;
                            while (isvalid == false)
                            {
                                int.TryParse(Console.ReadLine(), out int size);
                                switch (size)
                                {
                                    case 1:
                                        {
                                            user.Orders.Last().MakeVeggiePizza("Large");
                                            isvalid = true;
                                            break;
                                        }
                                    case 2:
                                        {
                                            user.Orders.Last().MakeVeggiePizza("Medium");
                                            isvalid = true;
                                            break;
                                        }
                                    case 3:
                                        {
                                            user.Orders.Last().MakeVeggiePizza("Small");
                                            isvalid = true;
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Invalid selection.  Please try again.");
                                            break;
                                        }
                                }
                            }
                            isvalidated = true; 
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid selection.  Please try again.");
                            break;
                        }
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
                            Console.WriteLine("Your pizza total is: ???");
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
        static void Checkout()
        {
            //view order
            // y/n proceed
            // n = restart
            // y = here is your price 
            // git
        }

        static void UserView(User user)
        {

            PrintAllStores();

            user.SelectedStore =_sql.SelectStore();
            user.SelectedStore.CreateOrder();
            user.Orders.Add(user.SelectedStore.Orders.Last());
            SelectPizza(user);


            _sql.Update();
            
            System.Console.WriteLine(user);

        }
    }
}
