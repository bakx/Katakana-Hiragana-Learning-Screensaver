using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Threading;
using Screensaver.ViewModels;
using Application = System.Windows.Application;

namespace Screensaver
{
    public class Main
    {
        private static volatile Main _instance;
        private static readonly object SyncRoot = new object();
        private readonly List<MainWindow> windows = new List<MainWindow>();
        private DispatcherTimer dispatcherTimer;

        private Main()
        {
        }

        public MainViewModel Model { get; private set; }

        public static Main Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (SyncRoot)
                    {
                        if (_instance == null)
                        {
                            _instance = new Main();
                        }
                    }
                }

                return _instance;
            }
        }

        public void Start()
        {
            // This function should get a config file
            //
            Model = new JapaneseViewModel();

            // Loop through all connected screens
            foreach (Screen s in Screen.AllScreens)
            {
                MainWindow window = new MainWindow(Model)
                {
                    Left = s.WorkingArea.Left,
                    Top = s.WorkingArea.Top,
                    Width = s.WorkingArea.Width / 2, // Used for debugging
                    Height = s.WorkingArea.Height / 2 // Used for debugging
                };

                windows.Add(window);
            }

            foreach (MainWindow window in windows)
            {
                window.Show();
            }

            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += (sender, args) =>
            {
                // Grab random character
                int i = new Random((int) DateTime.Now.Ticks).Next(0, Model.CharacterCount());

                foreach (MainWindow window in windows)
                {
                    window.Update(i);
                }
            };
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 500);
            dispatcherTimer.Start();
        }

        public void Stop()
        {
            foreach (MainWindow window in windows)
            {
                window.Close();
            }

            Application.Current.Shutdown();
        }
    }
}