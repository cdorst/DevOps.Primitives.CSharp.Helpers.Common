using DevOps.Primitives.NuGet;
using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class NuGetReferenceHelper
    {
        public static IEnumerable<NuGetReference> Combine(params IEnumerable<NuGetReference>[] referenceLists)
        {
            var dict = new Dictionary<string, string>();
            foreach (var reference in GetReferences(in referenceLists))
            {
                var include = reference.Include.Value;
                if (dict.ContainsKey(include)) continue;
                dict.Add(include, reference.Version.Value);
            }
            foreach (var item in dict) yield return new NuGetReference(item.Key, item.Value);
        }

        public static NuGetReference Package(in string name, in string version)
            => new NuGetReference(name, version);

        private static IOrderedEnumerable<NuGetReference> GetReferences(in IEnumerable<NuGetReference>[] referenceLists)
            => referenceLists
                .SelectMany(references => references)
                .OrderBy(reference => reference.Include.Value)
                .ThenByDescending(reference => reference.Version.Value);
    }
}
