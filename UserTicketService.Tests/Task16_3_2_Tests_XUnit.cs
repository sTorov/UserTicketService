using Moq;
using Xunit;

namespace UserTicketService.Tests
{
    public class Task16_3_2_Tests_XUnit
    {
        [Fact]
        public void FindAll_MustReturnCorrectValue()
        {
            var mock = new Mock<IBookRepository>();
            mock.Setup(x => x.FindAll()).Returns(new List<Book>
            {
                new Book { Title = "Война и мир" },
                new Book { Title = "Человек-невидимка" },
                new Book { Title = "Анна Каренина" },
            });

            Assert.Contains(mock.Object.FindAll(), x => x.Title == "Война и мир");
            Assert.Contains(mock.Object.FindAll(), x => x.Title == "Человек-невидимка");
            Assert.Contains(mock.Object.FindAll(), x => x.Title == "Анна Каренина");
        }
    }
}
