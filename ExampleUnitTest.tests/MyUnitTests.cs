using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ExampleUnitTest.tests
{
    [TestClass]
    public class MyUnitTests
    {
        [TestMethod]
        public void Given_my_context_When_I_trigger_some_behavior_Then_I_expect_something_expected_to_be_returned()
        {
            // An example of an interfaced param
            var thingyMock = new Mock<IThingyAble>();

            // Construct an instance of the unit under test
            // All inputs should be either fed into a constructor
            // Or will be a parameter into your function
            // This depends on the scope and how you have designed your
            // unit
            var thingUnderTest = new MyUnit(thingyMock.Object);

            // Test the behaviour
            int result = thingUnderTest.DoSomething(5);

            // Assert that you've got what you expected
            Assert.AreEqual(6, result);
        }


        [TestMethod]
        public void Given_my_context_When_I_trigger_some_behavior_Then_I_expect_something_expected_to_happen()
        {
            // An example of an interfaced param
            var thingy = new Mock<IThingyAble>();

            // Use closure scope to record that something happened
            string recordedInput = null;

            // Mock out a method
            thingy.Setup(x => x.DoThingy(It.IsAny<string>())).Callback<string>(input =>
            {
                recordedInput = input;
            });

            // Construct an instance of the unit under test
            // All inputs should be either fed into a constructor
            // Or will be a parameter into your function
            // This depends on the scope and how you have designed your
            // unit
            var thingUnderTest = new MyUnit(thingy.Object);

            // Test the behaviour
            thingUnderTest.DoSomethingWhichCallsIntoThingy();

            // Assert that you've got what you expected
            Assert.AreEqual("Whatsit", recordedInput);
        }
    }
}
