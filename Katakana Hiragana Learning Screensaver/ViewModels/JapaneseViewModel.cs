using System;
using System.Collections.Generic;
using Screensaver.Languages;

namespace Screensaver.ViewModels
{
    public class JapaneseViewModel : MainViewModel
    {
        private readonly ILanguage language = new Japanese();

        public override string GetCharacter(int index)
        {
            throw new NotImplementedException();
        }

        public override int CharacterCount()
        {
            return language.CharacterCount();
        }

        public override List<ICharacters> CharacterSets()
        {
            return language.CharacterSets();
        }
    }
}