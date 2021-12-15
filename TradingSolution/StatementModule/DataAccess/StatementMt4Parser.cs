using Core.Abstractions;
using StatementModule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatementModule.DataAccess
{
    public class StatementMt4Parser : Parser
    {
        public Statement ParsedStatement { get; set; } = new Statement();

        public override bool TryParse(List<string> input)
        {
            throw new NotImplementedException();
        }
    }
}
