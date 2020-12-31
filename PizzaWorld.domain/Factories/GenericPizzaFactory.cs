using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Domain.Factories
{
    class GenericPizzaFactory
    {
        public APizzaModel Make<T>(string size) where T : class
        {
            if (typeof(T) == typeof(HawaianPizza))
            {
                return new HawaianPizza(size);
            }
            if (typeof(T) == typeof(MeatPizza))
            {
                return new MeatPizza(size);
            }
            if (typeof(T) == typeof(SupremePizza))
            {
                return new SupremePizza(size);
            }
            if (typeof(T) == typeof(VeggiePizza))
            {
                return new VeggiePizza(size);
            }
            else
            {
                return null;
            }
        }
    }
}