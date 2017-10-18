using System.Windows;
using System.Windows.Media;
using Screensaver.Properties;

namespace Screensaver
{
    public class Config
    {
        private static volatile Config _instance;
        private static readonly object SyncRoot = new object();

        private Config()
        {
            CharacterInterval = Settings.Default.CharacterInterval;
            FontSize = Settings.Default.FontSize;
            CharacterMargin = Settings.Default.CharacterMargin;
            DisplayTime = Settings.Default.DisplayTime;
            TimeFontSize = Settings.Default.TimeFontSize;

            switch (Settings.Default.FontWeight)
            {
                case 0:
                    FontWeight = FontWeights.Normal;
                    break;
                case 1:
                    FontWeight = FontWeights.ExtraBold;
                    break;
                case 2:
                    FontWeight = FontWeights.Heavy;
                    break;
                case 3:
                    FontWeight = FontWeights.Light;
                    break;
                default:
                    FontWeight = FontWeights.Bold;
                    break;
            }

            switch (Settings.Default.TimeFontWeight)
            {
                case 0:
                    TimeFontWeight = FontWeights.Normal;
                    break;
                case 1:
                    TimeFontWeight = FontWeights.ExtraBold;
                    break;
                case 2:
                    TimeFontWeight = FontWeights.Heavy;
                    break;
                case 3:
                    TimeFontWeight = FontWeights.Light;
                    break;
                default:
                    TimeFontWeight = FontWeights.Bold;
                    break;
            }

            byte[] foreColor = ConvertStringToArgb(Settings.Default.ForeColor);
            FontColor = new SolidColorBrush(Color.FromArgb(foreColor[0], foreColor[1], foreColor[2], foreColor[3]));

            byte[] backColor = ConvertStringToArgb(Settings.Default.BackColor);
            BackColor = new SolidColorBrush(Color.FromArgb(backColor[0], backColor[1], backColor[2], backColor[3]));

            DebugMode = Settings.Default.DebugMode;

            UseAllScreens = Settings.Default.UseAllScreens;
            TimeFormat = Settings.Default.TimeFormat;
        }

        public static Config Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (SyncRoot)
                    {
                        if (_instance == null)
                        {
                            _instance = new Config();
                        }
                    }
                }

                return _instance;
            }
        }

        public int TimeFontSize { get; set; }
        public int CharacterInterval { get; set; }
        public int FontSize { get; set; }
        public int CharacterMargin { get; set; }
        public FontWeight TimeFontWeight { get; set; }
        public FontWeight FontWeight { get; set; }
        public Brush FontColor { get; set; }
        public Brush BackColor { get; set; }
        public bool DebugMode { get; set; }
        public bool UseAllScreens { get; set; }
        public bool DisplayTime { get; set; }
        public string TimeFormat { get; set; }


        private static byte[] ConvertStringToArgb(string value)
        {
            string[] values = value.Split(',');
            return new[]
            {
                byte.Parse(values[0]),
                byte.Parse(values[1]),
                byte.Parse(values[2]),
                byte.Parse(values[3])
            };
        }
    }
}