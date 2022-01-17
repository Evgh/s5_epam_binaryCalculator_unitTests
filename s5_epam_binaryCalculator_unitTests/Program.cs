using System;

namespace s5_epam_binaryCalculator_unitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            DoSomeBinaryExtensionsFunctionality();
        }

        private static void DoSomeBinaryExtensionsFunctionality()
        {
            Console.WriteLine("10001".GetNumberFromBinaryView().BinaryXor("11".GetNumberFromBinaryView()).GetBinaryView());
            Console.WriteLine(9.BinaryRightShift(2));
            Console.WriteLine(9.BinaryLeftShift(2));
        }
    }
}
