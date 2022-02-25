using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


[assembly: ExportFont("MaterialIcons-Regular.ttf", Alias = "FelixFont")]
namespace APlus_Mobile
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "project.db";
        public static ProjectRepository database;
        public static ProjectRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new ProjectRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            Application.Current.UserAppTheme = OSAppTheme.Light;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
