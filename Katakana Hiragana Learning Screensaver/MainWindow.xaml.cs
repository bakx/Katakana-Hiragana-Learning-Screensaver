using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using Screensaver.ViewModels;

namespace Screensaver
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private readonly MainViewModel model;

        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            DataContext = model = viewModel;
            Setup();

            // Hide Mouse Cursor
            Cursor = Cursors.None;
        }

        private void Setup()
        {
            StackPanel.Children.Clear();

            for (int i = 0; i < model.CharacterSets().Count; i++)
            {
                TextBlock block = new TextBlock();

                // Text Binding
                //

                Binding textBinding =
                    new Binding
                    {
                        Path = new PropertyPath(GetCharacterBinding(i)),
                        Source = model
                    };

                BindingOperations.SetBinding(block, TextBlock.TextProperty, textBinding);

                // Fore Color Binding
                //

                Binding fontColorBinding =
                    new Binding
                    {
                        Path = new PropertyPath(nameof(model.FontColor)),
                        Source = model
                    };

                BindingOperations.SetBinding(block, TextBlock.ForegroundProperty, fontColorBinding);

                // Font Size Binding
                //

                Binding fontSizeBinding =
                    new Binding
                    {
                        Path = new PropertyPath(nameof(model.FontSize)),
                        Source = model
                    };

                BindingOperations.SetBinding(block, TextBlock.FontSizeProperty, fontSizeBinding);

                // Font Weight Binding
                //

                Binding fontWeightBinding =
                    new Binding
                    {
                        Path = new PropertyPath(nameof(model.FontWeight)),
                        Source = model
                    };

                BindingOperations.SetBinding(block, TextBlock.FontWeightProperty, fontWeightBinding);

                // Margin Binding
                //

                Binding marginBinding =
                    new Binding
                    {
                        Path = new PropertyPath(nameof(model.CharacterMargin)),
                        Source = model
                    };

                BindingOperations.SetBinding(block, MarginProperty, marginBinding);

                StackPanel.Children.Add(block);
            }
        }

        private string GetCharacterBinding(int index)
        {
            switch (index)
            {
                case 0:
                    return nameof(model.Character1);
                case 1:
                    return nameof(model.Character2);
                default:
                    return nameof(model.Character3);
            }
        }

        private void MainWindow_OnKeyDown(object sender, KeyEventArgs e)
        {
            Main.Instance.Stop();
        }

        public void Update(int displayIndex)
        {
            for (int i = 0; i < model.CharacterSets().Count; i++)
            {
                switch (i)
                {
                    case 0:
                        model.Character1 = model.CharacterSets()[0].GetCharacter(displayIndex);
                        break;
                    case 1:
                        model.Character2 = model.CharacterSets()[1].GetCharacter(displayIndex);
                        break;
                    default:
                        model.Character3 = model.CharacterSets()[2].GetCharacter(displayIndex);
                        break;
                }
            }
        }

        private void MainWindow_OnClosed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}