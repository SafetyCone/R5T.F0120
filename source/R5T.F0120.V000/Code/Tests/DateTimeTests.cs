using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using R5T.F0101.Extensions;


namespace R5T.F0120.V000
{
    [TestClass]
    public class DateTimeTests
    {
        [TestMethod]
        public void To_YYYYMMDD_HHMMSS()
        {
            var expectation = Instances.Expectations.ToString_YYYYMMDD_HHMMSS_Dashed;

            expectation.Assert(
                Instances.DateTimeOperator.To_YYYYMMDD_HHMMSS_Dashed);
        }
    }
}
