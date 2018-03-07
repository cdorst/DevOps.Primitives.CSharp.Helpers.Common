using System;
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
                    .Distinct()
                    .OrderBy(u => u)
                    .Select(u => new UsingDirective(u))
                    .ToArray());

        private static List<UsingDirectiveListAssociation> GetListItems(params UsingDirective[] directives)
            => directives.Select(u => new UsingDirectiveListAssociation(u)).ToList();
    }
}
