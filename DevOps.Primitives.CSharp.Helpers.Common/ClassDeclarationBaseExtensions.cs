﻿using static DevOps.Primitives.CSharp.Helpers.Common.BaseLists;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class ClassDeclarationBaseExtensions
    {
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
    }
}
