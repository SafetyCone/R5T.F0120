using System;


namespace R5T.F0120
{
    public class IntegerOperator : IIntegerOperator
    {
        #region Infrastructure

        public static IIntegerOperator Instance { get; } = new IntegerOperator();


        private IntegerOperator()
        {
        }

        #endregion
    }
}
