using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class FieldLists
    {
        public static FieldList Create(params Field[] fields)
            => new FieldList(GetListItems(fields));

        private static List<FieldListAssociation> GetListItems(params Field[] fields)
            => fields.Select(field => new FieldListAssociation(field)).ToList();
    }
}
