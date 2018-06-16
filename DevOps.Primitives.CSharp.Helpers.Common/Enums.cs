using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class Enums
    {
        public static EnumDeclaration Internal(
            in string identifier,
            in string @namespace,
            in EnumMemberList enumMemberList,
            in UsingDirectiveList usingDirectiveList = default,
            in DocumentationCommentList documentationCommentList = default,
            in AttributeListCollection attributeListCollection = default)
        {
            var records = enumMemberList.EnumMemberListAssociations.Count();
            return (records >= short.MaxValue) ? InternalInt(in identifier, in @namespace, in enumMemberList, in usingDirectiveList, in documentationCommentList, in attributeListCollection)
                : (records >= byte.MaxValue) ? InternalShort(in identifier, in @namespace, in enumMemberList, in usingDirectiveList, in documentationCommentList, in attributeListCollection)
                : InternalByte(in identifier, in @namespace, in enumMemberList, in usingDirectiveList, in documentationCommentList, in attributeListCollection);
        }

        public static EnumDeclaration InternalByte(
            in string identifier,
            in string @namespace,
            in EnumMemberList enumMemberList,
            in UsingDirectiveList usingDirectiveList = default,
            in DocumentationCommentList documentationCommentList = default,
            in AttributeListCollection attributeListCollection = default)
            => InternalInt(
                in identifier,
                in @namespace,
                in enumMemberList,
                in usingDirectiveList,
                in documentationCommentList,
                in attributeListCollection,
                BaseLists.Byte);

        public static EnumDeclaration InternalInt(
            in string identifier,
            in string @namespace,
            in EnumMemberList enumMemberList,
            in UsingDirectiveList usingDirectiveList = default,
            in DocumentationCommentList documentationCommentList = default,
            in AttributeListCollection attributeListCollection = default,
            in BaseList baseList = default)
            => new EnumDeclaration(
                in identifier,
                in @namespace,
                in ModifierLists.Internal,
                in usingDirectiveList,
                in documentationCommentList,
                in attributeListCollection,
                baseList: in baseList,
                enumMemberList: in enumMemberList);

        public static EnumDeclaration InternalShort(
            in string identifier,
            in string @namespace,
            in EnumMemberList enumMemberList,
            in UsingDirectiveList usingDirectiveList = default,
            in DocumentationCommentList documentationCommentList = default,
            in AttributeListCollection attributeListCollection = default)
            => InternalInt(
                in identifier,
                in @namespace,
                in enumMemberList,
                in usingDirectiveList,
                in documentationCommentList,
                in attributeListCollection,
                BaseLists.Short);

        public static EnumDeclaration Private(
            in string identifier,
            in string @namespace,
            in EnumMemberList enumMemberList,
            in UsingDirectiveList usingDirectiveList = default,
            in DocumentationCommentList documentationCommentList = default,
            in AttributeListCollection attributeListCollection = default)
        {
            var records = enumMemberList.EnumMemberListAssociations.Count();
            return (records >= short.MaxValue) ? PrivateInt(in identifier, in @namespace, in enumMemberList, in usingDirectiveList, in documentationCommentList, in attributeListCollection)
                : (records >= byte.MaxValue) ? PrivateShort(in identifier, in @namespace, in enumMemberList, in usingDirectiveList, in documentationCommentList, in attributeListCollection)
                : PrivateByte(in identifier, in @namespace, in enumMemberList, in usingDirectiveList, in documentationCommentList, in attributeListCollection);
        }

        public static EnumDeclaration PrivateByte(
            in string identifier,
            in string @namespace,
            in EnumMemberList enumMemberList,
            in UsingDirectiveList usingDirectiveList = default,
            in DocumentationCommentList documentationCommentList = default,
            in AttributeListCollection attributeListCollection = default)
            => PrivateInt(
                in identifier,
                in @namespace,
                in enumMemberList,
                in usingDirectiveList,
                in documentationCommentList,
                in attributeListCollection,
                BaseLists.Byte);

        public static EnumDeclaration PrivateInt(
            in string identifier,
            in string @namespace,
            in EnumMemberList enumMemberList,
            in UsingDirectiveList usingDirectiveList = default,
            in DocumentationCommentList documentationCommentList = default,
            in AttributeListCollection attributeListCollection = default,
            in BaseList baseList = default)
            => new EnumDeclaration(
                in identifier,
                in @namespace,
                in ModifierLists.Private,
                in usingDirectiveList,
                in documentationCommentList,
                in attributeListCollection,
                baseList: in baseList,
                enumMemberList: in enumMemberList);

        public static EnumDeclaration PrivateShort(
            in string identifier,
            in string @namespace,
            in EnumMemberList enumMemberList,
            in UsingDirectiveList usingDirectiveList = default,
            in DocumentationCommentList documentationCommentList = default,
            in AttributeListCollection attributeListCollection = default)
            => PrivateInt(
                in identifier,
                in @namespace,
                in enumMemberList,
                in usingDirectiveList,
                in documentationCommentList,
                in attributeListCollection,
                BaseLists.Short);

        public static EnumDeclaration Public(
            in string identifier,
            in string @namespace,
            in EnumMemberList enumMemberList,
            in UsingDirectiveList usingDirectiveList = default,
            in DocumentationCommentList documentationCommentList = default,
            in AttributeListCollection attributeListCollection = default)
        {
            var records = enumMemberList.EnumMemberListAssociations.Count();
            return (records >= short.MaxValue) ? PublicInt(in identifier, in @namespace, in enumMemberList, in usingDirectiveList, in documentationCommentList, in attributeListCollection)
                : (records >= byte.MaxValue) ? PublicShort(in identifier, in @namespace, in enumMemberList, in usingDirectiveList, in documentationCommentList, in attributeListCollection)
                : PublicByte(in identifier, in @namespace, in enumMemberList, in usingDirectiveList, in documentationCommentList, in attributeListCollection);
        }

        public static EnumDeclaration PublicInt(
            in string identifier,
            in string @namespace,
            in EnumMemberList enumMemberList,
            in UsingDirectiveList usingDirectiveList = default,
            in DocumentationCommentList documentationCommentList = default,
            in AttributeListCollection attributeListCollection = default,
            in BaseList baseList = default)
            => new EnumDeclaration(
                in identifier,
                in @namespace,
                in ModifierLists.Public,
                in usingDirectiveList,
                in documentationCommentList,
                in attributeListCollection,
                baseList: in baseList,
                enumMemberList: in enumMemberList);

        public static EnumDeclaration PublicByte(
            in string identifier,
            in string @namespace,
            in EnumMemberList enumMemberList,
            in UsingDirectiveList usingDirectiveList = default,
            in DocumentationCommentList documentationCommentList = default,
            in AttributeListCollection attributeListCollection = default)
            => PublicInt(
                in identifier,
                in @namespace,
                in enumMemberList,
                in usingDirectiveList,
                in documentationCommentList,
                in attributeListCollection,
                BaseLists.Byte);

        public static EnumDeclaration PublicShort(
            in string identifier,
            in string @namespace,
            in EnumMemberList enumMemberList,
            in UsingDirectiveList usingDirectiveList = default,
            in DocumentationCommentList documentationCommentList = default,
            in AttributeListCollection attributeListCollection = default)
            => PublicInt(
                in identifier,
                in @namespace,
                in enumMemberList,
                in usingDirectiveList,
                in documentationCommentList,
                in attributeListCollection,
                BaseLists.Short);

    }
}
