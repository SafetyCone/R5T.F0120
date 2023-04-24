using System;

using R5T.T0132;

using R5T.F0120.Extensions;


namespace R5T.F0120
{
    [FunctionalityMarker]
    public partial interface ICopyrightOperator : IFunctionalityMarker
    {
        public string Get_CopyrightText(
            string copyrightHolder,
            IYear copyrightYear)
        {
            var output = $"Copyright {Instances.Strings.Copyright} {copyrightHolder} {copyrightYear}";
            return output;
        }

        public string Get_CopyrightText(
            string copyrightHolder,
            DateTime copyrightDate)
        {
            var copyrightYear = copyrightDate.Year.ToYear();

            var output = this.Get_CopyrightText(
                copyrightHolder,
                copyrightYear);

            return output;
        }

        public string Get_CopyrightText(string copyrightHolder)
        {
            var copyrightYear = Instances.NowOperator.GetCurrentYear()
                .ToYear();

            var output = this.Get_CopyrightText(
                copyrightHolder,
                copyrightYear);

            return output;
        }
    }
}
