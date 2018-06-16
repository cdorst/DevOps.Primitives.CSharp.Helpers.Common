using static DevOps.Primitives.CSharp.Helpers.Common.MethodLists;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class ClassDeclarationMethodExtensions
    {
        public static ClassDeclaration ClearMethodList(this ClassDeclaration @class)
        {
            @class.MethodList = null;
            return @class;
        }

        public static ClassDeclaration WithSingleMethod(
            this ClassDeclaration @class,
            in Method method)
            => @class
                .ClearMethodList()
                .WithMethod(in method);

        public static ClassDeclaration WithMethod(
            this ClassDeclaration @class,
            in Method method)
            => @class.WithMethodList(Create(method));

        public static ClassDeclaration WithMethodList(
            this ClassDeclaration @class,
            in MethodList methodList)
        {
            var existing = @class.MethodList;
            @class.MethodList = (existing == null) ? methodList : existing.Merge(methodList);
            return @class;
        }

        public static ClassDeclaration WithMethods(
            this ClassDeclaration @class,
            params Method[] methods)
            => @class.WithMethodList(Create(methods));
    }
}
