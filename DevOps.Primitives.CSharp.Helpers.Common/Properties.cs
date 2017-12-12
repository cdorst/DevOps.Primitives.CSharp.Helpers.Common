namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class Properties
    {
        public static Property Public(string name, string type, string summaryComment = null, AttributeListCollection attributes = null)
            => new Property(
                name,
                type,
                AccessorLists.AutoGetSet,
                ModifierLists.Public,
                Comments.Summary(summaryComment),
                attributes);
    }
}
