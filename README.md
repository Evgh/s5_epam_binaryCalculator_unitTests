# Project was created to demonstrate my skills with NUnit
_I created a binary operations functionality and tests for it._

## What s5_epam_binaryCalculator_unitTests project is  
### It describes the functionality that is planned to be tested 
- Main binary operations 
- Displaying a number in a binary representation
- Getting a number from a string consisting only of '0' and '1' symbols (For example "110" => 6)

I implemented it in the form of extension methods. Extensions for binary operations are described in the class BinaryCalculatorExtensions. Methods for working with binary representation are described in the class BinaryPrinterExtensions.

Sample of using my logic:
```
Console.WriteLine(5.BinaryXor(3));
Console.WriteLine(2.GetBinaryView());
Console.WriteLine("10001".GetNumberFromBinaryView());
```
Output will be 6, 10, 17.

The logic is extremely simple, but everything here is done for the sake of tests, and not for the sake of complex logic.

## What CalculatorTests project is
### Tests made using the Nunit framework.
The project contains a single class BinaryCalculatorExtensionsTests that describes the tests. They are made according to the following testcases.

№ | Test | Precondition | Steps | Result |
--| ---- | ------------ | ----- | ------ |
01| Test BinaryAnd Method | We have 2 valid numbers | Execute BinaryAnd() for our numbers | Get valid answer |
02| Test BinaryOr Method | We have 2 valid numbers | Execute BinaryOr() for our numbers | Get valid answer |
03| Test BinaryXor Method | We have 2 valid numbers | Execute BinaryXor() for our numbers | Get valid answer |
04| Positive Test BinaryRightShift Method | We have a valid number and a valid shift value | Execute BinaryRightShift() with a number per shift value | Get valid answer |
05| Negative Test BinaryRightShift Method | We have a valid number and an invalid shift value | Execute BinaryRightShift() with a number per invalid shift value | Throws an exception |
06| Positive Test BinaryLeftShift Method | We have a valid number and a valid shift value | Execute BinaryLeftShift() with a number per shift value | Get valid answer |
07| Negative Test BinaryLeftShift Method | We have a valid number and an invalid shift value | Execute BinaryLeftShift() with a number per invalid shift value | Throws an exception |
08| Test GetBinaryView Method | We have a valid number | Execute GetBinaryView() with a number | Get valid answer |
09| Positive Test GetNumberFromBinaryView Method | We have a valid string that consists of '0' and '1' symbols only | Execute GetNumberFromBinaryView() with a string | Get valid answer |
10| Negative Test GetNumberFromBinaryView Method | We have an invalid string that contains characters other than '0' and '1' | Execute GetNumberFromBinaryView() with a string | Throws an exception |
