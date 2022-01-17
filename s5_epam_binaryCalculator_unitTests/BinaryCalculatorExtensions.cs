using System;
using System.Text;
using s5_epam_binaryCalculator_unitTests.Exceptions;

namespace s5_epam_binaryCalculator_unitTests
{
    public static class BinaryCalculatorExtensions
    {
        #region Public Methods

        public static int BinaryAnd(this int number, int parameter) => number & parameter;
        public static int BinaryOr(this int number, int parameter) => number | parameter;
        public static int BinaryXor(this int number, int parameter) => number ^ parameter;

        public static int BinaryLeftShift(this int number, int shift)
        {
            if (shift < 0)
                throw new NegativeShiftValueException("Shift value shouldn't be negative");

            return number << shift;
        }

        public static int BinaryRightShift(this int number, int shift)
        {
            if (shift < 0)
                throw new NegativeShiftValueException("Shift value shouldn't be negative");

            return number >> shift;
        }

        public static string GetBinaryView(this int number)
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

        public static int GetNumberFromBinaryView(this string binaryView)
        {
            string binaryStringWithoutWhitespaces = binaryView.RemoveAllWhitespaces();
            int numberView = 0;

            for (int i = binaryStringWithoutWhitespaces.Length - 1; i >= 0; i--)
            {
                if (binaryStringWithoutWhitespaces[i] == '1')
                    numberView += (int)Math.Pow(2, i);

                else if (binaryStringWithoutWhitespaces[i] != '0')
                    throw new StringIsNotBinaryException("String should consist of 0 and 1 only");
            }
            return numberView;
        }

        #endregion

        #region Private Methods

        private static string RemoveAllWhitespaces(this string value) => string.Join("", value.Split(' '));

        #endregion
    }
}
