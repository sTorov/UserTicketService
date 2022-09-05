using Xunit;

namespace UserTicketService.Tests__XUnit_
{
    public class CalculationTests
    {
        [Fact]
        public void MultiplicationMustReturnNotNull()
        {
            Calculation calculation = new Calculation();

            Assert.Equal(8, calculation.Multiplication(4, 2));
        }
    }
}
