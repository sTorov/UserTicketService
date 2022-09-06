using NUnit.Framework;
using System.Reflection;

namespace Tasks.Tests
{
    [TestFixture]
    public class Task16_6_2_Tests
    {
        [Test]
        public void _GetSafeFilename_MustReturnCorrectValue()
        {
            FileWorker worker = new FileWorker();
            MethodInfo? method = typeof(FileWorker).GetMethod("GetSafeFilename", BindingFlags.NonPublic | BindingFlags.Instance);

            object[] param = { "<Qwerty|123>" };
            Assert.AreEqual("_Qwerty_123_", method!.Invoke(worker, param));

            /*
             * var PrivateObject obj = new PrivateObject(worker);
             * NUnit.Framework.Assert.AreEqual("_Qwerty_123_", obj.Invoke("GetSafeFilename", "<Qwerty|123>"))
             */
        }
    }
}
