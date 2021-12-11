using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatementModule.Models
{
    public class StatementSummary
    {
        double DepositWithdrawal { get; set; }
        double ClosedTradePL { get; set; }
        double Balance { get; set; }
        double CreditFacility { get; set; }
        double FloatingPL { get; set; }
        double Equity { get; set; }
        double Margin { get; set; }
        double FreeMargin { get; set; }
    }
}
