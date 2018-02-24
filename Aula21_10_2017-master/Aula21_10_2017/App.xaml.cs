using Xamarin.Forms;

namespace Aula21_10_2017
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Aula21_10_2017Page();
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
