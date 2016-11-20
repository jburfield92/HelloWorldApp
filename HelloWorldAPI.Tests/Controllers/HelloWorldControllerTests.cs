//////////////////////////////////////////////////////////////////////////////////////////////////////
//
//      FILE NAME: HelloWorldControllerTests.cs
//      DATE: 11/20/2016
//
//      DESCRIPTION: HelloWorldController unit test class
//
//      CHANGES:
//
//      DATE        NAME            DECRIPTION
//      ----------  ----------      ----------
//      11/20/2016  Joseph B.       Initial
//////////////////////////////////////////////////////////////////////////////////////////////////////

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldAPI.Controllers.Tests
{
    /// <summary> HelloWorldController unit test class
    /// </summary>
    [TestClass()]
    public class HelloWorldControllerTests
    {
        /// <summary> Tests the GetMessage method
        /// </summary>
        [TestMethod()]
        public void GetMessageTest()
        {
            HelloWorldController controller = new HelloWorldController();
            string actualMessage = controller.GetMessage();
            string expectedMessage = "Hello World";

            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}