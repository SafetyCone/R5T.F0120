using System;

using R5T.N0003;
using R5T.N0003.Extensions;

using R5T.T0132;


namespace R5T.F0120
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public string Format_ToString(
            IFormatTemplate template,
            params object[] objects)
        {
            var output = String.Format(
                template.Value,
                objects);

            return output;
        }

        public IFormatted Format(
            IFormatTemplate template,
            params object[] objects)
        {
            var output = this.Format_ToString(
                template,
                objects)
                .ToFormatted();

            return output;
        }
    }
}
