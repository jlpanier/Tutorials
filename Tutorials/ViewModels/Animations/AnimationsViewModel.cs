using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace Tutorials.ViewModels.Animations
{
    public partial class AnimationsViewModel : ObservableObject
    {
        public ICommand NavigateCommand { get; }

        public AnimationsViewModel()
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
