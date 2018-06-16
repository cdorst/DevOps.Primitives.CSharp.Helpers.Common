using static DevOps.Primitives.CSharp.AccessorLists;
using static DevOps.Primitives.CSharp.Helpers.Common.Comments;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class Properties
    {
        public static Property Public(
            in string name,
            in string type,
            in string summaryComment = default,
            in AttributeListCollection attributes = default)
            => new Property(
                in name,
                in type,
                in AutoGetSet,
                in ModifierLists.Public,
                Summary(in summaryComment),
                in attributes);
    }
}
