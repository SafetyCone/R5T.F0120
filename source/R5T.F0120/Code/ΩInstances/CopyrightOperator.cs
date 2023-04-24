using System;


namespace R5T.F0120
{
    public class CopyrightOperator : ICopyrightOperator
    {
        #region Infrastructure

        public static ICopyrightOperator Instance { get; } = new CopyrightOperator();


        private CopyrightOperator()
        {
        }

        #endregion
    }
}
