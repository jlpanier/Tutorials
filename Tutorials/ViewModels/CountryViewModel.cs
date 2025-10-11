using CommunityToolkit.Mvvm.ComponentModel;
using Maui.Tutorials.Models;
using System.Collections.ObjectModel;

namespace Maui.Tutorials.ViewModels
{
    public partial class CountryViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Country> items;

        public CountryViewModel()
        {
            Items = new ObservableCollection<Country>();
        }

        public async Task Load()
        {
            var items = await Country.Get();
            Items = new ObservableCollection<Country>(items.OrderBy(_=>_.Name));
        }
    }
}
