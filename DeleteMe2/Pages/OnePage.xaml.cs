namespace DeleteMe2.Pages;

public partial class OnePage : ContentPage
{


    public OnePage(ViewModel1 vm)
	{
		InitializeComponent();

        BindingContext = vm;
    }
}