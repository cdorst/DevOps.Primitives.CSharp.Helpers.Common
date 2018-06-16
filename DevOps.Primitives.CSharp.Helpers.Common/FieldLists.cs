using System;
using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class FieldLists
    {
        private static readonly Func<Field, FieldListAssociation> _selector = field => new FieldListAssociation(in field);

        public static FieldList Create(params Field[] fields)
            => new FieldList(fields.Select(_selector).ToList());
    }
}
