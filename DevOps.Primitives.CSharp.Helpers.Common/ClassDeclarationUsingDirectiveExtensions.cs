using static DevOps.Primitives.CSharp.Helpers.Common.UsingDirectives;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class ClassDeclarationUsingDirectiveExtensions
    {
        public static ClassDeclaration WithUsingDirective(
            this ClassDeclaration @class,
            string @namespace)
            => WithUsingDirective(@class, Using(@namespace));

        public static ClassDeclaration WithUsingDirective(
            this ClassDeclaration @class,
            UsingDirective usingDirective)
            => @class.WithUsingDirectiveList(
                UsingDirectiveLists.Create(usingDirective));

        public static ClassDeclaration WithUsingStaticDirective(
            this ClassDeclaration @class,
            string @namespace)
            => WithUsingDirective(@class, UsingStatic(@namespace));

        public static ClassDeclaration WithUsingDirectiveList(
            this ClassDeclaration @class,
            UsingDirectiveList usingDirectiveList)
        {
            var existing = @class.UsingDirectiveList;
            @class.UsingDirectiveList = (existing == null) ? usingDirectiveList : existing.Merge(usingDirectiveList);
            return @class;
        }
    }
}
