using System;
using System.Collections.Generic;
using Screensaver.Languages.Characters.Korean;

namespace Screensaver.Languages
{
    public class Korean : ILanguage
    {
        private readonly List<ICharacters> characterSets = new List<ICharacters>();

        public Korean()
        {
            Hangul katakana = new Hangul();

            characterSets.Add(katakana);
        }

        public int CharacterCount()
        {
            return CharacterSets().Count;
        }

        public List<ICharacters> CharacterSets()
        {
            return characterSets;
        }

        public string GetCharacter(int index)
        {
            throw new NotImplementedException();
        }
    }
}