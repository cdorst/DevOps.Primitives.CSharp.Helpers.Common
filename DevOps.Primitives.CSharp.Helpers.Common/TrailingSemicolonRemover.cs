namespace DevOps.Primitives.CSharp.Helpers.Common
{
    internal static class TrailingSemicolonRemover
    {
        public static string RemoveTrailingSemicolon(in string instance)
        {
            var index = instance.Length;
            return instance[index] == ';'
                ? instance.Substring(0, index - 1)
                : instance;
        }
    }
}
