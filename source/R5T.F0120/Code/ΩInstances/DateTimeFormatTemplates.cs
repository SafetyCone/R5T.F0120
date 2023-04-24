using System;


namespace R5T.F0120
{
    public class DateTimeFormatTemplates : IDateTimeFormatTemplates
    {
        #region Infrastructure

        public static IDateTimeFormatTemplates Instance { get; } = new DateTimeFormatTemplates();


        private DateTimeFormatTemplates()
        {
        }

        #endregion
    }
}
