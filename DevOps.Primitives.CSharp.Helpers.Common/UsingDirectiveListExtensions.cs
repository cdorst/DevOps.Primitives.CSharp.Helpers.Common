using Common.EntityFrameworkServices;
using static DevOps.Primitives.CSharp.Helpers.Common.UsingDirectiveEqualityComparer;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class UsingDirectiveListExtensions
    {
        public static UsingDirectiveList Merge(this UsingDirectiveList instance, in UsingDirectiveList given)
            => instance.Merge<UsingDirectiveList, UsingDirective, UsingDirectiveListAssociation>(given, Instance);
    }
}
