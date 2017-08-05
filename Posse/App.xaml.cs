using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
// Needed? 
using System.Diagnostics;
// Old
//using System.Collections.Generic;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Posse
{
    public partial class App : Application
    {
        // Old
        // public static IList<string> Members { get; set; }

        // visibility?
        static MemberDatabase database;

        // Constructor
        public App()
        {
            //Old:
            //InitializeComponent();
            //Members = new List<string>();
            //Members.Add("Jan Boomkap");
            //Members.Add("Henk Stuivestijn");
            //MainPage = new MemberListPage();

            //Resources = new ResourceDictionary();
            //Resources.Add("primaryGreen", Color.FromHex("91CA47"));
            //Resources.Add("primaryDarkGreen", Color.FromHex("6FA22E"));

            var nav = new NavigationPage(new MemberListPage());
            //nav.BarBackgroundColor = (Color)App.Current.Resources["primaryGreen"];
            //nav.BarTextColor = Color.White;

            MainPage = nav;
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
