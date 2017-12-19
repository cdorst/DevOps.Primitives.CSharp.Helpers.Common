namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public class PackageReference
    {
        public PackageReference() { }
        public PackageReference(string name, string version)
        {
            Name = name;
            Version = version;
        }

        public string Name { get; set; }
        public string Version { get; set; }
    }
}
