using System.Collections.Generic;
using NUnit.Framework;

namespace ClassLibrary1
{
    [TestFixture]
    public class E53Tests
    {
        [Test]
        public void Factorial_Given_Then()
        {
            int result = E53.Factorial(3);
            Assert.AreEqual(6, result);
            result = E53.Factorial(4);
            Assert.AreEqual(24, result);
            result = E53.Factorial(5);
            Assert.AreEqual(120, result);
        }

        [Test]
        public void MethodUnderTest_scenario_expectedbehaviour()
        {
            int result = E53.HowManyWaysToGetrFromnDigits(3,5);
            Assert.AreEqual(10, result);
            result = E53.HowManyWaysToGetrFromnDigits(2, 5);
            Assert.AreEqual(10, result);
        }

        [Test]
        public void HowManyValuesGreaterThan1m_Given_ReturnCount()
        {
            int result = E53.HowManyValuesGreaterThan1m();
            Assert.AreEqual(1, result);
        }
    }

    public class E53
    {
        public static int HowManyValuesGreaterThan1m()
        {
            var list = new List<int>();
            for (int n = 1; n <= 100; n++)
            {
                for (int r = 1; r <= n; r++)
                {
                    int result = HowManyWaysToGetrFromnDigits(r, n);
                    if (result > 1000000)
                    {
                        list.Add(result);
                    }
                }
            }
            return list.Count;
        }

        public static int HowManyWaysToGetrFromnDigits(int r, int n)
        {
            int top = Factorial(n);
            int bracket = Factorial(n - r);
            int bottom = Factorial(r)*bracket;
            int result = top/bottom;
            return result;
        }

        public static int Factorial(int a)
        {
            if (a == 0) return 1;
            int number = a;
            for (int i = a-1; i > 1; i--)
            {
                number = number * i;
            }
            return number;
        }
    }
}
