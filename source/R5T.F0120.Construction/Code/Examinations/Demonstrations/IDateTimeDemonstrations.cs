using System;

using R5T.T0141;


namespace R5T.F0120.Construction
{
    [DemonstrationsMarker]
    public partial interface IDateTimeDemonstrations : IDemonstrationsMarker
    {
        public void Format_YYYYMMDD_HHMMSS()
        {
            var formatted = Instances.DateTimeOperator.ToString_YYYYMMDD_HHMMSS(
                Instances.DateTimes.Example);

            Console.WriteLine(formatted);
        }
    }
}
