using System;
using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class StatementLists
    {
        private static readonly Func<Statement, StatementListAssociation> _statementSelector = statement => new StatementListAssociation(in statement);
        private static readonly Func<string, Statement> _stringSelector = statement => new Statement(in statement);

        public static StatementList Create(params Statement[] statements)
            => new StatementList(statements.Select(_statementSelector).ToList());

        public static StatementList Create(params string[] statements)
            => Create(statements.Select(_stringSelector).ToArray());
    }
}
