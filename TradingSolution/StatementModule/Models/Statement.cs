using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatementModule.Models
{
    public class Statement
    {
        public string Name { get; set; }

        public StatementInfo Info { get; set; }
        public StatementStats Stats { get; set; }
        public StatementSummary Summary { get; set; }

        public List<Transaction> ClosedTrades { get; set; } = new List<Transaction>();
        public List<Transaction> OpenTrades { get; set; } = new List<Transaction>();
        public List<Transaction> WorkingTrades { get; set; } = new List<Transaction>();

        public override string ToString()
        {
            return $"{Name}, transactions: {ClosedTrades.Count}";
        }
    }
}
