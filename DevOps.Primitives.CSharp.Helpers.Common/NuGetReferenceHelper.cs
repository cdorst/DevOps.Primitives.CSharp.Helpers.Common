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
            foreach (var reference in GetReferences(referenceLists))
            {
                if (dict.ContainsKey(reference.Include)) continue;
                dict.Add(reference.Include, reference.Version);
            }
            foreach (var item in dict) yield return new NuGetReference(item.Key, item.Value);
        }

        public static NuGetReference Package(string name, string version)
            => new NuGetReference(name, version);

        private static IOrderedEnumerable<NuGetReference> GetReferences(IEnumerable<NuGetReference>[] referenceLists)
            => referenceLists
                .SelectMany(references => references)
                .OrderBy(reference => reference.Include)
                .ThenByDescending(reference => reference.Version);
    }
}
