using Common.EntityFrameworkServices;
using System;
using System.Linq;
using static System.String;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class ParameterListExtensions
    {
        private static readonly Func<Parameter, string> _selector = record => Concat(record.Type.Name.Value, ":", record.Identifier.Name.Value);

        public static string GetTypesAndNames(this ParameterList list)
            => Join(",", list.GetRecords().Select(_selector));
    }
}
