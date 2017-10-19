using System.Collections.Generic;
using System.Windows.Input;
using System.Windows.Media;
using ColorPickerWPF;
using ColorPickerWPF.Code;
using Screensaver.Properties;

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
            ChangeColorCommand = new RelayCommand(ChangeColor, param => CanExecute(ChangeColorCommand));
        }

        public ICommand CancelCommand { get; set; }
        public ICommand SaveCommand { get; set; }
        public ICommand ChangeColorCommand { get; set; }


        public new List<string> DebugMessages { get; } = new List<string>();

        private void Save(object obj)
        {
            Settings.Default.CharacterInterval = CharacterInterval;
            Settings.Default.CharacterMargin = CharacterMargin;
            Settings.Default.FontSize = FontSize;
            Settings.Default.TimeFontSize = TimeFontSize;
            Settings.Default.BackColor = BackColor.ToString();
            Settings.Default.ForeColor = ForeColor.ToString();
            Settings.Default.DisplayTime = DisplayTime;
            Settings.Default.UseAllScreens = UseAllScreens;
            Settings.Default.TimeFormat = TimeFormat;

            Settings.Default.Save();
            parentWindow.Close();
        }

        private void ChangeColor(object obj)
        {
            bool result = ColorPickerWindow.ShowDialog(out Color color, ColorPickerDialogOptions.SimpleView);

            if (!result)
            {
                return;
            }

            if (obj.ToString() == "backcolor")
            {
                BackColor = new SolidColorBrush(color);
            }
            else
            {
                ForeColor = new SolidColorBrush(color);
            }
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