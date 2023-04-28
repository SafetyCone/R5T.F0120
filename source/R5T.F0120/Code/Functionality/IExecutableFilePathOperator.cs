using System;

using R5T.T0132;
using R5T.T0180;
using R5T.T0180.Extensions;
using R5T.T0181;
using R5T.T0181.Extensions;


namespace R5T.F0120
{
    [FunctionalityMarker]
    public partial interface IExecutableFilePathOperator : IFunctionalityMarker
    {
        private static F0000.IExecutablePathOperator StringlyTypedOperator => F0000.ExecutablePathOperator.Instance;
        private static F0002.IPathOperator StringlyTypedPathOperator => F0002.PathOperator.Instance;


        /// <inheritdoc cref="F0000.IExecutablePathOperator.Get_ExecutableFilePath"/>
        public IExecutableFilePath Get_ExecutableFilePath()
        {
            var output = StringlyTypedOperator.Get_ExecutableFilePath()
                .ToExecutableFilePath();

            return output;
        }

        /// <inheritdoc cref="F0002.IExecutablePathOperator.GetExecutableDirectoryPath"/>
        public IExecutableDirectoryPath Get_ExecutableDirectoryPath()
        {
            var executableFilePath = this.Get_ExecutableFilePath();

            var output = StringlyTypedPathOperator.GetParentDirectoryPath_ForFile(executableFilePath.Value)
                .ToExecutableDirectoryPath();

            return output;
        }

        public IFilePath Get_ExecutableDirectoryRelativeFilePath(IRelativeFilePath relativeFilePath)
        {
            var executableDirectoryPath = this.Get_ExecutableDirectoryPath();

            var output = StringlyTypedPathOperator.GetFilePath(
                executableDirectoryPath.Value,
                relativeFilePath.Value)
                .ToFilePath();

            return output;
        }
    }
}
