using Common.EntityFrameworkServices;
using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class ParameterListExtensions
    {
        public static string GetTypesAndNames(this ParameterList list)
            => string.Join(",", list.GetRecords()
                    .Select(r => $"{r.Type.Name.Value}:{r.Identifier.Name.Value}"));
    }
}
