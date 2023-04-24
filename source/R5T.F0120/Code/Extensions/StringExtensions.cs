using System;


namespace R5T.F0120.Extensions
{
    public static class StringExtensions
    {
        public static ICompanyName ToCompanyName(this string value)
        {
            return Instances.StringOperator_Extensions.ToCompanyName(value);
        }

        public static IDescription ToDescription(this string value)
        {
            return Instances.StringOperator_Extensions.ToDescription(value);
        }

        public static IDateTimeFormat ToDateTimeFormat(this string value)
        {
            return Instances.StringOperator_Extensions.ToDateTimeFormat(value);
        }

        public static IDateTimeFormatTemplate ToDateTimeFormatTemplate(this string value)
        {
            return Instances.StringOperator_Extensions.ToDateTimeFormatTemplate(value);
        }

        public static IFormatted ToFormatted(this string value)
        {
            return Instances.StringOperator_Extensions.ToFormatted(value);
        }

        public static IFormattedDateTime ToFormattedDateTime(this string value)
        {
            return Instances.StringOperator_Extensions.ToFormattedDateTime(value);
        }

        public static Guid ToGuid(this string value)
        {
            return Instances.GuidOperator.Parse(value);
        }

        public static Version ToVersion(this string value)
        {
            var output = Instances.VersionOperator.Parse(value);
            return output;
        }

        public static IVersionString ToVersionString(this string value)
        {
            return Instances.StringOperator_Extensions.ToVersionString(value);
        }
    }
}
