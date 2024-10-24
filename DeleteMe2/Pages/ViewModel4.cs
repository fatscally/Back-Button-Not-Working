
using CommunityToolkit.Mvvm.Input;



namespace DeleteMe2.Pages;

public partial class ViewModel4
{

    [RelayCommand]
    public void CancelPage()
    {
        Shell.Current.Navigation.PopAsync();
    }

}
