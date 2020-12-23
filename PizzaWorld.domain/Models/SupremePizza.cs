using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class SupremePizza : APizzaModel
    {
        protected override void AddCrust()
        {
            Crust = "Garlic";
        }

        protected override void AddSize()
        {
            Size = "Large";
        }
        // protected override void AddToppings()
        // {
        //     Toppings = new List<string>
        //     {
        //         "sausage",
        //         "onion",
        //         "mushroom",
        //         "bacon",
        //         "chicken",
        //         "anchovie"
        //     };

        // }
    }
}