using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Factories;

namespace PizzaWorld.Domain.Models
{
    public class Order : AEntity
    {
        private GenericPizzaFactory _pizzaFactory = new GenericPizzaFactory();

        public List<APizzaModel> Pizzas { get; set; }
        public Order()
        {
            Pizzas = new List<APizzaModel>();
        }
        public void MakeMeatPizza(string size)
        {
            Pizzas.Add(_pizzaFactory.Make<MeatPizza>(size));
        }
        public void MakeVeggiePizza(string size)
        {
            Pizzas.Add(_pizzaFactory.Make<VeggiePizza>(size));
        }
        public void MakeHawaianPizza(string size)
        {
            Pizzas.Add(_pizzaFactory.Make<HawaianPizza>(size));
        }
        public void MakeSupremePizza(string size)
        {
            Pizzas.Add(_pizzaFactory.Make<SupremePizza>(size));
        }
    }
}