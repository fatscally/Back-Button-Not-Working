namespace DeleteMe2.Pages;

public partial class TwoPage : ContentPage
{


    public TwoPage(ViewModel2 vm)
	{
		InitializeComponent();

        BindingContext = vm;

    }
}