using System;


namespace R5T.F0120
{
    public class ExecutableFilePathOperator : IExecutableFilePathOperator
    {
        #region Infrastructure

        public static IExecutableFilePathOperator Instance { get; } = new ExecutableFilePathOperator();


        private ExecutableFilePathOperator()
        {
        }

        #endregion
    }
}
