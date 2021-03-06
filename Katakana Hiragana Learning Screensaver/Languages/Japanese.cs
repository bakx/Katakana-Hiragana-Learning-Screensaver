﻿using System;
using System.Collections.Generic;
using System.Linq;
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
            //Romaji romaji = new Romaji();

            characterSets.Add(katakana);
            characterSets.Add(hiragana);
            //characterSets.Add(romaji);
        }

        public int CharacterCount()
        {
            return CharacterSets().First().GetCharacters().Count;
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