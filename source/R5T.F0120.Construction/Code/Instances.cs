using System;


namespace R5T.F0120.Construction
{
    public static class Instances
    {
        public static IDateTimeOperator DateTimeOperator => F0120.DateTimeOperator.Instance;
        public static Z0004.IDateTimes DateTimes => Z0004.DateTimes.Instance;
    }
}