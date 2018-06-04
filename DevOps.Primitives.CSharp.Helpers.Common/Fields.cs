namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class Fields
    {
        public static Field PrivateConst(string name, string type, string summaryComment = null, AttributeListCollection attributes = null, Expression initializer = null)
            => new Field(
                name,
                type,
                ModifierLists.PrivateConst,
                Comments.Summary(summaryComment),
                initializer,
                attributes);

        public static Field PrivateConst(string name, string type, string summaryComment = null, AttributeListCollection attributes = null, string initializer = null)
            => PrivateConst(
                name,
                type,
                summaryComment,
                attributes,
                GetInitializerExpression(initializer));

        public static Field PrivateReadonly(string name, string type, string summaryComment = null, AttributeListCollection attributes = null)
            => new Field(
                name,
                type,
                ModifierLists.PrivateReadonly,
                Comments.Summary(summaryComment),
                attributeListCollection: attributes);

        public static Field PrivateStaticReadonly(string name, string type, string summaryComment = null, AttributeListCollection attributes = null)
            => new Field(
                name,
                type,
                ModifierLists.PrivateStaticReadonly,
                Comments.Summary(summaryComment),
                attributeListCollection: attributes);

        public static Field PublicConst(string name, string type, string summaryComment = null, AttributeListCollection attributes = null, Expression initializer = null)
            => new Field(
                name,
                type,
                ModifierLists.PublicConst,
                Comments.Summary(summaryComment),
                initializer,
                attributes);

        public static Field PublicConst(string name, string type, string summaryComment = null, AttributeListCollection attributes = null, string initializer = null)
            => PublicConst(
                name,
                type,
                summaryComment,
                attributes,
                GetInitializerExpression(initializer));

        public static Field PublicReadonly(string name, string type, string summaryComment = null, AttributeListCollection attributes = null)
            => new Field(
                name,
                type,
                ModifierLists.PublicReadonly,
                Comments.Summary(summaryComment),
                attributeListCollection: attributes);

        public static Field PublicStaticReadonly(string name, string type, string summaryComment = null, AttributeListCollection attributes = null)
            => new Field(
                name,
                type,
                ModifierLists.PublicStaticReadonly,
                Comments.Summary(summaryComment),
                attributeListCollection: attributes);

        private static Expression GetInitializerExpression(string initializer)
            => string.IsNullOrWhiteSpace(initializer) ? null
            : new Expression(initializer.RemoveTrailingSemicolon());
    }
}
