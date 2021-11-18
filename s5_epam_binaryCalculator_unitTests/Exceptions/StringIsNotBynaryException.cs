using System;

namespace s5_epam_binaryCalculator_unitTests.Exceptions
{
    public class StringIsNotBynaryException : Exception
    {
        public StringIsNotBynaryException() { }
        public StringIsNotBynaryException(string message) : base(message) { }
        public StringIsNotBynaryException(string message, Exception inner) : base(message, inner) { }
        protected StringIsNotBynaryException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
