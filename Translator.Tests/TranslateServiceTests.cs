using NUnit.Framework;

namespace Translator.Tests
{
    [TestFixture]
    public class TranslateServiceTests
    {
        [Test]
        public void GetTranslation_MustReturnCorrectValue()
        {
            var translateService = new TranslateService();
            translateService.Add("orange", "апельсин");

            Assert.AreEqual("апельсин", translateService.GetTranslation("orange"));
        }
    }
}