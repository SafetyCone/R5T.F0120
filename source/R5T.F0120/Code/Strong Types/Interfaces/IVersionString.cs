using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.F0120
{
    /// <summary>
    /// Typed string for versions as strings.
    /// For example: 1.0, 1.0.3, and 1.0.3-rc5 are all version strings.
    /// </summary>
    [StrongTypeMarker]
    public interface IVersionString : ITyped<string>, IStrongTypeMarker
    {
    }
}
