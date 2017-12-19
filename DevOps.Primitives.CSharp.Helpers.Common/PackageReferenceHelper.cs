using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class PackageReferenceHelper
    {
        public static IEnumerable<PackageReference> Combine(params IEnumerable<PackageReference>[] lists)
        {
            var dict = new Dictionary<string, string>();
            foreach (var item in GetItems(lists))
            {
                if (dict.ContainsKey(item.Name)) continue;
                dict.Add(item.Name, item.Version);
            }
            foreach (var item in dict) yield return new PackageReference(item.Key, item.Value);
        }

        public static PackageReference Package(string name, string version)
            => new PackageReference(name, version);

        private static IOrderedEnumerable<PackageReference> GetItems(IEnumerable<PackageReference>[] lists)
            => lists.SelectMany(p => p).OrderBy(p => p.Name).ThenByDescending(p => p.Version);
    }
}
