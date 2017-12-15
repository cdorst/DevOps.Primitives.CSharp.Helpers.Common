using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class ParameterLists
    {
        public static ParameterList Create(params Parameter[] parameters)
            => new ParameterList(GetListItems(parameters));

        public static ParameterList Single(string name, string type)
            => new ParameterList(name, type);

        private static List<ParameterListAssociation> GetListItems(params Parameter[] parameters)
            => parameters.Select(parameter => new ParameterListAssociation(parameter)).ToList();
    }
}
