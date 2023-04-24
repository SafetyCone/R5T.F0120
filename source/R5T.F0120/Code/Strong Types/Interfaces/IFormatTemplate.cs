using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.F0120
{
    /// <summary>
    /// Typed string for format template strings.
    /// (Example: "{0:yyyyMMdd HHmmss}" for "20230331 144120".)
    /// Can be used as the template in <see cref="String.Format(string, object)"/>.
    /// </summary>
    [StrongTypeMarker]
    public interface IFormatTemplate : ITyped<string>, IStrongTypeMarker
    {
    }
}
