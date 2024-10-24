using DeleteMe2.Pages;

namespace DeleteMe2;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(OnePage), typeof(OnePage));
        Routing.RegisterRoute(nameof(TwoPage), typeof(TwoPage));
        Routing.RegisterRoute(nameof(ThreePage), typeof(ThreePage));
        Routing.RegisterRoute(nameof(FourPage), typeof(FourPage));

    }
}
