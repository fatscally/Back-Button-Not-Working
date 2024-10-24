namespace DeleteMe2.Pages;

public partial class FourPage : ContentPage
{
	public FourPage(ViewModel4 vm)
	{
		InitializeComponent();

        BindingContext = vm;
    }
}