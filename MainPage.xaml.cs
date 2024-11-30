using MauiApp333.Mehanism;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
    public MainPage(System111 vm)
    {
        InitializeComponent();
        Title = string.Empty;
        BindingContext = vm;
        
    }
    
}