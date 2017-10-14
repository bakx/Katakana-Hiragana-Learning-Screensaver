using System.Collections.Generic;

namespace Screensaver.Languages.Characters.Japanese
{
    public class Katakana : ICharacters
    {
        public string GetCharacter(int index)
        {
            return GetCharacters()[index];
        }

        public List<string> GetCharacters()
        {
            return new List<string>
            {
                "ア",
                "イ",
                "ウ",
                "エ",
                "オ",
                "カ",
                "ガ",
                "キ",
                "ギ",
                "ク",
                "グ",
                "ケ",
                "ゲ",
                "コ",
                "ゴ",
                "サ",
                "ザ",
                "シ",
                "ジ",
                "ス",
                "ズ",
                "セ",
                "ゼ",
                "ソ",
                "ゾ",
                "タ",
                "ダ",
                "チ",
                "ヂ",
                "ツ",
                "ヅ",
                "テ",
                "デ",
                "ト",
                "ド",
                "ナ",
                "ニ",
                "ヌ",
                "ネ",
                "ノ",
                "ハ",
                "バ",
                "パ",
                "ヒ",
                "ビ",
                "ピ",
                "フ",
                "ブ",
                "プ",
                "ヘ",
                "ベ",
                "ペ",
                "ホ",
                "ボ",
                "ポ",
                "マ",
                "ミ",
                "ム",
                "メ",
                "モ",
                "ヤ",
                "ユ",
                "ヨ",
                "ラ",
                "リ",
                "ル",
                "レ",
                "ロ",
                "ワ",
                "ヲ",
                "ン"
            };
        }
    }
}