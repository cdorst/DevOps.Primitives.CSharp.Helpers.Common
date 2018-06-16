using Common.EntityFrameworkServices;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class MethodListExtensions
    {
        public static MethodList Merge(this MethodList instance, in MethodList given)
            => instance.Merge<MethodList, Method, MethodListAssociation>(
                given,
                MethodEqualityComparer.Instance);
    }
}
