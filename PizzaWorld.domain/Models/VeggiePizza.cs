using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class VeggiePizza : APizzaModel
    {
        protected override void AddCrust()
        {
            Crust = "Regular";
        }

        protected override void AddSize()
        {
            Size = "Medium";
        }
        // protected override void AddToppings()
        // {
        //     Toppings = new List<string>
        //     {
        //         "cucumber",
        //         "mushroom",
        //         "spinach",
        //         "onion"
        //     };

        // }
    }
}