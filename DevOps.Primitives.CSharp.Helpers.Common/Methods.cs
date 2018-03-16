namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class Methods
    {
        public static Method Declaration(string identifier, string type, ParameterList parameterList = null, DocumentationCommentList documentationCommentList = null, AttributeListCollection attributes = null)
            => new Method(identifier, type, parameterList, null, null, documentationCommentList, attributes);

        public static Method Public(string identifier, string type, string arrowClauseExpression, ParameterList parameterList = null, DocumentationCommentList documentationCommentList = null, AttributeListCollection attributes = null)
            => new Method(identifier, type, arrowClauseExpression?.RemoveTrailingSemicolon(), parameterList, ModifierLists.Public, documentationCommentList, attributes);

        public static Method Public(string identifier, string type, Block body, ParameterList parameterList = null, DocumentationCommentList documentationCommentList = null, AttributeListCollection attributes = null)
            => new Method(identifier, type, parameterList, body, ModifierLists.Public, documentationCommentList, attributes);

        public static Method PublicAsync(string identifier, string type, string arrowClauseExpression, ParameterList parameterList = null, DocumentationCommentList documentationCommentList = null, AttributeListCollection attributes = null)
            => new Method(identifier, type, arrowClauseExpression?.RemoveTrailingSemicolon(), parameterList, ModifierLists.PublicAsync, documentationCommentList, attributes);

        public static Method PublicAsync(string identifier, string type, Block body, ParameterList parameterList = null, DocumentationCommentList documentationCommentList = null, AttributeListCollection attributes = null)
            => new Method(identifier, type, parameterList, body, ModifierLists.PublicAsync, documentationCommentList, attributes);

        public static Method PublicStatic(string identifier, string type, string arrowClauseExpression, ParameterList parameterList = null, DocumentationCommentList documentationCommentList = null, AttributeListCollection attributes = null)
            => new Method(identifier, type, arrowClauseExpression?.RemoveTrailingSemicolon(), parameterList, ModifierLists.PublicStatic, documentationCommentList, attributes);

        public static Method PublicStatic(string identifier, string type, Block body, ParameterList parameterList = null, DocumentationCommentList documentationCommentList = null, AttributeListCollection attributes = null)
            => new Method(identifier, type, parameterList, body, ModifierLists.PublicStatic, documentationCommentList, attributes);

        public static Method PublicStaticAsync(string identifier, string type, string arrowClauseExpression, ParameterList parameterList = null, DocumentationCommentList documentationCommentList = null, AttributeListCollection attributes = null)
            => new Method(identifier, type, arrowClauseExpression?.RemoveTrailingSemicolon(), parameterList, ModifierLists.PublicStaticAsync, documentationCommentList, attributes);

        public static Method PublicStaticAsync(string identifier, string type, Block body, ParameterList parameterList = null, DocumentationCommentList documentationCommentList = null, AttributeListCollection attributes = null)
            => new Method(identifier, type, parameterList, body, ModifierLists.PublicStaticAsync, documentationCommentList, attributes);
    }
}
