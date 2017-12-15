using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class BaseLists
    {
        public static BaseList Create(params BaseType[] baseTypes)
            => new BaseList(GetListItems(baseTypes));

        private static List<BaseListAssociation> GetListItems(params BaseType[] baseTypes)
            => baseTypes.Select(baseType => new BaseListAssociation(baseType)).ToList();
    }
}
