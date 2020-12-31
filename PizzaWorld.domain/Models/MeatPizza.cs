using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class MeatPizza : APizzaModel
    {
      public MeatPizza(string size) : base(size)
        {
            
        }
      protected override void AddCrust()
      {
          Crust = "crust";
      }  

      protected override void AddSize(string Size)
      {
          Size = "Medium";
      }
      protected override void AddToppings()
      {
        //   Toppings = new List<string>
        //   {
        //       "cheese",
        //       "pepperoni",
        //       "sausage",
        //       "sauce",
        //       "ham"
        //   };

      }

    }
}