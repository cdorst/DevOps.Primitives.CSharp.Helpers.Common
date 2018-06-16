using static DevOps.Primitives.CSharp.Helpers.Common.Blocks;
using static DevOps.Primitives.CSharp.ModifierLists;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class Constructors
    {
        public static Constructor Default(in string name)
            => new Constructor(in name, in Empty, in Public);
    }
}
