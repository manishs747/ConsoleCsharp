using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ManishConsoleApp.test
{

    [TestClass]
    public class MockingExample
    {
        [TestMethod]
        public void DoSomethingReturnsCorrectValue()
        {
            // Create a mock object for the custom data member interface
            var customDataMock = new Mock<ICustomData>();

            // Set up the mock object to return a value
            customDataMock.Setup(x => x.GetValue()).Returns(5);

            // Create an instance of the class using the mock object
            MyClass myClass = new(customDataMock.Object);

            // Call the method and verify the result
            int result = myClass.DoSomething();
            Assert.AreEqual(10, result);
        }
    }
}
