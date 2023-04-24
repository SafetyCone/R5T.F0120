using System;

using R5T.F0120.Extensions;
using R5T.T0132;


namespace R5T.F0120
{
    [FunctionalityMarker]
    public partial interface IDateTimeFormatOperator : IFunctionalityMarker
    {
        public IDateTimeFormatTemplate ToFormatTemplate(IDateTimeFormat format)
        {
            var output = $"{{0:{format}}}"
                .ToDateTimeFormatTemplate();

            return output;
        }
    }
}
