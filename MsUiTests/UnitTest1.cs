using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MsUiTests
{
    [TestClass]
    public class UnitTest1 : AppSession
    {
        [TestMethod]
        public void TestMethod1()
        {

        }

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            // Create session to launch a Calculator window
            Setup(context);
        }
    }
}