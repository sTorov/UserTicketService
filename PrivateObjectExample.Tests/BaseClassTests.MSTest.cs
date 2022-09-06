using System.Diagnostics;
using System.Reflection;

namespace PrivateObjectExample.Tests
{
    [TestClass]
    public class BaseClassTests
    {
        MyClass? myClass;
        MethodInfo? method;

        [TestInitialize]      //    ������������� ���������� ����� ������� ������� ������������
        //[ClassInitialize]   //    ������������� ���������� ��� ������ ��������� � ������
        public void Initialize()
        {
            Debug.WriteLine("Initialize complete");
            myClass = new MyClass();
            method = typeof(BaseClass).GetMethod("IsTrue", BindingFlags.NonPublic | BindingFlags.Instance);
        }

        //[ClassCleanup]     //   �������� ����� ���������� ���� ������ (������ ������������ ��������)
        [TestCleanup]        //   �������� ����� ��������� ������� �����
        public void Deinicialize()
        {
            Debug.WriteLine("Deinitialize complete");
            myClass!.Dispose();
        }

        [DataTestMethod]                        //  ������ ���������� ������������ � ���� (��� ���������� - �����������)
        [DataRow(new object[] { 3, 7 }, 10)]    //  ���� �� �������� � ���������� �����������
        [DataRow(new object[] { 1, 1 }, 2)]
        [DataRow(new object[] { 5, 0 }, 5)]
        [DataRow(new object[] { 33, 2 }, 34)]   //  ������
        public void IsTrue_MustAfterAddingReturnCorrectValue(object[] param, int result)
        {
            Assert.AreEqual(result, method?.Invoke(myClass, param));
        }

        [TestMethod("������������ ������")]
        [ExpectedException(typeof(ArgumentException))] //��� ������� ������
        public void IsTrue_MustThrowException()
        {
            object[] param = { "asd", 7 };
            Assert.AreEqual(10, method?.Invoke(myClass, param));
        }
    }
}