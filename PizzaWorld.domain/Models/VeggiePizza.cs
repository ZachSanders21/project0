using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class VeggiePizza : APizzaModel
    {
        public VeggiePizza(Size size, string crust) : base(size, crust)
        {
            
        }

        protected override void AddToppings()
        {
            Toppings = new List<Topping>();
            Toppings.Add(new Topping("Cheese"));
            Toppings.Add(new Topping("Cucumber"));
            Toppings.Add(new Topping("Mushroom"));
            Toppings.Add(new Topping("Onion"));
            Toppings.Add(new Topping("Spinach"));

        }
        protected override string GetPizzaName()
        {
            return "Veggie Pizza";
        }
    }
}