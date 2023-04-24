using System;


namespace R5T.F0120
{
    public class DateTimeFormatOperator : IDateTimeFormatOperator
    {
        #region Infrastructure

        public static IDateTimeFormatOperator Instance { get; } = new DateTimeFormatOperator();


        private DateTimeFormatOperator()
        {
        }

        #endregion
    }
}
