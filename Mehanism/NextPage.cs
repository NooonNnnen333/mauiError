using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp333.Mehanism;

[QueryProperty("Text", "Text")]
public partial class NextPage : ObservableObject
{
    [ObservableProperty]
    private string text;
}