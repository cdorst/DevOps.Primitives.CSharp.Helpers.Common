using System;
using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class PropertyLists
    {
        private static readonly Func<Property, PropertyListAssociation> _selector = property => new PropertyListAssociation(property);

        public static PropertyList Create(params Property[] properties)
            => new PropertyList(properties.Select(_selector).ToList());
    }
}
