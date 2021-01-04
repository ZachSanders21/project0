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
        public void MakeMeatPizza(Size size, string crust)
        {
            Pizzas.Add(_pizzaFactory.Make<MeatPizza>(size, crust));
        }
        public void MakeVeggiePizza(Size size, string crust)
        {
            Pizzas.Add(_pizzaFactory.Make<VeggiePizza>(size, crust));
        }
        public void MakeHawaianPizza(Size size, string crust)
        {
            Pizzas.Add(_pizzaFactory.Make<HawaianPizza>(size, crust));
        }
        public void MakeSupremePizza(Size size, string crust)
        {
            Pizzas.Add(_pizzaFactory.Make<SupremePizza>(size, crust));
        }
        public void CalclatePrice()
        {
            
        }
    }
}