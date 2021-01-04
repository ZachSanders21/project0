using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class MeatPizza : APizzaModel
    {
      public MeatPizza(Size size, string crust) : base(size, crust)
        {
            
        }

      protected override void AddToppings()
      {
        Toppings = new List<Topping>();
        Toppings.Add(new Topping("Cheese"));
        Toppings.Add(new Topping("Pepperoni"));
        Toppings.Add(new Topping("Sausage"));
        Toppings.Add(new Topping("Ham"));
      }
      protected override string GetPizzaName()
      {
        return "Meat Pizza";
      }
    }
}