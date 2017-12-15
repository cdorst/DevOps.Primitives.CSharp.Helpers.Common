using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class UsingDirectiveLists
    {
        public static UsingDirectiveList Create(params UsingDirective[] directives)
            => new UsingDirectiveList(GetListItems(directives));

        public static UsingDirectiveList Create(params string[] directives)
            => Create(
                directives
                    .Select(u => new UsingDirective(u))
                    .Distinct()
                    .OrderBy(u => u)
                    .ToArray());

        private static List<UsingDirectiveListAssociation> GetListItems(params UsingDirective[] directives)
            => directives.Select(u => new UsingDirectiveListAssociation(u)).ToList();
    }
}
