using NUnit.Framework;

namespace UserTicketService.Tests__NUnit_
{
    [TestFixture]
    public class CalculationTests
    {
        [Test]
        public void MultiplicationMustReturnNotNull()
        {
            Calculation calculation = new Calculation();

            Assert.AreEqual(8, calculation.Multiplication(2, 4));
        }
    }
}
