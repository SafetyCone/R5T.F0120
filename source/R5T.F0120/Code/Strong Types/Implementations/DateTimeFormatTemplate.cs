using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.F0120
{
    /// <inheritdoc cref="IDateTimeFormatTemplate"/>
    [StrongTypeImplementationMarker]
    public sealed class DateTimeFormatTemplate : TypedBase<string>, IStrongTypeMarker,
        IDateTimeFormatTemplate
    {
        public DateTimeFormatTemplate(string value)
            : base(value)
        {
        }
    }
}
