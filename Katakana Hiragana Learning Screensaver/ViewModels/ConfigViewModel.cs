using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace Screensaver.ViewModels
{
    public class ConfigViewModel : MainViewModel
    {
        private readonly Configuration parentWindow;

        public ConfigViewModel(Configuration parent)
        {
            parentWindow = parent;
            CancelCommand = new RelayCommand(Cancel, param => CanExecute(CancelCommand));
            SaveCommand = new RelayCommand(Save, param => CanExecute(SaveCommand));
        }

        public ICommand CancelCommand { get; set; }
        public ICommand SaveCommand { get; set; }


        public new List<string> DebugMessages { get; } = new List<string>();

        private void Save(object obj)
        {
            Properties.Settings.Default.CharacterInterval = CharacterInterval;
            Properties.Settings.Default.CharacterMargin = CharacterMargin;
            Properties.Settings.Default.FontSize = FontSize;
            Properties.Settings.Default.TimeFontSize = TimeFontSize;

            Properties.Settings.Default.Save();
            parentWindow.Close();
        }

        private void Cancel(object obj)
        {
            parentWindow.Close();
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }
    }
}