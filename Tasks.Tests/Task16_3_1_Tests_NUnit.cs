using Moq;
using NUnit.Framework;

namespace Tasks.Tests
{
    [TestFixture]
    public class Task16_3_1_Tests_NUnit
    {
        [Test]
        public void FindAll_MustReturnNotNullValue()
        {
            var mockUserRepository = new Mock<IUserRepository>();
            mockUserRepository.Setup(x => x.FindAll()).Returns(new List<User>
            {
                new User { Name = "Антон" },
                new User { Name = "Иван" },
                new User { Name = "Алексей" },
            });

            Assert.That(mockUserRepository.Object.FindAll().Any(x => x.Name == "Антон"));
            Assert.That(mockUserRepository.Object.FindAll().Any(x => x.Name == "Иван"));
            Assert.That(mockUserRepository.Object.FindAll().Any(x => x.Name == "Алексей"));
        }
    }
}
