using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.F0120
{
    /// <inheritdoc cref="IFormatTemplate"/>
    [StrongTypeImplementationMarker]
    public sealed class FormatTemplate : TypedBase<string>, IStrongTypeMarker,
        IFormatTemplate
    {
        public FormatTemplate(string value)
            : base(value)
        {
        }
    }
}
