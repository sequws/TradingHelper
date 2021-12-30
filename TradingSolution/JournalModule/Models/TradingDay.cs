using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalModule.Models
{
    public class TradingDay
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public List<Entry> Entries { get; set; }
        public List<TransactionHistory> Transactions { get; set; }
    }
}
