using StatementModule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatementModule.Interfaces
{
    public interface IStatementService
    {
        IEnumerable<Statement> GetAllStatements();
    }
}
