using System;

using R5T.N0003;
using R5T.N0003.Extensions;

using R5T.T0132;


namespace R5T.F0120
{
    [FunctionalityMarker]
    public partial interface IDateTimeOperator : IFunctionalityMarker
    {
        public string Format_ToString(
            IDateTimeFormatTemplate formatTemplate,
            DateTime dateTime)
        {
            var output = Instances.StringOperator.Format_ToString(
                formatTemplate,
                dateTime);

            return output;
        }

        public IFormattedDateTime Format(
            IDateTimeFormatTemplate formatTemplate,
            DateTime dateTime)
        {
            var output = this.Format_ToString(
                formatTemplate,
                dateTime)
                .ToFormattedDateTime();

            return output;
        }

        /// <summary>
        /// Chooses <see cref="ToString_YYYYMMDD_HHMMSS_Space(DateTime)"/> as the default.
        /// </summary>
        public string ToString_YYYYMMDD_HHMMSS(DateTime dateTime)
        {
            var output = this.ToString_YYYYMMDD_HHMMSS_Space(dateTime);
            return output;
        }

        public string ToString_YYYYMMDD_HHMMSS_Space(DateTime dateTime)
        {
            var output = this.Format_ToString(
                Instances.DateTimeFormatTemplates.YYYYMMDD_HHMMSS,
                dateTime);

            return output;
        }

        /// <summary>
        /// Chooses <see cref="ToString_YYYYMMDD_HHMMSS_Space(DateTime)"/> as the default.
        /// </summary>
        public IFormattedDateTime To_YYYYMMDD_HHMMSS(DateTime dateTime)
        {
            var output = this.To_YYYYMMDD_HHMMSS_Space(dateTime);
            return output;
        }

        public IFormattedDateTime To_YYYYMMDD_HHMMSS_Space(DateTime dateTime)
        {
            var output = this.Format_ToString(
                Instances.DateTimeFormatTemplates.YYYYMMDD_HHMMSS,
                dateTime)
                .ToFormattedDateTime();

            return output;
        }

        public IFormattedDateTime To_YYYYMMDD_HHMMSS_Dashed(DateTime dateTime)
        {
            var output = this.Format_ToString(
                Instances.DateTimeFormatTemplates.YYYYMMDD_HHMMSS_Dashed,
                dateTime)
                .ToFormattedDateTime();

            return output;
        }
    }
}
