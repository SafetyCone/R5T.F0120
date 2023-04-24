using System;


namespace R5T.F0120.V000
{
    public static class Instances
    {
        public static F0101.IAssertion Assertion => F0101.Assertion.Instance;
        public static Z0004.IDateTimes DateTimes => Z0004.DateTimes.Instance;
        public static IDateTimeOperator DateTimeOperator => F0120.DateTimeOperator.Instance;
        public static IEqualityComparers EqualityComparers => V000.EqualityComparers.Instance;
        public static IExpectations Expectations => V000.Expectations.Instance;
        public static IFormattedDateTimes FormattedDateTimes => V000.FormattedDateTimes.Instance;
    }
}