using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class TypeArgumentLists
    {
        public static TypeArgumentList Create(params TypeArgument[] arguments)
            => new TypeArgumentList(GetListItems(arguments));

        public static TypeArgumentList Create(params string[] arguments)
            => Create(arguments.Select(a => new TypeArgument(a)).ToArray());

        private static List<TypeArgumentListAssociation> GetListItems(params TypeArgument[] arguments)
            => arguments.Select(argument => new TypeArgumentListAssociation(argument)).ToList();
    }
}
