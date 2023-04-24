using System;

using R5T.T0131;

using R5T.F0120.Extensions;


namespace R5T.F0120.V000
{
    [ValuesMarker]
    public partial interface IFormattedDateTimes : IValuesMarker
    {
        public FormattedDateTime Example => "20230331 151817".ToFormattedDateTime();
    }
}
