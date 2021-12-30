using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalModule.Models
{
    /// <summary>
    /// Describes enter to the market
    /// - Strategy as rule set
    /// </summary>
    public class Entry
    {
        public Strategy Strategy { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
    }

}
