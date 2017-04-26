namespace Portfolio
{
    using Xamarin.Forms;

    public partial class App : Application
	{
		public App()
		{
            InitializeComponent();
            var page = new ProfilePage();
            Current.MainPage = new NavigationPage();
        }
    }
}
