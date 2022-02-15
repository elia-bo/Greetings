using NUnit.Framework;
using Moq;
using Greeting.Chain;

namespace Greeting.Test
{
    public class NullHandlerTests
    {
        private IGreetingHandler _sut;

        [SetUp]
        public void Setup()
        {
            //var mock = new Mock<IGreetingHandler>();
            //mock.Setup(x => x.Handle(null)).Returns("Hello, my friend.");
            _sut = new NullHandler();
        }

        [Test]
        public void Should_Handle_Null_Name()
        {
            var expected = "Hello, my friend.";
            var actual = _sut.Handle(null);

            Assert.AreEqual(expected, actual);
        }
    }
}
