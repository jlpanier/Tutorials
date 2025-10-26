using CommunityToolkit.Mvvm.ComponentModel;
using Maui.Tutorials.Models;
using System.Collections.ObjectModel;

namespace Maui.Tutorials.ViewModels
{
    public partial class UnicodeViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Unicodes> items;

        public UnicodeViewModel()
        {
            var items = new List<Unicodes>();
            for (int x = 32; x < 16 * 16 * 16 * 16; x += 16) items.Add(new Unicodes(x));
            //for (int x = 32; x < 16 * 16; x += 16) items.Add(new Unicodes(x));

            Items = new ObservableCollection<Unicodes>(items);
        }

    }
}
