using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class AttributeLists
    {
        public static AttributeListCollection Create(params Attribute[] attributes)
            => new AttributeListCollection(GetListItems(attributes));

        private static List<AttributeListCollectionAssociation> GetListItems(params Attribute[] attributes)
            => attributes.Select(attribute => new AttributeListCollectionAssociation(attribute)).ToList();
    }
}
