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
            var sut = new Pizza(); // inference
            // Order sut1 = new Order(); // memory allocation

            // act
            var actual = sut;

            // assert
            Assert.IsType<Pizza>(actual);
            Assert.NotNull(actual);
        }
    }
}