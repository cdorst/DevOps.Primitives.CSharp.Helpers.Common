using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class ConstructorLists
    {
        public static ConstructorList Create(params Constructor[] constructors)
            => new ConstructorList(GetListItems(constructors));

        private static List<ConstructorListAssociation> GetListItems(params Constructor[] constructors)
            => constructors.Select(constructor => new ConstructorListAssociation(constructor)).ToList();
    }
}
