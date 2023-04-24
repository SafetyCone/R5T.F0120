using System;

using R5T.T0132;
using R5T.T0180;


namespace R5T.F0120
{
    [FunctionalityMarker]
    public partial interface IExecutableFileRelativePathOperator : IFunctionalityMarker
    {
        /// <summary>
        /// Gets the path of a file placed relative to the executable directory.
        /// Useful for project files that are copied to the output directory.
        /// </summary>
        /// <param name="executableDirectoryRelativeFilePath">A file path relative the the executable directory.</param>
        /// <returns></returns>
        public IFilePath Get_FilePath(IRelativeFilePath executableDirectoryRelativeFilePath)
        {
            return Instances.ExecutableFilePathOperator.Get_ExecutableDirectoryRelativeFilePath(executableDirectoryRelativeFilePath);
        }
    }
}
