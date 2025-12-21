using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Tutorials.ViewModels
{
    [QueryProperty("Text","Text")]

    public partial class DetailViewModel:ObservableObject
    {
        [ObservableProperty]
        private string text;

        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
