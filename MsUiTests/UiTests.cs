using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace MsUiTests
{
    [TestClass]
    public class UiTests : AppSession
    {
        [TestMethod]
        public void TestMethod1()
        {
            var tb = session.FindElement(By.Name("JobTextBox"));
            tb.SendKeys("Engineer");

            // Act
            session.FindElement(By.Name("InfoButton")).Click();

            var label = session.FindElement(By.Name("JobLabel"));
            var actual = label.Text;

            Assert.AreEqual("Engineer", actual);
        }

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            // Create session to launch a Calculator window
            Setup(context);
        }


    }
}