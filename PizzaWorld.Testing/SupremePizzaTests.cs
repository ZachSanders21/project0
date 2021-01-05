using PizzaWorld.Domain.Models;
using Xunit;

namespace PizzaWorld.Testing
{
    public class SupremePizzaTests
    {
        [Fact]
        private void Test_SupremePizzaExists()
        {
            // arrange
            Size size = new Size("Small");
            string crust = "Garlic";
            SupremePizza supremepizza = new SupremePizza(size, crust);

            Assert.Equal(size, supremepizza.Size); 
            Assert.Equal(crust, supremepizza.Crust);
        }  
    }
    
}