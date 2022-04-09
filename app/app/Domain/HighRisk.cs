using app.Contants;
using System;

namespace app.Domain
{
    public class HighRisk : Trade
    {
        public string Category { get { return CategoryConstants.HIGHRISK; } }

        public HighRisk(double value, string clientSector, DateTime nextPaymentDate) : base(value, clientSector, nextPaymentDate)
        {
        }

        public override string ToString()
        {
            return $"{base.ToString()} - {Category}";
        }
    }
}
