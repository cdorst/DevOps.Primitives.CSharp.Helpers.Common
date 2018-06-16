using System;
using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class ParameterLists
    {
        private static readonly Func<Parameter, ParameterListAssociation> _selector = parameter => new ParameterListAssociation(parameter);

        public static ParameterList Create(params Parameter[] parameters)
            => new ParameterList(parameters.Select(_selector).ToList());

        public static ParameterList Single(in string name, in string type)
            => new ParameterList(in name, in type);
    }
}
