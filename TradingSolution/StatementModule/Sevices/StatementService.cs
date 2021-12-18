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

        public List<Statement> GetAllStatements()
        {
            List<Statement> loadedStatements = new List<Statement>();
            var statementFiles = _loader.LoadData();

            foreach( var statement in statementFiles)
            {
                if(_parser.TryParse(statement.Text))
                {
                    var parsed = _parser.GetData();
                    parsed.Name = statement.Name;
                    loadedStatements.Add(parsed);
                }

            }

            return loadedStatements;
        }
    }
}
