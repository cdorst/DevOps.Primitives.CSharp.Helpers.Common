using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class MethodLists
    {
        public static MethodList Create(params Method[] methods)
            => new MethodList(GetListItems(methods));

        private static List<MethodListAssociation> GetListItems(params Method[] methods)
            => methods.Select(method => new MethodListAssociation(method)).ToList();
    }
}
