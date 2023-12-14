using System;

using R5T.N0003;
using R5T.N0003.Extensions;

using R5T.T0131;

using R5T.F0120.Extensions;


namespace R5T.F0120
{
    [ValuesMarker]
    public partial interface IDateTimeFormatTemplates : IValuesMarker
    {
        public IDateTimeFormatTemplate YYYYMMDD => Instances.DateTimeFormats.YYYYMMDD.ToDateTimeFormatTemplate();
        public IDateTimeFormatTemplate YYYYMMDD_HHMMSS => Instances.DateTimeFormats.YYYYMMDD_HHMMSS.ToDateTimeFormatTemplate();
        public IDateTimeFormatTemplate YYYYMMDD_HHMMSS_Dashed => Instances.DateTimeFormats.YYYYMMDD_HHMMSS_Dashed.ToDateTimeFormatTemplate();
        public IDateTimeFormatTemplate YYYY_MM_DD_Dashed => Instances.DateTimeFormats.YYYY_MM_DD_Dashed.ToDateTimeFormatTemplate();
    }
}
