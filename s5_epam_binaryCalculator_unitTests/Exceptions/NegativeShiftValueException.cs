using System;

namespace s5_epam_binaryCalculator_unitTests.Exceptions
{
    public class NegativeShiftValueException : Exception
    {
        public NegativeShiftValueException() { }
        public NegativeShiftValueException(string message) : base(message) { }
        public NegativeShiftValueException(string message, Exception inner) : base(message, inner) { }
        protected NegativeShiftValueException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
