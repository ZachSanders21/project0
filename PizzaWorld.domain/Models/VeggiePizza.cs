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

        protected override void AddSize(string size)
        {
            Size = size;
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
        protected override string GetPizzaName()
        {
            return "Veggie Pizza";
        }
    }
}