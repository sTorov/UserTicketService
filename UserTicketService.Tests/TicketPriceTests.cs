using Moq;
using NUnit.Framework;

namespace UserTicketService.Tests__NUnit_
{
    [TestFixture]
    public class TicketPriceTests
    {
        [Test]
        public void TicketPrice_MustReturnNotNullableTicket()
        {
            var moqTicketService = new Mock<ITicketService>();
            moqTicketService.Setup(x => x.GetTicketPrice(1)).Returns(100);
            moqTicketService.Setup(x => x.GetTicketPrice(2)).Returns(500);
            moqTicketService.Setup(x => x.GetTicketPrice(3)).Returns(7800);

            var ticketPriceTest = new TicketPrice(moqTicketService.Object);
            Assert.That(ticketPriceTest.MakeTicketPrice(3) == 7800);
        }
    }
}
