using PizzaWorld.Domain.Models;
using Xunit;

namespace PizzaWorld.Testing
{
    public class PizzaTests
    {
        [Fact]
        private void Test_PizzaExists()
        {
            // arrange
            var sut = new MeatPizza(new Size("Small"),"Garlic"); // inference
            // Order sut1 = new Order(); // memory allocation

            // act
            var actual = sut;

            // assert
            Assert.IsType<MeatPizza>(actual);
            Assert.NotNull(actual);
        }
    }
}