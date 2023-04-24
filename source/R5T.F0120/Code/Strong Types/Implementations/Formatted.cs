using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.F0120
{
    /// <inheritdoc cref="IFormatted"/>
    [StrongTypeImplementationMarker]
    public sealed class Formatted : TypedBase<string>, IStrongTypeMarker,
        IFormatted
    {
        public Formatted(string value)
            : base(value)
        {
        }
    }
}
