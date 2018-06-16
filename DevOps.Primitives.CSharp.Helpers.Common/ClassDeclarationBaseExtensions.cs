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
            in BaseType baseType)
            => @class
                .ClearBaseList()
                .WithBase(in baseType);

        public static ClassDeclaration WithSingleBaseType(
            this ClassDeclaration @class,
            in string type,
            in TypeArgumentList arguments = default)
            => @class
                .ClearBaseList()
                .WithBase(in type, in arguments);

        public static ClassDeclaration WithBase(
            this ClassDeclaration @class,
            in BaseType baseType)
            => @class.WithBaseList(Create(baseType));

        public static ClassDeclaration WithBase(
            this ClassDeclaration @class,
            in string type,
            in TypeArgumentList arguments = default)
            => WithBase(@class, new BaseType(in type, in arguments));

        public static ClassDeclaration WithBaseList(
            this ClassDeclaration @class,
            in BaseList baseList)
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
