using System;
using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class MethodLists
    {
        private static readonly Func<Method, MethodListAssociation> _selector = method => new MethodListAssociation(in method);

        public static MethodList Create(params Method[] methods)
            => new MethodList(methods.Select(_selector).ToList());
    }
}
