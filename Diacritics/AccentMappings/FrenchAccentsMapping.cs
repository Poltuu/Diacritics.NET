﻿using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class FrenchAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
            { 'à', "a" },
            { 'â', "a" },
            { 'ä', "a" },
            { 'æ', "a" },
            { 'ç', "c" },
            { '̧', "" },
            { 'é', "e" },
            { 'è', "e" },
            { 'ê', "e" },
            { 'ë', "e" },
            { 'î', "i" },
            { 'ï', "i" },
            { 'ô', "o" },
            { 'œ', "o" },
            { 'ù', "u" },
            { 'û', "u" },
            { 'ü', "u" },
        };

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}