namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class Comments
    {
        public static DocumentationCommentList Summary(string comment)
            => string.IsNullOrWhiteSpace(comment) ? null
            : new DocumentationCommentList(DocumentationComment.SummaryElement, comment);
    }
}
