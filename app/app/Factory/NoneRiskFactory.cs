using app.Domain;
using System;

namespace app.Factory
{
    public class NoneRiskFactory : TradeFactory
    {
        private double _value { get; set; }
        private string _clientSector { get; set; }
        private DateTime _nextPaymentDate { get; set; }

        public NoneRiskFactory(double value, string clientSector, DateTime nextPaymentDate)
        {
            _value = value;
            _clientSector = clientSector;
            _nextPaymentDate = nextPaymentDate;
        }

        public override Trade Criar()
        {
            return new NoneRisk(_value, _clientSector, _nextPaymentDate);
        }
    }
}
