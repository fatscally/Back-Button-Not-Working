using DeleteMe2.Pages;

namespace DeleteMe2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            Routing.RegisterRoute(nameof(OnePage), typeof(OnePage));
            Routing.RegisterRoute(nameof(TwoPage), typeof(TwoPage));
            Routing.RegisterRoute(nameof(ThreePage), typeof(ThreePage));
            Routing.RegisterRoute(nameof(FourPage), typeof(FourPage));
        }
    }
}
