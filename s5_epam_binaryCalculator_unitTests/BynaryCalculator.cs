using System;
using System.Text;
using s5_epam_binaryCalculator_unitTests.Exceptions;

namespace s5_epam_binaryCalculator_unitTests
{
    public static class BinaryCalculator
    {
        public static int And(this int number, int parameter) => number & parameter;
        public static int Or(this int number, int parameter) => number | parameter;
        public static int Xor(this int number, int parameter) => number ^ parameter;

        public static int LeftShift(this int number, int shift)
        {
            if (shift < 0)
                throw new NegativeShiftValueException("Shift value shouldn't be negative");

            return number << shift;
        }

        public static int RightShift(this int number, int shift)
        {
            if (shift < 0)
                throw new NegativeShiftValueException("Shift value shouldn't be negative");

            return number >> shift;
        }

        public static string GetBynaryView(this int number)
        {
            var builder = new StringBuilder();

            for (int i = 0, bufferNumber = number; bufferNumber > 0; i++, bufferNumber >>= 1)
            {
                if (i % 8 == 0)
                    builder.Insert(0, " ");

                builder.Insert(0, bufferNumber & 1);
            }
            if (builder.Length == 0)
                builder.Append('0');

            return builder.ToString().Trim();
        }

        public static int GetNumberFromBynaryView(this string bynaryView)
        {
            string bynaryStringWithoutWhitespaces = bynaryView.RemoveAllWhitespaces();
            int numberView = 0;

            for (int i = bynaryStringWithoutWhitespaces.Length - 1; i >= 0; i--)
            {
                if (bynaryStringWithoutWhitespaces[i] == '1')
                    numberView += (int)Math.Pow(2, i);

                else if (bynaryStringWithoutWhitespaces[i] != '0')
                    throw new StringIsNotBynaryException("String should consist of 0 and 1 only");
            }
            return numberView;
        }

        private static string RemoveAllWhitespaces(this string value) => string.Join("", value.Split(' '));
    }
}
