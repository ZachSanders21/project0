using PizzaWorld.Domain.Models;
using Xunit;

namespace PizzaWorld.Testing
{
    public class VeggiePizzaTests
    {
        [Fact]
        private void Test_VeggiePizzaExists()
        {
            // arrange
            Size size = new Size("Small");
            string crust = "Garlic";
            VeggiePizza veggiepizza = new VeggiePizza(size, crust);

            Assert.Equal(size, veggiepizza.Size); 
            Assert.Equal(crust, veggiepizza.Crust);
        }  
    }
    
}