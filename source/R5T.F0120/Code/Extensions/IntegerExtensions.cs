using System;


namespace R5T.F0120.Extensions
{
    public static class IntegerExtensions
    {
        public static IYear ToYear(this int value)
        {
            return Instances.IntegerOperator_Extensions.ToYear(value);
        }
    }
}
