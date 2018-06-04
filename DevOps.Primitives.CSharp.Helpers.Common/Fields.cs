namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class Fields
    {
        public static Field PrivateConst(string name, string type, string summaryComment = default, AttributeListCollection attributes = default, Expression initializer = default)
            => new Field(
                name,
                type,
                ModifierLists.PrivateConst,
                Comments.Summary(summaryComment),
                initializer,
                attributes);

        public static Field PrivateConst(string name, string type, string summaryComment = default, AttributeListCollection attributes = default, string initializer = default)
            => PrivateConst(
                name,
                type,
                summaryComment,
                attributes,
                GetInitializerExpression(initializer));

        public static Field PrivateReadonly(string name, string type, string summaryComment = default, AttributeListCollection attributes = default, Expression initializer = default)
            => new Field(
                name,
                type,
                ModifierLists.PrivateReadonly,
                Comments.Summary(summaryComment),
                initializer,
                attributes);

        public static Field PrivateReadonly(string name, string type, string summaryComment = default, AttributeListCollection attributes = default, string initializer = default)
            => PrivateReadonly(
                name,
                type,
                summaryComment,
                attributes,
                GetInitializerExpression(initializer));

        public static Field PrivateStaticReadonly(string name, string type, string summaryComment = default, AttributeListCollection attributes = default, Expression initializer = default)
            => new Field(
                name,
                type,
                ModifierLists.PrivateStaticReadonly,
                Comments.Summary(summaryComment),
                initializer,
                attributes);

        public static Field PrivateStaticReadonly(string name, string type, string summaryComment = default, AttributeListCollection attributes = default, string initializer = default)
            => PrivateStaticReadonly(
                name,
                type,
                summaryComment,
                attributes,
                GetInitializerExpression(initializer));

        public static Field PublicConst(string name, string type, string summaryComment = default, AttributeListCollection attributes = default, Expression initializer = default)
            => new Field(
                name,
                type,
                ModifierLists.PublicConst,
                Comments.Summary(summaryComment),
                initializer,
                attributes);

        public static Field PublicConst(string name, string type, string summaryComment = default, AttributeListCollection attributes = default, string initializer = default)
            => PublicConst(
                name,
                type,
                summaryComment,
                attributes,
                GetInitializerExpression(initializer));

        public static Field PublicReadonly(string name, string type, string summaryComment = default, AttributeListCollection attributes = default, Expression initializer = default)
            => new Field(
                name,
                type,
                ModifierLists.PublicReadonly,
                Comments.Summary(summaryComment),
                initializer,
                attributes);

        public static Field PublicReadonly(string name, string type, string summaryComment = default, AttributeListCollection attributes = default, string initializer = default)
            => PublicReadonly(
                name,
                type,
                summaryComment,
                attributes,
                GetInitializerExpression(initializer));

        public static Field PublicStaticReadonly(string name, string type, string summaryComment = default, AttributeListCollection attributes = default, Expression initializer = default)
            => new Field(
                name,
                type,
                ModifierLists.PublicStaticReadonly,
                Comments.Summary(summaryComment),
                initializer,
                attributes);

        public static Field PublicStaticReadonly(string name, string type, string summaryComment = default, AttributeListCollection attributes = default, string initializer = default)
            => PublicStaticReadonly(
                name,
                type,
                summaryComment,
                attributes,
                GetInitializerExpression(initializer));

        private static Expression GetInitializerExpression(string initializer)
            => string.IsNullOrWhiteSpace(initializer) ? null
            : new Expression(initializer.RemoveTrailingSemicolon());
    }
}
