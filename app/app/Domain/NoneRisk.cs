using app.Contants;
using System;

namespace app.Domain
{
    public class NoneRisk : Trade
    {
        public string Category { get { return CategoryConstants.NONERISCK; } }

        public NoneRisk(double value, string clientSector, DateTime nextPaymentDate)
            : base(value, clientSector, nextPaymentDate)
        {
        }

        public override string ToString()
        {
            return $"{base.ToString()} - {Category}";
        }
    }
}
