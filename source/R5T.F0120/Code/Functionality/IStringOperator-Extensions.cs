using System;

using R5T.T0132;


namespace R5T.F0120.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public ICompanyName ToCompanyName(string value)
        {
            var output = new CompanyName(value);
            return output;
        }

        public IDateTimeFormat ToDateTimeFormat(string value)
        {
            var output = new DateTimeFormat(value);
            return output;
        }

        public IDescription ToDescription(string value)
        {
            var output = new Description(value);
            return output;
        }

        public IDateTimeFormatTemplate ToDateTimeFormatTemplate(string value)
        {
            var output = new DateTimeFormatTemplate(value);
            return output;
        }

        public IFormatted ToFormatted(string value)
        {
            var output = new Formatted(value);
            return output;
        }

        public IFormattedDateTime ToFormattedDateTime(string value)
        {
            var output = new FormattedDateTime(value);
            return output;
        }

        public IVersionString ToVersionString(string value)
        {
            var output = new VersionString(value);
            return output;
        }
    }
}
