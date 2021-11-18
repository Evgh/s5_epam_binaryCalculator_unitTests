using System;

namespace s5_epam_binaryCalculator_unitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10001".GetNumberFromBynaryView().Xor("11".GetNumberFromBynaryView()).GetBynaryView());
            Console.WriteLine(9.RightShift(2));
            Console.WriteLine(9.LeftShift(2));
        }
    }
}
