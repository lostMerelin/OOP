using System;

using NUnit.Framework;

namespace Test
{
    public class Tests
    {
        [Test]
        public void plus()
        {
            RationalNumber num1 = new RationalNumber(1, 2);
            RationalNumber num2 = new RationalNumber(1, 2);
            RationalNumber result = num1+num2;

        }

        [Test]
        public void minus()
        {

        }
    }
}