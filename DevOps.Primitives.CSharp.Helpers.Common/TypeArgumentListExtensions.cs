using Common.EntityFrameworkServices;
using System.Linq;
using static System.String;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class TypeArgumentListExtensions
    {
        public static string GetNames(this TypeArgumentList list)
            => Join(",", list.GetRecords().Select(r => r.Identifier.Name.Value));
    }
}
