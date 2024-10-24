﻿using CommunityToolkit.Mvvm.Input;

namespace DeleteMe2.Pages;

public partial class ViewModel5
{
    [RelayCommand]
    public void GoToSixPage()
    {
        Shell.Current.GoToAsync("SixPage");
    }


    [RelayCommand]
    public void CancelPage()
    {
        Shell.Current.Navigation.PopAsync();
    }


}
