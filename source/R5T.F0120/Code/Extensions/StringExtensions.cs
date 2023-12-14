using System;


namespace R5T.F0120.Extensions
{
    public static class StringExtensions
    {
        public static Guid ToGuid(this string value)
        {
            return Instances.GuidOperator.Parse(value);
        }

        public static Version ToVersion(this string value)
        {
            var output = Instances.VersionOperator.Parse(value);
            return output;
        }
    }
}
