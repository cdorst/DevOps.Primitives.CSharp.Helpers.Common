using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class BaseLists
    {
        public static BaseList Create(params BaseType[] baseTypes)
            => new BaseList(GetListItems(baseTypes));

        public static BaseList Create(params string[] baseTypes)
            => Create(baseTypes.Select(b => new BaseType(b)).ToArray());

        private static List<BaseListAssociation> GetListItems(params BaseType[] baseTypes)
            => baseTypes.Select(baseType => new BaseListAssociation(baseType)).ToList();
    }
}
