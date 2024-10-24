using CommunityToolkit.Mvvm.Input;

namespace DeleteMe2.Pages;

public partial class ViewModel2
{
    [RelayCommand]
    public async Task GoToThreePage()
    {
        //BACK BUTTON DOESN'T WORK
        await Shell.Current.GoToAsync("ThreePage");

        //BACK BUTTON DOESN'T WORK
        //await Shell.Current.Navigation.PushAsync(new ThreePage(new ViewModel3()));
    }
}
