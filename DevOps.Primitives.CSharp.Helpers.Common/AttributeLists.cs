using System;
using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class AttributeLists
    {
        private static readonly Func<Attribute, AttributeListCollectionAssociation> _selector = attribute => new AttributeListCollectionAssociation(in attribute);

        public static AttributeListCollection Create(params Attribute[] attributes)
            => new AttributeListCollection(attributes.Select(_selector).ToList());
    }
}
