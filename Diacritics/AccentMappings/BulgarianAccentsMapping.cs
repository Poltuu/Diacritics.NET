using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public partial class BulgarianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
            { 'ъ', "ь" },
            { 'ѝ', "и" },
            { 'й', "и" }
        };

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}