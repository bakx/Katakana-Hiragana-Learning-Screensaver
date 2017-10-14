using System;
using System.Collections.Generic;
using Screensaver.Languages.Characters.Japanese;

namespace Screensaver.Languages
{
    public class Japanese : ILanguage
    {
        private readonly List<ICharacters> characterSets = new List<ICharacters>();

        public Japanese()
        {
            Katakana katakana = new Katakana();
            Hiragana hiragana = new Hiragana();

            characterSets.Add(katakana);
            characterSets.Add(hiragana);
        }

        public int CharacterCount()
        {
            return 70;
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