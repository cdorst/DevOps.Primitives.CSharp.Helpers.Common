using System;
using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class TypeParameterLists
    {
        private static readonly Func<TypeParameter, TypeParameterListAssociation> _parameterSelector = parameter => new TypeParameterListAssociation(in parameter);
        private static readonly Func<string, TypeParameter> _stringSelector = parameter => new TypeParameter(in parameter);

        public static TypeParameterList Create(params TypeParameter[] parameters)
            => new TypeParameterList(parameters.Select(_parameterSelector).ToList());

        public static TypeParameterList Create(params string[] parameters)
            => Create(parameters.Select(_stringSelector).ToArray());
    }
}
