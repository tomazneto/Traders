using app.Contants;
using app.Domain;
using System;

namespace app.Factory
{
    public class HighRiskFactory : TradeFactory
    {
        private double _value { get; set; }
        private string _clientSector { get; set; }
        private DateTime _nextPaymentDate { get; set; }

        public HighRiskFactory(double value, string clientSector, DateTime nextPaymentDate)
        {
            _value = value;
            _clientSector = clientSector;
            _nextPaymentDate = nextPaymentDate;
        }

        public override Trade Criar()
        {
            if (_value > 1000000 && _clientSector.Equals(ClientSectorConstants.PRIVATE))
                return new HighRisk(_value, _clientSector, _nextPaymentDate);

            return null;
        }
    }
}
