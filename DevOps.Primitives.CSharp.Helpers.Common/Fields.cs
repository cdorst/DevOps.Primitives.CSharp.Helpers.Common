namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class Fields
    {
        public static Field PrivateReadonly(string name, string type, string summaryComment = null, AttributeListCollection attributes = null)
            => new Field(
                name,
                type,
                ModifierLists.PrivateReadonly,
                Comments.Summary(summaryComment),
                attributeListCollection: attributes);
    }
}
