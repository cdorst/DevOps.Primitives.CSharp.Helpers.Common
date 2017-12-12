namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class Attributes
    {
        public static Attribute Key() => new Attribute(nameof(Key));
        public static Attribute Required() => new Attribute(nameof(Required));
    }
}
