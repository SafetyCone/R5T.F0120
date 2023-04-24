using System;


namespace R5T.F0120.V000
{
    public class EqualityComparers : IEqualityComparers
    {
        #region Infrastructure

        public static IEqualityComparers Instance { get; } = new EqualityComparers();


        private EqualityComparers()
        {
        }

        #endregion
    }
}
