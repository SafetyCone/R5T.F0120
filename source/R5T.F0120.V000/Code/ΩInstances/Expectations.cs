using System;


namespace R5T.F0120.V000
{
    public class Expectations : IExpectations
    {
        #region Infrastructure

        public static IExpectations Instance { get; } = new Expectations();


        private Expectations()
        {
        }

        #endregion
    }
}
