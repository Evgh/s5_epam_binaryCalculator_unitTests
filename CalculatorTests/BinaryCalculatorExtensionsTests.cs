using NUnit.Framework;
using s5_epam_binaryCalculator_unitTests;
using s5_epam_binaryCalculator_unitTests.Exceptions;

namespace CalculatorTests
{
    [TestFixture]
    class BinaryCalculatorExtensionsTests
    {
        private static int _validNumber = 9; // 1001
        private static int _expectedNumberFromBinaryView = 9;
        private static string _validNumberBinaryView = "1001";

        private static int _validParameter = 3; // 11
        private static int _validShiftValue = 2;
        private static int _invalidShiftValue = -2;
        private static string _invalidBinaryView = "102";

        private static int _expectedAndResult = 1; 
        private static int _expectedOrResult = 11; // 1011
        private static int _expectedXorResult = 10; // 1010 
        private static int _expectedRightShiftResult = 2; // 10
        private static int _expectedLeftShiftResult = 36; // 100100

        private TestDelegate _doInvalidRightShift = () => _validNumber.BinaryRightShift(_invalidShiftValue);
        private TestDelegate _doInvalidLeftShift = () => _validNumber.BinaryLeftShift(_invalidShiftValue);
        private TestDelegate _getNumberFromInvalidBinaryView = () => _invalidBinaryView.GetNumberFromBinaryView();

        [Test]
        public void BinaryAnd_ValidNumberAndValidParameter_ReturnsExpectedAndResult()
        {
            Assert.AreEqual(_expectedAndResult, _validNumber.BinaryAnd(_validParameter));
        }

        [Test]
        public void BinaryOr_ValidNumberAndValidParameter_ReturnsExpecteOrResult()
        {
            Assert.AreEqual(_expectedOrResult, _validNumber.BinaryOr(_validParameter));
        }

        [Test]
        public void BinaryXor_ValidNumberAndValidParameter_ReturnsExpectedXorResult()
        {
            Assert.AreEqual(_expectedXorResult, _validNumber.BinaryXor(_validParameter));
        }

        [Test]
        public void BinaryRightShift_ValidNumberAndValidShiftValue_ReturnsExpectedRightShiftResult()
        {
            Assert.AreEqual(_expectedRightShiftResult, _validNumber.BinaryRightShift(_validShiftValue));
        }

        [Test]
        public void BinaryLeftShift_ValidNumberAndValidShiftValue_ReturnsExpectedLeftShiftResult()
        {
            Assert.AreEqual(_expectedLeftShiftResult, _validNumber.BinaryLeftShift(_validShiftValue));
        }

        [Test]
        public void GetBinaryView_ValidNumber_ReturnsExpectedValidNumberBinaryView()
        {
            Assert.AreEqual(_validNumberBinaryView, _validNumber.GetBinaryView());
        }

        [Test]
        public void GetNumberFromBinaryView_ValidNumberBinaryView_ReturnsExpectedNumberFromBinaryView()
        {
            Assert.AreEqual(_expectedNumberFromBinaryView, _validNumberBinaryView.GetNumberFromBinaryView());
        }

        [Test]
        public void RightShift_DoInvalidRightShift_ThrowsNegativeShiftValueException()
        {
            Assert.Throws(typeof(NegativeShiftValueException), _doInvalidRightShift);
        }

        [Test]
        public void LeftShift_DoInvalidLeftShift_ThrowsNegativeShiftValueException()
        {
            Assert.Throws(typeof(NegativeShiftValueException), _doInvalidLeftShift);
        }

        [Test]
        public void GetNumberFromBinaryView_InvalidBinaryView_ThrowsStringIsNotBinaryException()
        {
            Assert.Throws(typeof(StringIsNotBinaryException), _getNumberFromInvalidBinaryView);
        }
    }

}