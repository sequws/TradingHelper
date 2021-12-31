using JournalModule.Common;
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

    public class TransactionHistory
    {
        public DateTime Date { get; set; }
        public TransactionStatus Status { get; set; }
    }
}
