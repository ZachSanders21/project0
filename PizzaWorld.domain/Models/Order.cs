using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Factories;

namespace PizzaWorld.Domain.Models
{
    public class Order : AEntity
    {
        private GenericPizzaFactory _pizzaFactory = new GenericPizzaFactory();

        public List<APizzaModel> Pizzas { get; set; }

        public void MakeMeatPizza()
        {
            Pizzas.Add(_pizzaFactory.Make<MeatPizza>());
        }
        public void MakeVeggiePizza()
        {
            Pizzas.Add(_pizzaFactory.Make<VeggiePizza>());
        }
        public void MakeHawaianPizza()
        {
            Pizzas.Add(_pizzaFactory.Make<HawainPizza>());
        }
        public void MakeSupremePizza()
        {
            Pizzas.Add(_pizzaFactory.Make<SupremePizza>());
        }
    }
}