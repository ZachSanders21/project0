using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class SupremePizza : APizzaModel
    {
        public SupremePizza(string size) : base(size)
        {
            
        }
        protected override void AddCrust()
        {
            Crust = "crust";
        }

        protected override void AddSize(string size)
        {
            Size = size;
        }
        protected override void AddToppings()
        {
            
                // Toppings = new List<string>
                // {
                //     "sausage",
                //     "onion",
                //     "mushroom",
                //     "bacon",
                //     "chicken",
                //     "anchovie"
                // };

        }
        protected override string GetPizzaName()
        {
            return "Supreme Pizza";
        }
    }
}