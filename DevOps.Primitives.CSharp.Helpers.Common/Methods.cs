using static DevOps.Primitives.CSharp.Helpers.Common.TrailingSemicolonRemover;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class Methods
    {
        public static Method Declaration(
            in string identifier,
            in string type,
            in ParameterList parameterList = default,
            in DocumentationCommentList documentationCommentList = default,
            in AttributeListCollection attributes = default)
            => new Method(
                in identifier,
                in type,
                in parameterList,
                null,
                null,
                in documentationCommentList,
                in attributes);

        public static Method Public(
            in string identifier,
            in string type,
            in string arrowClauseExpression,
            in ParameterList parameterList = default,
            in DocumentationCommentList documentationCommentList = default,
            in AttributeListCollection attributes = default)
            => new Method(
                in identifier,
                in type,
                RemoveTrailingSemicolon(in arrowClauseExpression),
                in parameterList,
                in ModifierLists.Public,
                in documentationCommentList,
                in attributes);

        public static Method Public(
            in string identifier,
            in string type,
            in Block body,
            in ParameterList parameterList = default,
            in DocumentationCommentList documentationCommentList = default,
            in AttributeListCollection attributes = default)
            => new Method(
                in identifier,
                in type,
                in parameterList,
                in body,
                in ModifierLists.Public,
                in documentationCommentList,
                in attributes);

        public static Method PublicAsync(
            in string identifier,
            in string type,
            in string arrowClauseExpression,
            in ParameterList parameterList = default,
            in DocumentationCommentList documentationCommentList = default,
            in AttributeListCollection attributes = default)
            => new Method(
                in identifier,
                in type,
                RemoveTrailingSemicolon(in arrowClauseExpression),
                in parameterList,
                in ModifierLists.PublicAsync,
                in documentationCommentList,
                in attributes);

        public static Method PublicAsync(
            in string identifier,
            in string type,
            in Block body,
            in ParameterList parameterList = default,
            in DocumentationCommentList documentationCommentList = default,
            in AttributeListCollection attributes = default)
            => new Method(
                in identifier,
                in type,
                in parameterList,
                in body,
                in ModifierLists.PublicAsync,
                in documentationCommentList,
                in attributes);

        public static Method PublicStatic(
            in string identifier,
            in string type,
            in string arrowClauseExpression,
            in ParameterList parameterList = default,
            in DocumentationCommentList documentationCommentList = default,
            in AttributeListCollection attributes = default)
            => new Method(
                in identifier,
                in type,
                RemoveTrailingSemicolon(in arrowClauseExpression),
                in parameterList,
                in ModifierLists.PublicStatic,
                in documentationCommentList,
                in attributes);

        public static Method PublicStatic(
            in string identifier,
            in string type,
            in Block body,
            in ParameterList parameterList = default,
            in DocumentationCommentList documentationCommentList = default,
            in AttributeListCollection attributes = default)
            => new Method(
                in identifier,
                in type,
                in parameterList,
                in body,
                in ModifierLists.PublicStatic,
                in documentationCommentList,
                in attributes);

        public static Method PublicStaticAsync(
            in string identifier,
            in string type,
            in string arrowClauseExpression,
            in ParameterList parameterList = default,
            in DocumentationCommentList documentationCommentList = default,
            in AttributeListCollection attributes = default)
            => new Method(
                in identifier,
                in type,
                RemoveTrailingSemicolon(in arrowClauseExpression),
                in parameterList,
                in ModifierLists.PublicStaticAsync,
                in documentationCommentList,
                in attributes);

        public static Method PublicStaticAsync(
            in string identifier,
            in string type,
            in Block body,
            in ParameterList parameterList = default,
            in DocumentationCommentList documentationCommentList = default,
            in AttributeListCollection attributes = default)
            => new Method(
                in identifier,
                in type,
                in parameterList,
                in body,
                in ModifierLists.PublicStaticAsync,
                in documentationCommentList,
                in attributes);
    }
}
