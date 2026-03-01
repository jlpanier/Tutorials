using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace Tutorials.ViewModels
{
    public partial class GalleryViewModel : ObservableObject
    {
        public ICommand NavigateCommand { get; }

        public GalleryViewModel()
        {
            NavigateCommand = new Command<Type>(OnNavigate);
        }

        private async void OnNavigate(Type pageType)
        {
            if (pageType == null) return;

            if (Activator.CreateInstance(pageType) is Page page)
            {
                await Shell.Current.Navigation.PushAsync(page);
            }
        }
    }
}
