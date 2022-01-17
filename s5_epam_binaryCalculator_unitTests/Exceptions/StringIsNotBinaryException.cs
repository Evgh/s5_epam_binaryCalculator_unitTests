using System;

namespace s5_epam_binaryCalculator_unitTests.Exceptions
{
    public class StringIsNotBinaryException : Exception
    {
        public StringIsNotBinaryException() { }
        public StringIsNotBinaryException(string message) : base(message) { }
        public StringIsNotBinaryException(string message, Exception inner) : base(message, inner) { }
        protected StringIsNotBinaryException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
