using System;


namespace R5T.F0120
{
    public class DateTimeFormats : IDateTimeFormats
    {
        #region Infrastructure

        public static IDateTimeFormats Instance { get; } = new DateTimeFormats();


        private DateTimeFormats()
        {
        }

        #endregion
    }
}
