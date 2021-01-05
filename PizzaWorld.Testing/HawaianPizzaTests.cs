using PizzaWorld.Domain.Models;
using Xunit;

namespace PizzaWorld.Testing
{
    public class HawaianPizzaTests
    {
        [Fact]
        private void Test_HawaianPizzaExists()
        {
            // arrange
            Size size = new Size("Small");
            string crust = "Garlic";
            HawaianPizza hawaianpizza = new HawaianPizza(size, crust);

            Assert.Equal(size, hawaianpizza.Size); 
            Assert.Equal(crust, hawaianpizza.Crust);
        }    


    }
    
}