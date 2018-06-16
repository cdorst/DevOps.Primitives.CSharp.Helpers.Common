namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class Interfaces
    {
        public static InterfaceDeclaration Internal(
            in string identifier,
            in string @namespace,
            in UsingDirectiveList usingDirectiveList = default,
            in DocumentationCommentList documentationCommentList = default,
            in AttributeListCollection attributeListCollection = default,
            in TypeParameterList typeParameterList = default,
            in ConstraintClauseList constraintClauseList = default,
            in BaseList baseList = default,
            in MethodList methodList = default,
            in PropertyList propertyList = default)
            => new InterfaceDeclaration(
                in identifier,
                in @namespace,
                in ModifierLists.Internal,
                in usingDirectiveList,
                in documentationCommentList,
                in attributeListCollection,
                in typeParameterList,
                in constraintClauseList,
                in baseList,
                in methodList,
                in propertyList);

        public static InterfaceDeclaration Private(
            in string identifier,
            in string @namespace,
            in UsingDirectiveList usingDirectiveList = default,
            in DocumentationCommentList documentationCommentList = default,
            in AttributeListCollection attributeListCollection = default,
            in TypeParameterList typeParameterList = default,
            in ConstraintClauseList constraintClauseList = default,
            in BaseList baseList = default,
            in MethodList methodList = default,
            in PropertyList propertyList = default)
            => new InterfaceDeclaration(
                in identifier,
                in @namespace,
                in ModifierLists.Private,
                in usingDirectiveList,
                in documentationCommentList,
                in attributeListCollection,
                in typeParameterList,
                in constraintClauseList,
                in baseList,
                in methodList,
                in propertyList);

        public static InterfaceDeclaration Public(
            in string identifier,
            in string @namespace,
            in UsingDirectiveList usingDirectiveList = default,
            in DocumentationCommentList documentationCommentList = default,
            in AttributeListCollection attributeListCollection = default,
            in TypeParameterList typeParameterList = default,
            in ConstraintClauseList constraintClauseList = default,
            in BaseList baseList = default,
            in MethodList methodList = default,
            in PropertyList propertyList = default)
            => new InterfaceDeclaration(
                in identifier,
                in @namespace,
                in ModifierLists.Public,
                in usingDirectiveList,
                in documentationCommentList,
                in attributeListCollection,
                in typeParameterList,
                in constraintClauseList,
                in baseList,
                in methodList,
                in propertyList);
    }
}
