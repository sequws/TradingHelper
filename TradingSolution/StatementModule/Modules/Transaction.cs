using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatementModule.Modules
{
    public enum TransactionType
    {
        Unrecognized,
        Buy,
        Sell,
        BuyLimit,
        SellLimit,
        StopBuy,
        StopSell,
        Balance // deposit/ withdrawal
    }

    public class Transaction
    {
        public int Ticket { get; set; }
        public DateTime TimeOpen { get; set; }
        public DateTime TimeClose { get; set; }
        public TransactionType Type { get; set; }
        public double Size { get; set; }
        public string Item { get; set; }
        public double PriceOpen { get; set; }
        public double PriceClose { get; set; }
        public double StopLoss { get; set; }
        public double TakeProfit { get; set; }
        public double Commision { get; set; }
        public double Taxes { get; set; }
        public double Swap { get; set; }
        public double Profit { get; set; }
        public string Info { get; set; } // cancelled, deleted [reason]
    }
}
