using System;
using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class ConstructorLists
    {
        private static readonly Func<Constructor, ConstructorListAssociation> _selector = constructor => new ConstructorListAssociation(in constructor);

        public static ConstructorList Create(params Constructor[] constructors)
            => new ConstructorList(constructors.Select(_selector).ToList());
    }
}
