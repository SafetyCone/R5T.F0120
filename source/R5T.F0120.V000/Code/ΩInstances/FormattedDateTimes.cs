using System;


namespace R5T.F0120.V000
{
    public class FormattedDateTimes : IFormattedDateTimes
    {
        #region Infrastructure

        public static IFormattedDateTimes Instance { get; } = new FormattedDateTimes();


        private FormattedDateTimes()
        {
        }

        #endregion
    }
}
