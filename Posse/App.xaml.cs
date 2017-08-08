using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Posse
{
    public partial class App : Application
    {
        // TODO visibility?
        static MemberDatabase database;

        // Constructor
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MemberListPage());
        }

        public static MemberDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new MemberDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("PosseSQLite.db3"));
                }
                return database;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
