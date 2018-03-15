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
                string.IsNullOrWhiteSpace(initializer) ? null : new Expression(initializer));

        public static Field PrivateReadonly(string name, string type, string summaryComment = null, AttributeListCollection attributes = null)
            => new Field(
                name,
                type,
                ModifierLists.PrivateReadonly,
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
                string.IsNullOrWhiteSpace(initializer) ? null : new Expression(initializer));
    }
}
