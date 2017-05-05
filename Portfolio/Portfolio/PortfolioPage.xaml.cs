using Xamarin.Forms;

namespace Portfolio
{
    public partial class PortfolioPage : ContentPage
    {
        public PortfolioPage()
        {
            InitializeComponent();
        }

        void GoToProfilePage(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new ProfilePage());
        }

		void GoToCatalogPage(object sender, System.EventArgs e)
		{
            this.Navigation.PushAsync(new CatalogPage());
		}
    }
}