using NUnit.Framework;
using Moq;
using Greeting.Chain;

namespace Greeting.Test
{
    public class TwoNamesHandlerTests
    {
        private IGreetingHandler _sut;

        [SetUp]
        public void Setup()
        {
            //var mock = new Mock<IGreetingHandler>();
            //mock.Setup(x => x.Handle(new string[] { "Andrea", "Franco" })).Returns("Hello, Andrea and Franco.");
            _sut = new TwoNamesHandler();
        }

        [Test]
        public void Should_Handle_Two_Name()
        {
            var expected = "Hello, Andrea and Franco.";
            var actual = _sut.Handle("Andrea", "Franco");

            Assert.AreEqual(expected, actual);
        }
    }
}