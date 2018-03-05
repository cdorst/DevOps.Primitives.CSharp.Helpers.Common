using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class ArgumentLists
    {
        public static ArgumentList Create(params Argument[] arguments)
            => new ArgumentList(GetListItems(arguments));

        private static List<ArgumentListAssociation> GetListItems(params Argument[] arguments)
            => arguments.Select(argument => new ArgumentListAssociation(argument)).ToList();
    }
}
