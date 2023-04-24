using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.F0120
{
    /// <summary>
    /// Typed string for string containing formatted representations of other objects.
    /// </summary>
    [StrongTypeMarker]
    public interface IFormatted : ITyped<string>, IStrongTypeMarker
    {
    }
}
