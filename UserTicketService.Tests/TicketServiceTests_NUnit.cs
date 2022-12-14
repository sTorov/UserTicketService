using NUnit.Framework;

namespace UserTicketService.Tests
{
    [TestFixture]
    public class TicketServiceTests_NUnit
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

        [Test]
        public void GetTicket_MustReturnNotNullableTicket()
        {
            var ticketServiceTest = new TicketService();
            Assert.NotNull(ticketServiceTest.GetTicket(1));
        }
    }
}
