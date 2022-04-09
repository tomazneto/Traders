using app.Interfaces;
using System;

namespace app.Domain
{
    public class Trade : ITrade
    {
        #region construtor
        public Trade(double value, string clientSector, DateTime nextPaymentDate)
        {
            _value = value;
            _clientSector = clientSector;
            _nextPaymentDate = nextPaymentDate;
        }
        #endregion

        #region propriedades
        private double _value { get; set; }
        private string _clientSector { get; set; }
        private DateTime _nextPaymentDate { get; set; }
        #endregion

        #region implementação interface
        
        public double Value => _value;

        public string ClientSector => _clientSector;

        public DateTime NextPaymentDate => _nextPaymentDate;
        #endregion

        #region
        public override string ToString()
        {
            return $"{Value} {ClientSector} {NextPaymentDate:MM/dd/yyyy}";
        }
        #endregion
    }
}
