using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using Screensaver.Languages;
using Screensaver.Properties;

namespace Screensaver.ViewModels
{
    public class MainViewModel : CommandBase, ILanguage, INotifyPropertyChanged
    {
        private Brush backColor = Config.Instance.BackColor;
        private string character1 = "";

        private string character2 = "";

        private string character3 = "";

        private string currentTime = "";

        private Brush fontColor = Config.Instance.FontColor;

        public List<string> DebugMessages { get; } = new List<string>();

        public string CurrentTime
        {
            get => currentTime;
            set
            {
                currentTime = value;
                OnPropertyChanged(nameof(CurrentTime));
            }
        }

        public string Character1
        {
            get => character1;
            set
            {
                character1 = value;
                OnPropertyChanged(nameof(Character1));
            }
        }

        public string Character2
        {
            get => character2;
            set
            {
                character2 = value;
                OnPropertyChanged(nameof(Character2));
            }
        }

        public string Character3
        {
            get => character3;
            set
            {
                character3 = value;
                OnPropertyChanged(nameof(Character3));
            }
        }

        public Brush FontColor
        {
            get => fontColor;
            set
            {
                fontColor = value;
                OnPropertyChanged(nameof(FontColor));
            }
        }

        public Brush BackColor
        {
            get => backColor;
            set
            {
                backColor = value;
                OnPropertyChanged(nameof(BackColor));
            }
        }

        public int FontSize { get; set; } = Config.Instance.FontSize;
        public int TimeFontSize { get; set; } = Config.Instance.TimeFontSize;
        public int CharacterMargin { get; set; } = Config.Instance.CharacterMargin;
        public FontWeight FontWeight { get; set; } = Config.Instance.FontWeight;
        public FontWeight TimeFontWeight { get; set; } = Config.Instance.TimeFontWeight;

        public int CharacterInterval { get; set; } = Config.Instance.CharacterInterval;


        public virtual int CharacterCount()
        {
            throw new NotImplementedException();
        }

        public virtual List<ICharacters> CharacterSets()
        {
            throw new NotImplementedException();
        }

        public virtual string GetCharacter(int index)
        {
            throw new NotImplementedException();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected override void OnExecute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}