using System.Collections.Generic;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public class MethodEqualityComparer : EqualityComparer<Method>
    {
        public static MethodEqualityComparer Instance
            => new MethodEqualityComparer();

        public override bool Equals(Method x, Method y)
            => x.Identifier.Name.Value.Equals(y.Identifier.Name.Value)
            && ((x.ParameterList == null && y.ParameterList == null)
            || ((x.ParameterList != null && y.ParameterList != null)
            && (x.ParameterList.GetTypesAndNames() == y.ParameterList.GetTypesAndNames())));

        public override int GetHashCode(Method obj)
            => unchecked(obj.Identifier.Name.Value.GetHashCode()
                + obj.ParameterList?.GetTypesAndNames().GetHashCode() ?? 0);
    }
}
