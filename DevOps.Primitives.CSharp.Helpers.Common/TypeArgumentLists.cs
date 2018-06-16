using System;
using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class TypeArgumentLists
    {
        private static readonly Func<TypeArgument, TypeArgumentListAssociation> _argumentSelector = argument => new TypeArgumentListAssociation(in argument);
        private static readonly Func<string, TypeArgument> _stringSelector = argument => new TypeArgument(in argument);

        public static TypeArgumentList Create(params TypeArgument[] arguments)
            => new TypeArgumentList(arguments.Select(_argumentSelector).ToList());

        public static TypeArgumentList Create(params string[] arguments)
            => Create(arguments.Select(_stringSelector).ToArray());
    }
}
