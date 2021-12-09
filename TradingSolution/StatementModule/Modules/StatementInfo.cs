using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatementModule.Modules
{
    /// <summary>
    /// Data about statement/account/owner
    /// </summary>
    public class StatementInfo
    {
        public string AccountNumber { get; set; }
        public string OwnerName { get; set; }
        public string Currency { get; set; }
        public string Leverage { get; set; }
        public string Date { get; set; }
    }
}
