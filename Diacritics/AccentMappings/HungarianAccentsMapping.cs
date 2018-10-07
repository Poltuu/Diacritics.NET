﻿using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class HungarianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, string> MappingDictionary = new Dictionary<char, string>
        {
            { 'á', "a" },
            { 'é', "e" },
            { 'í', "i" },
            { 'ö', "o" },
            { 'ó', "o" },
            { 'ő', "o" },
            { 'ü', "u" },
            { 'ú', "u" },
            { 'ű', "u" },
        };

        public IDictionary<char, string> Mapping { get { return MappingDictionary; } }
    }
}