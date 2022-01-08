using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using MiniProjet.model;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MiniProjet
{
    public partial class App : Application
    {
        static ConnexionDatabase database;

        public static ConnexionDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ConnexionDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"projet.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
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
