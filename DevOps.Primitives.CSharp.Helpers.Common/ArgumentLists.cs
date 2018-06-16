using System;
using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class ArgumentLists
    {
        private static readonly Func<Argument, ArgumentListAssociation> _selector = argument => new ArgumentListAssociation(in argument);

        public static ArgumentList Create(params Argument[] arguments)
            => new ArgumentList(arguments.Select(_selector).ToList());
    }
}
