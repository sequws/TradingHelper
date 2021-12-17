using Core.Interfaces;
using StatementModule.Interfaces;
using StatementModule.Models;
using System.Collections.Generic;

namespace StatementModule.Sevices
{
    public class StatementService : IStatementService
    {
        private readonly ILoader<StatementFile> _loader;
        private readonly IParser<Statement> _parser;

        public StatementService(ILoader<StatementFile> loader, IParser<Statement> parser)
        {
            _loader = loader;
            _parser = parser;
        }

        public IEnumerable<Statement> GetAllStatements()
        {
            IEnumerable<Statement> loadedStatements = new List<Statement>();
            var files = _loader.GetFiles();

            foreach( var file in files)
            {


            }

            return loadedStatements;
        }
    }
}
