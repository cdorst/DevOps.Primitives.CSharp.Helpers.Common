namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class PackageReferenceHelper
    {
        public static PackageReference Package(string name, string version)
            => new PackageReference(name, version);
    }
}
