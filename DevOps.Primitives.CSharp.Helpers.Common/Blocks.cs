namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class Blocks
    {
        public static Block Create(params Statement[] statements)
            => new Block(
                StatementLists.Create(statements));

        public static Block Create(params string[] statements)
            => new Block(
                StatementLists.Create(statements));
    }
}
