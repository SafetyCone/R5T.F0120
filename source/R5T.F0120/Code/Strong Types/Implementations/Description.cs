using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.F0120
{
    /// <inheritdoc cref="IDescription"/>
    [StrongTypeImplementationMarker]
    public sealed class Description : TypedBase<string>, IStrongTypeMarker,
        IDescription
    {
        public Description(string value)
            : base(value)
        {
        }
    }
}
