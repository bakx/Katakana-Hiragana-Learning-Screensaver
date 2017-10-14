using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using Screensaver.Annotations;
using Screensaver.Languages;

namespace Screensaver.ViewModels
{
    public class MainViewModel : ILanguage, INotifyPropertyChanged
    {
        private Brush backColor = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
        private string character1 = "";

        private string character2 = "";

        private string character3 = "";

        private Brush fontColor = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));

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

        public int FontSize { get; set; } = 256;
        public int CharacterMargin { get; set; } = 125;
        public FontWeight FontWeight { get; set; } = FontWeights.Bold;

        public int CurrentChar { get; set; } = -1;

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
    }
}