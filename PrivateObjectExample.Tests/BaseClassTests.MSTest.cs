using System.Diagnostics;
using System.Reflection;

namespace PrivateObjectExample.Tests
{
    [TestClass]
    public class BaseClassTests
    {
        MyClass? myClass;
        MethodInfo? method;

        [TestInitialize]      //    Инициализация переменных перед началом каждого тестирования
        //[ClassInitialize]   //    Инициализация переменных при первом обращении к классу
        public void Initialize()
        {
            Debug.WriteLine("Initialize complete");
            myClass = new MyClass();
            method = typeof(BaseClass).GetMethod("IsTrue", BindingFlags.NonPublic | BindingFlags.Instance);
        }

        //[ClassCleanup]     //   Действия после завершения всех тестов (обычно освобождение ресурсов)
        [TestCleanup]        //   Действия после окончания каждого теста
        public void Deinicialize()
        {
            Debug.WriteLine("Deinitialize complete");
            myClass!.Dispose();
        }

        [DataTestMethod]                        //  группа параметров передаваемых в тест (для обновления - пересобрать)
        [DataRow(new object[] { 3, 7 }, 10)]    //  один из проходов с указанными параметрами
        [DataRow(new object[] { 1, 1 }, 2)]
        [DataRow(new object[] { 5, 0 }, 5)]
        [DataRow(new object[] { 33, 2 }, 34)]   //  ошибка
        public void IsTrue_MustAfterAddingReturnCorrectValue(object[] param, int result)
        {
            Assert.AreEqual(result, method?.Invoke(myClass, param));
        }

        [TestMethod("Тестирование ошибки")]
        [ExpectedException(typeof(ArgumentException))] //Тип искомой ошибки
        public void IsTrue_MustThrowException()
        {
            object[] param = { "asd", 7 };
            Assert.AreEqual(10, method?.Invoke(myClass, param));
        }
    }
}