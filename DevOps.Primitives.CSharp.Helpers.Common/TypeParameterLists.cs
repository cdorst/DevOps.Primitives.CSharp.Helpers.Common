using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class TypeParameterLists
    {
        public static TypeParameterList Create(params TypeParameter[] parameters)
            => new TypeParameterList(GetListItems(parameters));

        public static TypeParameterList Create(params string[] parameters)
            => Create(parameters.Select(p => new TypeParameter(p)).ToArray());

        private static List<TypeParameterListAssociation> GetListItems(params TypeParameter[] parameters)
            => parameters.Select(parameter => new TypeParameterListAssociation(parameter)).ToList();
    }
}
