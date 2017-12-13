namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class Constructors
    {
        public static Constructor Default(string name)
            => new Constructor(name, new Block(), ModifierLists.Public);
    }
}
