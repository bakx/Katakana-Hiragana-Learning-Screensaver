using System.Collections.Generic;

namespace Screensaver.Languages.Characters.Japanese
{
    public class Romaji : ICharacters
    {
        public string GetCharacter(int index)
        {
            return GetCharacters()[index];
        }

        public List<string> GetCharacters()
        {
            return new List<string>
            {
                "A",
                "I",
                "U",
                "E",
                "O",
                "KA",
                "GA",
                "KI",
                "GI",
                "KU",
                "GU",
                "KE",
                "GE",
                "KO",
                "GO",
                "SA",
                "ZA",
                "SHI",
                "JI",
                "SU",
                "ZU",
                "SE",
                "ZE",
                "SO",
                "ZO",
                "TA",
                "DA",
                "CHI",
                "DI",
                "TSU",
                "DU",
                "TE",
                "DE",
                "TO",
                "DO",
                "NA",
                "NI",
                "NU",
                "NE",
                "NO",
                "HA",
                "BA",
                "PA",
                "HI",
                "BI",
                "PI",
                "HU",
                "BU",
                "PU",
                "HE",
                "BE",
                "PE",
                "HO",
                "BO",
                "PO",
                "MA",
                "MI",
                "MU",
                "ME",
                "MO",
                "YA",
                "YU",
                "YO",
                "RA",
                "RI",
                "RU",
                "RE",
                "RO",
                "WA",
                "WO",
                "N"
            };
        }
    }
}