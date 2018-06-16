namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class UsingDirectives
    {
        public static UsingDirective Using(in string @namespace)
            => new UsingDirective(in @namespace);

        public static UsingDirective UsingStatic(in string identifier)
            => new UsingDirective(in identifier)
            {
                UsingStatic = true
            };
    }
}
