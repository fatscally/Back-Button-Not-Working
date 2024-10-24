using CommunityToolkit.Mvvm.Input;

namespace DeleteMe2.Pages
{
    public partial class ViewModel1
    {
        [RelayCommand]
        public async Task GoToTwoPage()
        {
            //BACK BUTTON WORKS
            await Shell.Current.GoToAsync("TwoPage");

            //BACK BUTTON WORKS
            //await Shell.Current.Navigation.PushAsync(new TwoPage(new ViewModel2()));

        }
    }
}
