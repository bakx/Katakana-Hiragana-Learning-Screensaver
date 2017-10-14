using System.Collections.Generic;

namespace Screensaver.Languages
{
    public interface ILanguage
    {
        int CharacterCount();
        List<ICharacters> CharacterSets();
        string GetCharacter(int index);
    }
}