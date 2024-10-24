namespace DeleteMe2.Pages;

public partial class ThreePage : ContentPage
{
	public ThreePage(ViewModel3 vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}