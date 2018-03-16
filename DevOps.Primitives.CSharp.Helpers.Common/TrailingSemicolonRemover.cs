namespace DevOps.Primitives.CSharp.Helpers.Common
{
    internal static class TrailingSemicolonRemover
    {
        public static string RemoveTrailingSemicolon(this string instance)
            => instance.EndsWith(";")
                ? instance.Substring(0, instance.Length - 1)
                : instance;
    }
}
