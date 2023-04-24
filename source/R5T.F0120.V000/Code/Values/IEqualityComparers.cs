using System;

using R5T.F0000.T000;
using R5T.T0131;


namespace R5T.F0120.V000
{
    [ValuesMarker]
    public partial interface IEqualityComparers : IValuesMarker
    {
        public IEqualityComparer<IFormattedDateTime> For_IFormattedDateTime => new FunctionBasedEqualityComparer<IFormattedDateTime>(
            (a, b) => a.Value.Equals(b.Value));
    }
}
