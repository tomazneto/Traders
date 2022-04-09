using app.Domain;
using System;

namespace app.Factory
{
    public class ExpiredFactory : TradeFactory
    {
        private double _value { get; set; }
        private string _clientSector { get; set; }
        private DateTime _nextPaymentDate { get; set; }
        private DateTime _reference { get; set; }

        public ExpiredFactory(double value, string clientSector, DateTime nextPaymentDate, DateTime reference)
        {
            _value = value;
            _clientSector = clientSector;
            _nextPaymentDate = nextPaymentDate;
            _reference = reference;
        }

        public override Trade Criar()
        {
            if (_reference.Subtract(_nextPaymentDate).TotalDays > 30)
                return new Expired(_value, _clientSector, _nextPaymentDate);

            return null;
        }
    }
}
