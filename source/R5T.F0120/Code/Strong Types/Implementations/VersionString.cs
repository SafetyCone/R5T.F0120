using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.F0120
{
    /// <inheritdoc cref="IVersionString"/>
    [StrongTypeImplementationMarker]
    public sealed class VersionString : TypedBase<string>, IStrongTypeMarker,
        IVersionString
    {
        public VersionString(string value)
            : base(value)
        {
        }
    }
}
