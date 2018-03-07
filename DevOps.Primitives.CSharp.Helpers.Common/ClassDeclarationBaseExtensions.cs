using static DevOps.Primitives.CSharp.Helpers.Common.BaseLists;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class ClassDeclarationBaseExtensions
    {
        public static ClassDeclaration ClearBaseList(this ClassDeclaration @class)
        {
            @class.BaseListId = null;
            return @class;
        }

        public static ClassDeclaration WithSingleBaseType(
            this ClassDeclaration @class,
            BaseType baseType)
            => @class
                .ClearBaseList()
                .WithBase(baseType);

        public static ClassDeclaration WithSingleBaseType(
            this ClassDeclaration @class,
            string type,
            TypeArgumentList arguments = null)
            => @class
                .ClearBaseList()
                .WithBase(type, arguments);

        public static ClassDeclaration WithBase(
            this ClassDeclaration @class,
            BaseType baseType)
            => @class.WithBaseList(Create(baseType));

        public static ClassDeclaration WithBase(
            this ClassDeclaration @class,
            string type,
            TypeArgumentList arguments = null)
            => WithBase(@class, new BaseType(type, arguments));

        public static ClassDeclaration WithBaseList(
            this ClassDeclaration @class,
            BaseList baseList)
        {
            var existing = @class.BaseList;
            @class.BaseList = (existing == null) ? baseList: existing.Merge(baseList);
            return @class;
        }

        public static ClassDeclaration WithBases(
            this ClassDeclaration @class,
            params BaseType[] baseList)
            => @class.WithBaseList(Create(baseList));
    }
}
