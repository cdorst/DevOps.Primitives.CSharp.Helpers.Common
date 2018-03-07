using System.Collections.Generic;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public class BaseTypeEqualityComparer : EqualityComparer<BaseType>
    {
        public static BaseTypeEqualityComparer Instance
            => new BaseTypeEqualityComparer();

        public override bool Equals(BaseType x, BaseType y)
            => x.Identifier.Name.Value.Equals(y.Identifier.Name.Value)
            && ((x.TypeArgumentList == null && y.TypeArgumentList == null)
            || ((x.TypeArgumentList != null && y.TypeArgumentList != null)
            && (x.TypeArgumentList.GetNames() == y.TypeArgumentList.GetNames())));

        public override int GetHashCode(BaseType obj)
            => obj.Identifier.Name.Value.GetHashCode();
    }
}
