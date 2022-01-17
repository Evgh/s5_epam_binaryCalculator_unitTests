using s5_epam_binaryCalculator_unitTests.Exceptions;

namespace s5_epam_binaryCalculator_unitTests
{
    public static class BinaryCalculatorExtensions
    {
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
    }
}
