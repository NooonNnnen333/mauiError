using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
namespace MauiApp333.Mehanism;

public partial class System111 : ObservableObject
{
    public System111()
    {
        items = new ObservableCollection<string>();
    }
    
    [ObservableProperty] 
    private ObservableCollection<string> items;

    [ObservableProperty]  
    string text;
    
    [RelayCommand]
    void AddItem()
    {
        if (string.IsNullOrEmpty(Text))
            return;
        
        Items.Add(Text);
        Text = string.Empty;
    }

    [RelayCommand]
    void DeleteItem(string itemDelite)
    {
        if (Items.Contains(itemDelite)) // Если Items содержит itemDelite
        {
            Items.Remove(itemDelite);
        } 
    }

    [RelayCommand]

    void ClearItems(string s)
    {
        if (items.Contains(s))
            items.Remove(s);
    }

    [RelayCommand]
    async Task TapCommand(string s)
    {
        await Shell.Current.GoToAsync(nameof(DitalPage), new Dictionary<string, object> { { "Text", s } });
    }


}