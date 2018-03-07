using Common.EntityFrameworkServices;
using static DevOps.Primitives.CSharp.Helpers.Common.BaseTypeEqualityComparer;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class BaseListExtensions
    {
        public static BaseList Merge(this BaseList instance, BaseList given)
            => instance.Merge<BaseList, BaseType, BaseListAssociation>(given, Instance);
    }
}
