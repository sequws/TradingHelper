using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalModule.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Strategy
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Rule> Rules { get; set; }
    }

    public class Rule
    {
        public string Description { get; set; }
        public bool Satisfied { get; set; }
    }

    public enum TransactionStatus
    {
        Open,
        Close,
        Pending
    }

    public class TransactionHistory
    {
        public DateTime Date { get; set; }
        public TransactionStatus Status { get; set; }
    }
}
