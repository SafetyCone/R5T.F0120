using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.F0120
{
    /// <summary>
    /// A year as a strongly-typed integer.
    /// </summary>
    [StrongTypeMarker]
    public interface IYear : ITyped<int>, IStrongTypeMarker
    {
    }
}
