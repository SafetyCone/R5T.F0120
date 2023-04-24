using System;

using R5T.T0120;
using R5T.T0131;


namespace R5T.F0120.V000
{
    [ValuesMarker]
    public partial interface IExpectations : IValuesMarker
    {
        public IExpectation<DateTime, IFormattedDateTime> ToString_YYYYMMDD_HHMMSS => new Expectation<DateTime, IFormattedDateTime>
        {
            Input = Instances.DateTimes.Example,
            Output = Instances.FormattedDateTimes.Example,
            OutputEqualityComparer = Instances.EqualityComparers.For_IFormattedDateTime,
        };
    }
}
