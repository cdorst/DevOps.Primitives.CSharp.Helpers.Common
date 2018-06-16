namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class Structs
    {
        public static StructDeclaration Internal(
            in string identifier,
            in string @namespace,
            in UsingDirectiveList usingDirectiveList = default,
            in DocumentationCommentList documentationCommentList = default,
            in AttributeListCollection attributeListCollection = default,
            in TypeParameterList typeParameterList = default,
            in ConstraintClauseList constraintClauseList = default,
            in BaseList baseList = default,
            in ConstructorList constructorList = default,
            in FieldList fieldList = default,
            in MethodList methodList = default,
            in PropertyList propertyList = default)
            => new StructDeclaration(
                in identifier,
                in @namespace,
                in ModifierLists.Internal,
                in usingDirectiveList,
                in documentationCommentList,
                in attributeListCollection,
                in typeParameterList,
                in constraintClauseList,
                in baseList,
                in constructorList,
                in fieldList,
                in methodList,
                in propertyList);

        public static StructDeclaration Private(
            in string identifier,
            in string @namespace,
            in UsingDirectiveList usingDirectiveList = default,
            in DocumentationCommentList documentationCommentList = default,
            in AttributeListCollection attributeListCollection = default,
            in TypeParameterList typeParameterList = default,
            in ConstraintClauseList constraintClauseList = default,
            in BaseList baseList = default,
            in ConstructorList constructorList = default,
            in FieldList fieldList = default,
            in MethodList methodList = default,
            in PropertyList propertyList = default)
            => new StructDeclaration(
                in identifier,
                in @namespace,
                in ModifierLists.Private,
                in usingDirectiveList,
                in documentationCommentList,
                in attributeListCollection,
                in typeParameterList,
                in constraintClauseList,
                in baseList,
                in constructorList,
                in fieldList,
                in methodList,
                in propertyList);

        public static StructDeclaration Public(
            in string identifier,
            in string @namespace,
            in UsingDirectiveList usingDirectiveList = default,
            in DocumentationCommentList documentationCommentList = default,
            in AttributeListCollection attributeListCollection = default,
            in TypeParameterList typeParameterList = default,
            in ConstraintClauseList constraintClauseList = default,
            in BaseList baseList = default,
            in ConstructorList constructorList = default,
            in FieldList fieldList = default,
            in MethodList methodList = default,
            in PropertyList propertyList = default)
            => new StructDeclaration(
                in identifier,
                in @namespace,
                in ModifierLists.Public,
                in usingDirectiveList,
                in documentationCommentList,
                in attributeListCollection,
                in typeParameterList,
                in constraintClauseList,
                in baseList,
                in constructorList,
                in fieldList,
                in methodList,
                in propertyList);
    }
}
