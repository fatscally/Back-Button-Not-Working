using CommunityToolkit.Mvvm.Input;



namespace DeleteMe2.Pages;

public partial class ViewModel3
{


    [RelayCommand]
    public void GoToFourPage()
    {
        Shell.Current.GoToAsync("FourPage");
    }



}
