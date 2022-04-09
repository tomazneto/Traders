using app.Contants;
using System;

namespace app.Domain
{
    public class MediumRisk : Trade
    {
        public string Category { get { return CategoryConstants.MEDIUMRISK; } }

        public MediumRisk(double value, string clientSector, DateTime nextPaymentDate) : base(value, clientSector, nextPaymentDate)
        {
        }

        public override string ToString()
        {
            return $"{base.ToString()} - {Category}";
        }
    }
}
