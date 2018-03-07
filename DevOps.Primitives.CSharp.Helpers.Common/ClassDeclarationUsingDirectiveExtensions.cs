using System.Linq;
using static DevOps.Primitives.CSharp.Helpers.Common.UsingDirectives;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class ClassDeclarationUsingDirectiveExtensions
    {
        public static ClassDeclaration ClearUsingDirectiveList(this ClassDeclaration @class)
        {
            @class.UsingDirectiveList = null;
            return @class;
        }

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

        public static ClassDeclaration WithUsings(
            this ClassDeclaration @class,
            params UsingDirective[] usings)
            => @class.WithUsingDirectiveList(UsingDirectiveLists.Create(usings));

        public static ClassDeclaration WithUsings(
            this ClassDeclaration @class,
            params string[] usings)
            => @class.WithUsingDirectiveList(UsingDirectiveLists.Create(usings));

        public static ClassDeclaration WithUsingStatics(
            this ClassDeclaration @class,
            params string[] usingStatics)
            => @class.WithUsingDirectiveList(
                UsingDirectiveLists.Create(usingStatics.Select(u => UsingStatic(u)).ToArray()));
    }
}
