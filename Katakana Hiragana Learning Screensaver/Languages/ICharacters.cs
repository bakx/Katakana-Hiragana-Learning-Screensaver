using System.Collections.Generic;

namespace Screensaver.Languages
{
    public interface ICharacters
    {
        List<string> GetCharacters();
        string GetCharacter(int index);
    }
}