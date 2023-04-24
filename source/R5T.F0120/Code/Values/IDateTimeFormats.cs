using System;

using R5T.T0131;

using R5T.F0120.Extensions;


namespace R5T.F0120
{
    [ValuesMarker]
    public partial interface IDateTimeFormats : IValuesMarker
    {
        public IDateTimeFormat YYYYMMDD => "yyyyMMdd".ToDateTimeFormat();
        public IDateTimeFormat YYYYMMDD_HHMMSS => "yyyyMMdd HHmmss".ToDateTimeFormat();
        public IDateTimeFormat YYYYMMDD_HHMMSS_Dashed => "yyyyMMdd-HHmmss".ToDateTimeFormat();
        public IDateTimeFormat YYYY_MM_DD_Dashed => "yyyy-MM-dd".ToDateTimeFormat();
    }
}
