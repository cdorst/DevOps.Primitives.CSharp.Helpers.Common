using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class ConstructorLists
    {
        public static ConstructorList Create(params Constructor[] attributes)
            => new ConstructorList(GetListItems(attributes));

        private static List<ConstructorListAssociation> GetListItems(params Constructor[] attributes)
            => attributes.Select(attribute => new ConstructorListAssociation(attribute)).ToList();
    }
}
