using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class VeggiePizza : APizzaModel
    {
        public VeggiePizza(string size) : base(size)
        {
            
        }
        protected override void AddCrust()
        {
            Crust = "crust";
        }

        protected override void AddSize(string Size)
        {
            Size = "Medium";
        }
        protected override void AddToppings()
        {
            // Toppings = new List<string>
            // {
            //     "cucumber",
            //     "mushroom",
            //     "spinach",
            //     "onion"
            // };

        }
    }
}