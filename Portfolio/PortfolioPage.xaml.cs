using Xamarin.Forms;

namespace Portfolio
{
    public partial class PortfolioPage : ContentPage
    {
        public PortfolioPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new ProfilePage());
        }
    }
}
