using static DevOps.Primitives.CSharp.Helpers.Common.Comments;
using static DevOps.Primitives.CSharp.Helpers.Common.TrailingSemicolonRemover;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class Fields
    {
        public static Field PrivateConst(
            in string name,
            in string type,
            in string summaryComment = default,
            in AttributeListCollection attributes = default,
            in Expression initializer = default)
            => new Field(
                in name,
                in type,
                in ModifierLists.PrivateConst,
                Summary(in summaryComment),
                in initializer,
                in attributes);

        public static Field PrivateConst(
            in string name,
            in string type,
            in string summaryComment = default,
            in AttributeListCollection attributes = default,
            in string initializer = default)
            => PrivateConst(
                in name,
                in type,
                in summaryComment,
                in attributes,
                GetInitializerExpression(in initializer));

        public static Field PrivateReadonly(
            in string name,
            in string type,
            in string summaryComment = default,
            in AttributeListCollection attributes = default,
            in Expression initializer = default)
            => new Field(
                in name,
                in type,
                in ModifierLists.PrivateReadonly,
                Summary(in summaryComment),
                in initializer,
                in attributes);

        public static Field PrivateReadonly(
            in string name,
            in string type,
            in string summaryComment = default,
            in AttributeListCollection attributes = default,
            in string initializer = default)
            => PrivateReadonly(
                in name,
                in type,
                in summaryComment,
                in attributes,
                GetInitializerExpression(in initializer));

        public static Field PrivateStaticReadonly(
            in string name,
            in string type,
            in string summaryComment = default,
            in AttributeListCollection attributes = default,
            in Expression initializer = default)
            => new Field(
                in name,
                in type,
                in ModifierLists.PrivateStaticReadonly,
                Summary(in summaryComment),
                in initializer,
                in attributes);

        public static Field PrivateStaticReadonly(
            in string name,
            in string type,
            in string summaryComment = default,
            in AttributeListCollection attributes = default,
            in string initializer = default)
            => PrivateStaticReadonly(
                in name,
                in type,
                in summaryComment,
                in attributes,
                GetInitializerExpression(in initializer));

        public static Field PublicConst(
            in string name,
            in string type,
            in string summaryComment = default,
            in AttributeListCollection attributes = default,
            in Expression initializer = default)
            => new Field(
                in name,
                in type,
                in ModifierLists.PublicConst,
                Summary(in summaryComment),
                in initializer,
                in attributes);

        public static Field PublicConst(
            in string name,
            in string type,
            in string summaryComment = default,
            in AttributeListCollection attributes = default,
            in string initializer = default)
            => PublicConst(
                in name,
                in type,
                in summaryComment,
                in attributes,
                GetInitializerExpression(in initializer));

        public static Field PublicReadonly(
            in string name,
            in string type,
            in string summaryComment = default,
            in AttributeListCollection attributes = default,
            in Expression initializer = default)
            => new Field(
                in name,
                in type,
                in ModifierLists.PublicReadonly,
                Summary(in summaryComment),
                in initializer,
                in attributes);

        public static Field PublicReadonly(
            in string name,
            in string type,
            in string summaryComment = default,
            in AttributeListCollection attributes = default,
            in string initializer = default)
            => PublicReadonly(
                in name,
                in type,
                in summaryComment,
                in attributes,
                GetInitializerExpression(in initializer));

        public static Field PublicStaticReadonly(
            in string name,
            in string type,
            in string summaryComment = default,
            in AttributeListCollection attributes = default,
            in Expression initializer = default)
            => new Field(
                in name,
                in type,
                in ModifierLists.PublicStaticReadonly,
                Summary(in summaryComment),
                in initializer,
                in attributes);

        public static Field PublicStaticReadonly(
            in string name,
            in string type,
            in string summaryComment = default,
            in AttributeListCollection attributes = default,
            in string initializer = default)
            => PublicStaticReadonly(
                in name,
                in type,
                in summaryComment,
                in attributes,
                GetInitializerExpression(in initializer));

        private static Expression GetInitializerExpression(in string initializer)
            => string.IsNullOrWhiteSpace(initializer) ? null
            : new Expression(RemoveTrailingSemicolon(in initializer));
    }
}
