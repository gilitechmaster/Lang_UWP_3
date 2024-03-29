using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lang_UWP_3
{
    public partial class App : Application
    {
        public static string FolderPath { get; private set; }

        public App()
        {
            InitializeComponent();
            FolderPath = Path.Combine
                (Environment.GetFolderPath
                (Environment.SpecialFolder.LocalApplicationData));
            MainPage = new NavigationPage(new Page2());
        }
    }
}
