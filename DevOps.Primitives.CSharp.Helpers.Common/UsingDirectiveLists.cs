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
                    .OrderBy(@using => @using)
                    .Select(@using => new UsingDirective(in @using))
                    .ToArray());

        private static List<UsingDirectiveListAssociation> GetListItems(params UsingDirective[] directives)
            => directives.Select(@using => new UsingDirectiveListAssociation(in @using)).ToList();
    }
}
