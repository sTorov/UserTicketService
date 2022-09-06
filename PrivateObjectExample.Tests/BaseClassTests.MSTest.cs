using System.Reflection;

namespace PrivateObjectExample.Tests
{
    [TestClass]
    public class BaseClassTests
    {
        [TestMethod("Тестирование приватного метода абстрактного класса")]
        public void IsTrue_MustAfterAddingReturnCorrectValue()
        {
            MyClass myClass = new MyClass();
            MethodInfo? method = typeof(BaseClass).GetMethod("IsTrue", BindingFlags.NonPublic | BindingFlags.Instance);

            object[] param = { 3, 7 };
            Assert.AreEqual(10, method?.Invoke(myClass, param));
        }
    }
}