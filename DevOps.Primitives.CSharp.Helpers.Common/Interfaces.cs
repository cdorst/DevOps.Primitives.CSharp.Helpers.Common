namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class Interfaces
    {
        public static InterfaceDeclaration Internal(string identifier, string @namespace, UsingDirectiveList usingDirectiveList = null, DocumentationCommentList documentationCommentList = null, AttributeListCollection attributeListCollection = null, TypeParameterList typeParameterList = null, ConstraintClauseList constraintClauseList = null, BaseList baseList = null, MethodList methodList = null, PropertyList propertyList = null)
            => new InterfaceDeclaration(identifier, @namespace, ModifierLists.Internal, usingDirectiveList, documentationCommentList, attributeListCollection, typeParameterList, constraintClauseList, baseList, methodList, propertyList);

        public static InterfaceDeclaration Private(string identifier, string @namespace, UsingDirectiveList usingDirectiveList = null, DocumentationCommentList documentationCommentList = null, AttributeListCollection attributeListCollection = null, TypeParameterList typeParameterList = null, ConstraintClauseList constraintClauseList = null, BaseList baseList = null, MethodList methodList = null, PropertyList propertyList = null)
            => new InterfaceDeclaration(identifier, @namespace, ModifierLists.Private, usingDirectiveList, documentationCommentList, attributeListCollection, typeParameterList, constraintClauseList, baseList, methodList, propertyList);

        public static InterfaceDeclaration Public(string identifier, string @namespace, UsingDirectiveList usingDirectiveList = null, DocumentationCommentList documentationCommentList = null, AttributeListCollection attributeListCollection = null, TypeParameterList typeParameterList = null, ConstraintClauseList constraintClauseList = null, BaseList baseList = null, MethodList methodList = null, PropertyList propertyList = null)
            => new InterfaceDeclaration(identifier, @namespace, ModifierLists.Public, usingDirectiveList, documentationCommentList, attributeListCollection, typeParameterList, constraintClauseList, baseList, methodList, propertyList);
    }
}
