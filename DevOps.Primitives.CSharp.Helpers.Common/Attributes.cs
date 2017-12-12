namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class Attributes
    {
        public static Attribute Key() => new Attribute(nameof(Key));
        public static Attribute ProtoContract() => new Attribute(nameof(ProtoContract));
        public static Attribute ProtoMember(int tag) => new Attribute(nameof(ProtoMember), tag.ToString());
        public static Attribute Required() => new Attribute(nameof(Required));
    }
}
