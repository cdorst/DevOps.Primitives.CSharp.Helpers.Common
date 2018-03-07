using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class Enums
    {
        public static EnumDeclaration Internal(string identifier, string @namespace, EnumMemberList enumMemberList, UsingDirectiveList usingDirectiveList = null, DocumentationCommentList documentationCommentList = null, AttributeListCollection attributeListCollection = null)
        {
            var records = enumMemberList.EnumMemberListAssociations.Count();
            return (records >= short.MaxValue) ? InternalInt(identifier, @namespace, enumMemberList, usingDirectiveList, documentationCommentList, attributeListCollection)
                : (records >= byte.MaxValue) ? InternalShort(identifier, @namespace, enumMemberList, usingDirectiveList, documentationCommentList, attributeListCollection)
                : InternalByte(identifier, @namespace, enumMemberList, usingDirectiveList, documentationCommentList, attributeListCollection);
        }

        public static EnumDeclaration InternalByte(string identifier, string @namespace, EnumMemberList enumMemberList, UsingDirectiveList usingDirectiveList = null, DocumentationCommentList documentationCommentList = null, AttributeListCollection attributeListCollection = null)
            => InternalInt(identifier, @namespace, enumMemberList, usingDirectiveList, documentationCommentList, attributeListCollection, BaseLists.Byte);

        public static EnumDeclaration InternalInt(string identifier, string @namespace, EnumMemberList enumMemberList, UsingDirectiveList usingDirectiveList = null, DocumentationCommentList documentationCommentList = null, AttributeListCollection attributeListCollection = null, BaseList baseList = null)
            => new EnumDeclaration(identifier, @namespace, ModifierLists.Internal, usingDirectiveList, documentationCommentList, attributeListCollection, null, null, baseList, null, null, null, null, enumMemberList);

        public static EnumDeclaration InternalShort(string identifier, string @namespace, EnumMemberList enumMemberList, UsingDirectiveList usingDirectiveList = null, DocumentationCommentList documentationCommentList = null, AttributeListCollection attributeListCollection = null)
            => InternalInt(identifier, @namespace, enumMemberList, usingDirectiveList, documentationCommentList, attributeListCollection, BaseLists.Short);

        public static EnumDeclaration Private(string identifier, string @namespace, EnumMemberList enumMemberList, UsingDirectiveList usingDirectiveList = null, DocumentationCommentList documentationCommentList = null, AttributeListCollection attributeListCollection = null)
        {
            var records = enumMemberList.EnumMemberListAssociations.Count();
            return (records >= short.MaxValue) ? PrivateInt(identifier, @namespace, enumMemberList, usingDirectiveList, documentationCommentList, attributeListCollection)
                : (records >= byte.MaxValue) ? PrivateShort(identifier, @namespace, enumMemberList, usingDirectiveList, documentationCommentList, attributeListCollection)
                : PrivateByte(identifier, @namespace, enumMemberList, usingDirectiveList, documentationCommentList, attributeListCollection);
        }

        public static EnumDeclaration PrivateByte(string identifier, string @namespace, EnumMemberList enumMemberList, UsingDirectiveList usingDirectiveList = null, DocumentationCommentList documentationCommentList = null, AttributeListCollection attributeListCollection = null)
            => PrivateInt(identifier, @namespace, enumMemberList, usingDirectiveList, documentationCommentList, attributeListCollection, BaseLists.Byte);

        public static EnumDeclaration PrivateInt(string identifier, string @namespace, EnumMemberList enumMemberList, UsingDirectiveList usingDirectiveList = null, DocumentationCommentList documentationCommentList = null, AttributeListCollection attributeListCollection = null, BaseList baseList = null)
            => new EnumDeclaration(identifier, @namespace, ModifierLists.Private, usingDirectiveList, documentationCommentList, attributeListCollection, null, null, baseList, null, null, null, null, enumMemberList);

        public static EnumDeclaration PrivateShort(string identifier, string @namespace, EnumMemberList enumMemberList, UsingDirectiveList usingDirectiveList = null, DocumentationCommentList documentationCommentList = null, AttributeListCollection attributeListCollection = null)
            => PrivateInt(identifier, @namespace, enumMemberList, usingDirectiveList, documentationCommentList, attributeListCollection, BaseLists.Short);

        public static EnumDeclaration Public(string identifier, string @namespace, EnumMemberList enumMemberList, UsingDirectiveList usingDirectiveList = null, DocumentationCommentList documentationCommentList = null, AttributeListCollection attributeListCollection = null)
        {
            var records = enumMemberList.EnumMemberListAssociations.Count();
            return (records >= short.MaxValue) ? PublicInt(identifier, @namespace, enumMemberList, usingDirectiveList, documentationCommentList, attributeListCollection)
                : (records >= byte.MaxValue) ? PublicShort(identifier, @namespace, enumMemberList, usingDirectiveList, documentationCommentList, attributeListCollection)
                : PublicByte(identifier, @namespace, enumMemberList, usingDirectiveList, documentationCommentList, attributeListCollection);
        }

        public static EnumDeclaration PublicInt(string identifier, string @namespace, EnumMemberList enumMemberList, UsingDirectiveList usingDirectiveList = null, DocumentationCommentList documentationCommentList = null, AttributeListCollection attributeListCollection = null, BaseList baseList = null)
            => new EnumDeclaration(identifier, @namespace, ModifierLists.Public, usingDirectiveList, documentationCommentList, attributeListCollection, null, null, baseList, null, null, null, null, enumMemberList);

        public static EnumDeclaration PublicByte(string identifier, string @namespace, EnumMemberList enumMemberList, UsingDirectiveList usingDirectiveList = null, DocumentationCommentList documentationCommentList = null, AttributeListCollection attributeListCollection = null)
            => PublicInt(identifier, @namespace, enumMemberList, usingDirectiveList, documentationCommentList, attributeListCollection, BaseLists.Byte);

        public static EnumDeclaration PublicShort(string identifier, string @namespace, EnumMemberList enumMemberList, UsingDirectiveList usingDirectiveList = null, DocumentationCommentList documentationCommentList = null, AttributeListCollection attributeListCollection = null)
            => PublicInt(identifier, @namespace, enumMemberList, usingDirectiveList, documentationCommentList, attributeListCollection, BaseLists.Short);

    }
}
