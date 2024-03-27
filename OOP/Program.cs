using System;

namespace OOP
{
    public class RationalNumber
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        public RationalNumber(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator = 0", nameof(denominator));
            }
            Simplify();
        }

        private void Simplify()
        {
            int nod = NOD(Numerator, Denominator);
            Numerator /= nod;
            Denominator /= nod;
        }

        private static int NOD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static RationalNumber operator +(RationalNumber num1, RationalNumber num2)
        {
            int nok = num1.Denominator / NOD(num1.Denominator, num2.Denominator) * num2.Denominator;
            int newNumerator = num1.Numerator * (nok / num1.Denominator) + num2.Numerator * (nok / num2.Denominator);
            return new RationalNumber(newNumerator, nok);
        }

        public static RationalNumber operator -(RationalNumber num1, RationalNumber num2)
        {
            int nok = num1.Denominator / NOD(num1.Denominator, num2.Denominator) * num2.Denominator;
            int newNumerator = num1.Numerator * (nok / num1.Denominator) - num2.Numerator * (nok / num2.Denominator);
            return new RationalNumber(newNumerator, nok);
        }

        public static RationalNumber operator *(RationalNumber num1, RationalNumber num2)
        {
            return new RationalNumber(num1.Numerator * num2.Numerator, num1.Denominator * num2.Denominator);
        }

        public static RationalNumber operator /(RationalNumber num1, RationalNumber num2)
        {
            return new RationalNumber(num1.Numerator * num2.Denominator, num1.Denominator * num2.Numerator);
        }

        public static RationalNumber operator -(RationalNumber num)
        {
            return new RationalNumber(-num.Numerator, num.Denominator);
        }

        public static bool operator ==(RationalNumber num1, RationalNumber num2)
        {
            return num1.Numerator == num2.Numerator && num1.Denominator == num2.Denominator;
        }

        public static bool operator !=(RationalNumber num1, RationalNumber num2)
        {
            return !(num1 == num2);
        }

        public static bool operator <(RationalNumber num1, RationalNumber num2)
        {
            return num1.Numerator * num2.Denominator < num2.Numerator * num1.Denominator;
        }

        public static bool operator >(RationalNumber num1, RationalNumber num2)
        {
            return num1.Numerator * num2.Denominator > num2.Numerator * num1.Denominator;
        }

        public static bool operator <=(RationalNumber num1, RationalNumber num2)
        {
            return num1 < num2 || num1 == num2;
        }

        public static bool operator >=(RationalNumber num1, RationalNumber num2)
        {
            return num1 > num2 || num1 == num2;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
