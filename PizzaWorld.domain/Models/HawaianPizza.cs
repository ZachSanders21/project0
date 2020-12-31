using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class HawaianPizza : APizzaModel
    {
        public HawaianPizza(string size) : base(size)
        {
            
        }

        protected override void AddCrust()
        {
            Crust = "crust";
        }

        protected override void AddSize(string size)
        {
            Size = "Medium";
        }
        protected override void AddToppings()
        {
        //     Toppings = new List<string>
        //     {
        //         "pineapple",
        //         "ham",
        //         "onion"
        //     };

        }
    }
}