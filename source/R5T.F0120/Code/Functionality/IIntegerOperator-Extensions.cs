using System;

using R5T.T0132;


namespace R5T.F0120.Extensions
{
    [FunctionalityMarker]
    public partial interface IIntegerOperator : IFunctionalityMarker
    {
        public IYear ToYear(int value)
        {
            var output = new Year(value);
            return output;
        }
    }
}
