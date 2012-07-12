using System;
using System.Collections.Generic;
using System.Numerics;
using NUnit.Framework;

namespace ClassLibrary1
{
    [TestFixture]
    public class E53Tests
    {
        [Test]
        public void Factorial_Given_Then()
        {
            BigInteger result = E53.Factorial(3);
            Assert.AreEqual(new BigInteger(6), result);
            result = E53.Factorial(4);
            Assert.AreEqual(new BigInteger(24), result);
            result = E53.Factorial(5);
            Assert.AreEqual(new BigInteger(120), result);
        }

        [Test]
        public void MethodUnderTest_scenario_expectedbehaviour()
        {
            BigInteger result = E53.HowManyWaysToGetrFromnDigits(3,5);
            Assert.AreEqual(new BigInteger(10), result);
            result = E53.HowManyWaysToGetrFromnDigits(2, 5);
            Assert.AreEqual(new BigInteger(10), result);
        }

        [Test]
        public void HowManyValuesGreaterThan1m_Given_ReturnCount()
        {
            int result = E53.HowManyValuesGreaterThan1m();
            Assert.AreEqual(4075, result);
        }
    }

    public class E53
    {
        public static int HowManyValuesGreaterThan1m()
        {
            var list = new List<BigInteger>();
            for (int n = 1; n <= 100; n++)
            {
                for (int r = 1; r <= n; r++)
                {
                    BigInteger result = HowManyWaysToGetrFromnDigits(r, n);
                    if (result > 1000000)
                    {
                        list.Add(result);
                    }
                }
            }
            return list.Count;
        }

        public static BigInteger HowManyWaysToGetrFromnDigits(int r, int n)
        {
            BigInteger top = Factorial(n);
            BigInteger bracket = Factorial(n - r);
            BigInteger bottom = Factorial(r)*bracket;
            BigInteger result = top/bottom;
            return result;
        }

        public static BigInteger Factorial(int a)
        {
            if (a == 0) return 1;
            BigInteger number = new BigInteger(a);
            for (int i = a-1; i > 1; i--)
            {
                number = number * i;
            }
            return number;
        }
    }
}
