using System;

using R5T.T0178;


namespace R5T.F0120
{
    /// <summary>
    /// Typed string for <see cref="DateTime"/> format template strings.
    /// (Example: "{0:yyyyMMdd HHmmss}" for "20230331 144120".)
    /// Can be used as the template in <see cref="String.Format(string, object)"/>.
    /// </summary>
    [StrongTypeMarker]
    public interface IDateTimeFormatTemplate : IStrongTypeMarker,
        IFormatTemplate
    {
    }
}
