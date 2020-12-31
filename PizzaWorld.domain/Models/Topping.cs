using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class Topping : AEntity
    {
        public string Name { get; set; }
        public List<APizzaModel> Pizzas { get; set; }

    }
}