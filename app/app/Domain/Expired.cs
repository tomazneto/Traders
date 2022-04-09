using app.Contants;
using System;

namespace app.Domain
{
    public class Expired : Trade
    {
        public string Category { get { return CategoryConstants.EXPIRED; } }

        public Expired(double value, string clientSector, DateTime nextPaymentDate) : base(value, clientSector, nextPaymentDate)
        {
        }

        public override string ToString()
        {
            return $"{base.ToString()} - {Category}";
        }
    }
}
