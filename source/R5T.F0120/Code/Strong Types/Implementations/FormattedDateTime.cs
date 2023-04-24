using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.F0120
{
    /// <inheritdoc cref="IFormattedDateTime"/>
    [StrongTypeImplementationMarker]
    public sealed class FormattedDateTime : TypedBase<string>, IStrongTypeMarker,
        IFormattedDateTime
    {
        public FormattedDateTime(string value)
            : base(value)
        {
        }
    }
}
