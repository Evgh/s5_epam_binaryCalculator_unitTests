using NUnit.Framework;
using s5_epam_binaryCalculator_unitTests;
using s5_epam_binaryCalculator_unitTests.Exceptions;

namespace CalculatorTests
{
    [TestFixture]
    class BynaryCalculatorTests
    {
        private static int _validNumber = 9; // 1001
        private static int _expectedNumberFromBynaryView = 9;
        private static string _validNumberBynaryView = "1001";

        private static int _validParameter = 3; // 11
        private static int _validShiftValue = 2;
        private static int _invalidShiftValue = -2;
        private static string _invalidBynaryView = "102";

        private static int _expectedAndResult = 1; 
        private static int _expectedOrResult = 11; // 1011
        private static int _expectedXorResult = 10; // 1010 
        private static int _expectedRightShiftResult = 2; // 10
        private static int _expectedLeftShiftResult = 36; // 100100

        private TestDelegate _doInvalidRightShift = () => _validNumber.RightShift(_invalidShiftValue);
        private TestDelegate _doInvalidLeftShift = () => _validNumber.LeftShift(_invalidShiftValue);
        private TestDelegate _getNumberFromInvalidBynaryView = () => _invalidBynaryView.GetNumberFromBynaryView();

        [Test]
        public void And_ValidNumberAndValidParameter_ReturnsExpectedAndResult()
        {
            Assert.AreEqual(_expectedAndResult, _validNumber.And(_validParameter));
        }

        [Test]
        public void Or_ValidNumberAndValidParameter_ReturnsExpecteOrResult()
        {
            Assert.AreEqual(_expectedOrResult, _validNumber.Or(_validParameter));
        }

        [Test]
        public void Xor_ValidNumberAndValidParameter_ReturnsExpectedXorResult()
        {
            Assert.AreEqual(_expectedXorResult, _validNumber.Xor(_validParameter));
        }

        [Test]
        public void RightShift_ValidNumberAndValidShiftValue_ReturnsExpectedRightShiftResult()
        {
            Assert.AreEqual(_expectedRightShiftResult, _validNumber.RightShift(_validShiftValue));
        }

        [Test]
        public void LeftShift_ValidNumberAndValidShiftValue_ReturnsExpectedLeftShiftResult()
        {
            Assert.AreEqual(_expectedLeftShiftResult, _validNumber.LeftShift(_validShiftValue));
        }

        [Test]
        public void GetBynaryView_ValidNumber_ReturnsExpectedValidNumberBynaryView()
        {
            Assert.AreEqual(_validNumberBynaryView, _validNumber.GetBynaryView());
        }

        [Test]
        public void GetNumberFromBynaryView_ValidNumberBynaryView_ReturnsExpectedNumberFromBynaryView()
        {
            Assert.AreEqual(_expectedNumberFromBynaryView, _validNumberBynaryView.GetNumberFromBynaryView());
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
        public void GetNumberFromBynaryView_InvalidBynaryView_ThrowsStringIsNotBynaryException()
        {
            Assert.Throws(typeof(StringIsNotBynaryException), _getNumberFromInvalidBynaryView);
        }
    }

}