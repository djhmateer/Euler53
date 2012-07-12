using NUnit.Framework;

namespace ClassLibrary1
{
    [TestFixture]
    public class E53Tests
    {
        [Test]
        public void MethodUnderTest_scenario_expectedbehaviour()
        {
            var result = E53.DoSomething();
            Assert.AreEqual(1, result);
        }
    }

    public class E53
    {
        public static int DoSomething()
        {
            return 1;
        }
    }
}
