using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class PropertyLists
    {
        public static PropertyList Create(params Property[] properties)
            => new PropertyList(GetListItems(properties));

        private static List<PropertyListAssociation> GetListItems(params Property[] properties)
            => properties.Select(property => new PropertyListAssociation(property)).ToList();
    }
}
