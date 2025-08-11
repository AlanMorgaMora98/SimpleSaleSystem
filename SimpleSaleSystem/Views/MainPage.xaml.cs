using Microsoft.UI.Xaml.Controls;

using SimpleSaleSystem.ViewModels;

namespace SimpleSaleSystem.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
