using System.Collections.Generic;

namespace Screensaver.Languages.Characters.Japanese
{
    public class Hiragana : ICharacters
    {
        public string GetCharacter(int index)
        {
            return GetCharacters()[index];
        }

        public List<string> GetCharacters()
        {
            return new List<string>
            {
                "あ",
                "い",
                "う",
                "え",
                "お",
                "か",
                "が",
                "き",
                "ぎ",
                "く",
                "ぐ",
                "け",
                "げ",
                "こ",
                "ご",
                "さ",
                "ざ",
                "し",
                "じ",
                "す",
                "ず",
                "せ",
                "ぜ",
                "そ",
                "ぞ",
                "た",
                "だ",
                "ち",
                "ぢ",
                "つ",
                "づ",
                "て",
                "で",
                "と",
                "ど",
                "な",
                "に",
                "ぬ",
                "ね",
                "の",
                "は",
                "ば",
                "ぱ",
                "ひ",
                "び",
                "ぴ",
                "ふ",
                "ぶ",
                "ぷ",
                "へ",
                "べ",
                "ぺ",
                "ほ",
                "ぼ",
                "ぽ",
                "ま",
                "み",
                "む",
                "め",
                "も",
                "や",
                "ゆ",
                "よ",
                "ら",
                "り",
                "る",
                "れ",
                "ろ",
                "わ",
                "を",
                "ん"
            };
        }
    }
}
