namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class Methods
    {
        public static Method Declaration(string identifier, string type, ParameterList parameterList = null, DocumentationCommentList documentationCommentList = null, AttributeListCollection attributes = null)
            => new Method(identifier, type, parameterList, null, null, documentationCommentList, attributes);

        public static Method Public(string identifier, string type, string arrowClauseExpression, ParameterList parameterList = null, DocumentationCommentList documentationCommentList = null, AttributeListCollection attributes = null)
            => new Method(identifier, type, arrowClauseExpression, parameterList, ModifierLists.Public, documentationCommentList, attributes);

        public static Method PublicStatic(string identifier, string type, string arrowClauseExpression, ParameterList parameterList = null, DocumentationCommentList documentationCommentList = null, AttributeListCollection attributes = null)
            => new Method(identifier, type, arrowClauseExpression, parameterList, ModifierLists.PublicStatic, documentationCommentList, attributes);
    }
}
