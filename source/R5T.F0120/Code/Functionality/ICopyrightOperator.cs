using System;

using R5T.N0003;

using R5T.T0132;


namespace R5T.F0120
{
    [FunctionalityMarker]
    public partial interface ICopyrightOperator : IFunctionalityMarker,
        L0071.ICopyrightOperator
    {
        public string Get_CopyrightText(
            string copyrightHolder,
            IYear copyrightYear)
        {
            var output = this.Get_CopyrightText(
                copyrightHolder,
                copyrightYear.Value);

            return output;
        }
    }
}
