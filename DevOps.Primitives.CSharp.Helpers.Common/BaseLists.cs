using System;
using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.Common
{
    public static class BaseLists
    {
        private static readonly Func<BaseType, BaseListAssociation> _baseTypeSelector = baseType => new BaseListAssociation(in baseType);
        private static readonly Func<string, BaseType> _stringSelector = baseType => new BaseType(in baseType);

        public static BaseList Byte
            => Create("byte");

        public static BaseList Short
            => Create("short");

        public static BaseList Create(params BaseType[] baseTypes)
            => new BaseList(baseTypes.Select(_baseTypeSelector).ToList());

        public static BaseList Create(params string[] baseTypes)
            => Create(baseTypes.Select(_stringSelector).ToArray());
    }
}
