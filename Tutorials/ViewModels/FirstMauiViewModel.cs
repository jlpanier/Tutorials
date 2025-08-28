using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Maui.Tutorials.Pages;
using System.Collections.ObjectModel;
using static System.Net.Mime.MediaTypeNames;

namespace Maui.Tutorials.ViewModels
{
    public partial class FirstMauiViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        private string text;

        public FirstMauiViewModel()
        {
            text = string.Empty;
            Items = new ObservableCollection<string>()
            {
                "toto", "tata", "mama"
            };
        }

        [RelayCommand]
        async Task Add()
        {
            if (string.IsNullOrWhiteSpace(Text)) return;

            Items.Add(Text);
            Text = string.Empty;
            await Task.Delay(10);
        }

        [RelayCommand]
        async Task Delete()
        {
            if (string.IsNullOrWhiteSpace(Text)) return;
            await Task.Delay(10);
        }

        [RelayCommand]
        async Task Tap(string s)
        {
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={s}");
        }

    }
}
