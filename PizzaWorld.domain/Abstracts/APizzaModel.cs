using PizzaWorld.Domain.Models;
using System.Collections.Generic;

namespace PizzaWorld.Domain.Abstracts
{
    public class APizzaModel : AEntity
    {
        public string Crust { get; set; }

        public string Size { get; set; }
        public List<Topping> Toppings { get; set; }
        

        protected APizzaModel(string size)
        {
            AddCrust();
            AddSize(size);
            AddToppings();
        }
        protected APizzaModel()
        {

        }

        protected virtual void AddCrust() {}
        protected virtual void AddSize(string size) {}
        protected virtual void AddToppings() {}

    }
}