using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class StatementLists
    {
        public static StatementList Create(params Statement[] statements)
            => new StatementList(GetListItems(statements));

        public static StatementList Create(params string[] statements)
            => Create(statements.Select(s => new Statement(s)).ToArray());

        private static List<StatementListAssociation> GetListItems(params Statement[] statements)
            => statements.Select(statement => new StatementListAssociation(statement)).ToList();
    }
}
