using static DevOps.Primitives.CSharp.DocumentationComment;
using static System.String;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class Comments
    {
        public static DocumentationCommentList Summary(in string comment)
            => IsNullOrWhiteSpace(comment) ? null
            : new DocumentationCommentList(SummaryElement, in comment, includeNewLineAtListLevel: true);
    }
}
