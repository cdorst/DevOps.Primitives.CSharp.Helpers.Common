namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class UsingDirectives
    {
        public static UsingDirective Using(string @namespace)
            => new UsingDirective(@namespace);

        public static UsingDirective UsingStatic(string identifier)
            => new UsingDirective(identifier)
            {
                UsingStatic = true
            };
    }
}
