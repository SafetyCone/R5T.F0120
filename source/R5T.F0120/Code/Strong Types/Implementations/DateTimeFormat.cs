using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.F0120
{
    /// <inheritdoc cref="IDateTimeFormat"/>
    [StrongTypeImplementationMarker]
    public sealed class DateTimeFormat : TypedBase<string>, IStrongTypeMarker,
        IDateTimeFormat
    {
        public DateTimeFormat(string value)
            : base(value)
        {
        }
    }
}
