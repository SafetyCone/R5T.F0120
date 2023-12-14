using System;

using R5T.N0003;


namespace R5T.F0120.Extensions
{
    public static class DateTimeFormatExtensions
    {
        public static IDateTimeFormatTemplate ToDateTimeFormatTemplate(this IDateTimeFormat dateTimeFormat)
        {
            return Instances.DateTimeFormatOperator.ToFormatTemplate(dateTimeFormat);
        }
    }
}
