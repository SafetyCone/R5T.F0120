using System;


namespace R5T.F0120
{
    public static class Instances
    {
        public static IDateTimeFormatOperator DateTimeFormatOperator => F0120.DateTimeFormatOperator.Instance;
        public static IDateTimeFormats DateTimeFormats => F0120.DateTimeFormats.Instance;
        public static IDateTimeFormatTemplates DateTimeFormatTemplates => F0120.DateTimeFormatTemplates.Instance;
        public static IExecutableFilePathOperator ExecutableFilePathOperator => F0120.ExecutableFilePathOperator.Instance;
        public static F0000.IGuidOperator GuidOperator => F0000.GuidOperator.Instance;
        public static Extensions.IIntegerOperator IntegerOperator_Extensions => Extensions.IntegerOperator.Instance;
        public static F0000.INowOperator NowOperator => F0000.NowOperator.Instance;
        public static Extensions.IStringOperator StringOperator_Extensions => Extensions.StringOperator.Instance;
        public static IStringOperator StringOperator => F0120.StringOperator.Instance;
        public static Z0000.IStrings Strings => Z0000.Strings.Instance;
        public static F0000.IVersionOperator VersionOperator => F0000.VersionOperator.Instance;
    }
}