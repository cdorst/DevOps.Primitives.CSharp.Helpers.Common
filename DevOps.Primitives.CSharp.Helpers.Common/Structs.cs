namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class Structs
    {
        public static StructDeclaration Internal(string identifier, string @namespace, UsingDirectiveList usingDirectiveList = null, DocumentationCommentList documentationCommentList = null, AttributeListCollection attributeListCollection = null, TypeParameterList typeParameterList = null, ConstraintClauseList constraintClauseList = null, BaseList baseList = null, ConstructorList constructorList = null, FieldList fieldList = null, MethodList methodList = null, PropertyList propertyList = null)
            => new StructDeclaration(identifier, @namespace, ModifierLists.Internal, usingDirectiveList, documentationCommentList, attributeListCollection, typeParameterList, constraintClauseList, baseList, constructorList, fieldList, methodList, propertyList);

        public static StructDeclaration Private(string identifier, string @namespace, UsingDirectiveList usingDirectiveList = null, DocumentationCommentList documentationCommentList = null, AttributeListCollection attributeListCollection = null, TypeParameterList typeParameterList = null, ConstraintClauseList constraintClauseList = null, BaseList baseList = null, ConstructorList constructorList = null, FieldList fieldList = null, MethodList methodList = null, PropertyList propertyList = null)
            => new StructDeclaration(identifier, @namespace, ModifierLists.Private, usingDirectiveList, documentationCommentList, attributeListCollection, typeParameterList, constraintClauseList, baseList, constructorList, fieldList, methodList, propertyList);

        public static StructDeclaration Public(string identifier, string @namespace, UsingDirectiveList usingDirectiveList = null, DocumentationCommentList documentationCommentList = null, AttributeListCollection attributeListCollection = null, TypeParameterList typeParameterList = null, ConstraintClauseList constraintClauseList = null, BaseList baseList = null, ConstructorList constructorList = null, FieldList fieldList = null, MethodList methodList = null, PropertyList propertyList = null)
            => new StructDeclaration(identifier, @namespace, ModifierLists.Public, usingDirectiveList, documentationCommentList, attributeListCollection, typeParameterList, constraintClauseList, baseList, constructorList, fieldList, methodList, propertyList);
    }
}
