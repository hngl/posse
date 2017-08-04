using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Posse
{
    public partial class App : Application
    {

        public static IList<string> Members { get; set; }

        // Constructor
        public App()
        {
            InitializeComponent();
            Members = new List<string>();
			Members.Add("Jan Boomkap");
			Members.Add("Henk Stuivestijn");
			MainPage = new MemberListPage();
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
