using NUnit.Framework;

namespace UserTicketService.Tests__NUnit_
{
    [TestFixture]
    public class TicketServiceTests
    {
        [Test]
        public void GetTicketPrice_MustReturnNotNullableTicket()
        {
            var ticketServiceTest = new TicketService();
            Assert.NotNull(ticketServiceTest.GetTicketPrice(1));
        }

        [Test]
        public void GetTicketPrice_MustThrowException()
        {
            var ticketServiceTest = new TicketService();
            Assert.Throws<TicketNotFoundException>(() => ticketServiceTest.GetTicketPrice(100));
        }
    }
}
