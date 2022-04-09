using app.Domain;
using app.Factory;
using System;
using System.Collections.Generic;
using System.Linq;

namespace app.Service
{
    public class Creator
    {
        private List<Trade> Trades { get; set; }

        public Creator(List<Trade> _trades)
        {
            Trades = _trades;
        }

        public List<Trade> GetTraders(double value, string clientSector, DateTime nextPaymentDate)
        {
            Add(GetTrade(new ExpiredFactory(value, clientSector, nextPaymentDate, DateTime.Now)));
            Add(GetTrade(new HighRiskFactory(value, clientSector, nextPaymentDate)));
            Add(GetTrade(new MediumRiskFactory(value, clientSector, nextPaymentDate)));
            return Trades;
        }

        private void Add(Trade _trade)
        {
            if (_trade != null)
                Trades.Add(_trade);
        }
        private Trade GetTrade(TradeFactory tradeFactory)
        {
            return tradeFactory.Criar();
        }
    }
}
