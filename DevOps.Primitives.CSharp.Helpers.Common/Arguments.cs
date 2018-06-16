namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class Arguments
    {
        public static Argument Argument(in string literal)
            => new Argument(in literal);
    }
}
