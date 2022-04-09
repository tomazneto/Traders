using app.Contants;
using app.Domain;
using System;

namespace app.Factory
{
    public class MediumRiskFactory : TradeFactory
    {
        private double _value { get; set; }
        private string _clientSector { get; set; }
        private DateTime _nextPaymentDate { get; set; }

        public MediumRiskFactory(double value, string clientSector, DateTime nextPaymentDate)
        {
            _value = value;
            _clientSector = clientSector;
            _nextPaymentDate = nextPaymentDate;
        }

        public override Trade Criar()
        {
            if (_value > 1000000 && _clientSector.Equals(ClientSectorConstants.PUBLIC))
                return new MediumRisk(_value, _clientSector, _nextPaymentDate);

            return null;
        }
    }
}
