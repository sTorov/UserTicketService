using NUnit.Framework;
using System.Reflection;

namespace UserTicketService.Tests
{
    [TestFixture]
    public class TicketServiceIntegrationTests
    {
        [Test]
        public void SaveTicket_MustAddTicketInBase()
        {
            var ticketServiceTest = new TicketService();
            var newTicket = new Ticket(300, "Test ticket", 1000);

            ticketServiceTest.SaveTicket(newTicket);

            var allTicketsAfterAddingNewTicket = ticketServiceTest.GetAllTickets();
            CollectionAssert.Contains(allTicketsAfterAddingNewTicket, newTicket);

            //public

            //ticketServiceTest.DeleteTicket(newTicket);


            //private
            Type t = typeof(TicketService);
            t.InvokeMember("DeleteTicket",  
                //параметры поиска
                BindingFlags.InvokeMethod | //вызвать метод
                BindingFlags.NonPublic | //включить в поиск непубличные члены
                BindingFlags.Instance,  //включить в поиск объекта экземпляра
                null, 
                ticketServiceTest, // сам объект
                new[] { newTicket });   //параметры передаваемые в метод

            var allTicketsAfterDeletingNewTicket = ticketServiceTest.GetAllTickets();
            CollectionAssert.DoesNotContain(allTicketsAfterDeletingNewTicket, newTicket);
        }

        //или

        [Test]
        public void DeleteTicket_MustRemoveTicketInBase()
        {
            var ticketServiceTest = new TicketService();
            var newTicket = new Ticket(300, "Test ticket", 1000);

            ticketServiceTest.SaveTicket(newTicket);

            var allTicketsAfterAddingNewTicket = ticketServiceTest.GetAllTickets();
            CollectionAssert.Contains(allTicketsAfterAddingNewTicket, newTicket);

            //private
            MethodInfo? methodInfo = typeof(TicketService).GetMethod("DeleteTicket", BindingFlags.NonPublic | BindingFlags.Instance); //Получение иформации о методе
            object[] parameters = { newTicket };  //параметры для запуска методы
            methodInfo?.Invoke(ticketServiceTest, parameters);  //запуск метода

            var allTicketsAfterDeletingNewTicket = ticketServiceTest.GetAllTickets();
            CollectionAssert.DoesNotContain(allTicketsAfterDeletingNewTicket, newTicket);
        }

    }
}
