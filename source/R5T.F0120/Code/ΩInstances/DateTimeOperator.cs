using System;


namespace R5T.F0120
{
    public class DateTimeOperator : IDateTimeOperator
    {
        #region Infrastructure

        public static IDateTimeOperator Instance { get; } = new DateTimeOperator();


        private DateTimeOperator()
        {
        }

        #endregion
    }
}
