namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class Fields
    {
        public static Field PrivateConst(string name, string type, string summaryComment = null, AttributeListCollection attributes = null)
            => new Field(
                name,
                type,
                ModifierLists.PrivateConst,
                Comments.Summary(summaryComment),
                attributeListCollection: attributes);

        public static Field PrivateReadonly(string name, string type, string summaryComment = null, AttributeListCollection attributes = null)
            => new Field(
                name,
                type,
                ModifierLists.PrivateReadonly,
                Comments.Summary(summaryComment),
                attributeListCollection: attributes);

        public static Field PublicConst(string name, string type, string summaryComment = null, AttributeListCollection attributes = null)
            => new Field(
                name,
                type,
                ModifierLists.PublicConst,
                Comments.Summary(summaryComment),
                attributeListCollection: attributes);
    }
}
