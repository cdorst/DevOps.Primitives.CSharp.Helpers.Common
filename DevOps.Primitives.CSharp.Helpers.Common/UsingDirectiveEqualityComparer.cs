using System.Collections.Generic;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public class UsingDirectiveEqualityComparer : EqualityComparer<UsingDirective>
    {
        public static UsingDirectiveEqualityComparer Instance
            => new UsingDirectiveEqualityComparer();

        public override bool Equals(UsingDirective x, UsingDirective y)
            => x.Identifier.Name.Value.Equals(y.Identifier.Name.Value);

        public override int GetHashCode(UsingDirective obj)
            => obj.Identifier.Name.Value.GetHashCode();
    }
}
