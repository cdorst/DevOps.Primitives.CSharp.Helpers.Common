using static System.String;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class Attributes
    {
        public static readonly Attribute Key = new Attribute(nameof(Key));
        public static readonly Attribute ProtoContract = new Attribute(nameof(ProtoContract));
        public static readonly Attribute Required = new Attribute(nameof(Required));

        public static Attribute ProtoMember(in int tag) => new Attribute(nameof(ProtoMember), Concat("(", tag.ToString(), ")"));
        public static Attribute Table(in string name, in string schema = default)
        {
            var args = Concat("\"", name, "\"");
            if (!IsNullOrWhiteSpace(schema)) args = Concat(args, ", Schema = \"", schema, "\"");
            return new Attribute(nameof(Table), Concat("(", args, ")"));
        }
    }
}
