using Common.EntityFrameworkServices;
using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class TypeArgumentListExtensions
    {
        public static string GetNames(this TypeArgumentList list)
            => string.Join(",", list.GetRecords()
                    .Select(r => r.Identifier.Name.Value));
    }
}
