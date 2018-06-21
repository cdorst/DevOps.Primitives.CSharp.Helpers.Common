namespace DevOps.Primitives.CSharp.Helpers.Common
{
    internal static class TrailingSemicolonRemover
    {
        public static string RemoveTrailingSemicolon(in string instance)
        {
            var lengthMinusOne = instance.Length - 1;
            return instance[lengthMinusOne] == ';'
                ? instance.Substring(0, lengthMinusOne)
                : instance;
        }
    }
}
