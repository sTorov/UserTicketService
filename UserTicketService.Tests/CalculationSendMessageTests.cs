using Moq;
using NUnit.Framework;

namespace UserTicketService.Tests__NUnit_
{
    [TestFixture]
    public class CalculationSendMessageTests
    {
        [Test]
        public void Multiplication_MustReturnNotNullValue()
        {
            var mockMailSender = new Mock<IMailSender>();
            mockMailSender.Setup(t => t.Send()).Returns(true);

            var calculation = new CalculationSendMessage(mockMailSender.Object);

            Assert.That(8 == calculation.Multiplication(2, 4));
        }
    }
}
