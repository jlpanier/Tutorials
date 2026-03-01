using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;


namespace Tutorials.ViewModels
{

    public partial class MainViewModel: ObservableObject
    {
        readonly IServiceProvider _services;
        public ICommand NavigateCommand { get; }

        public MainViewModel(IServiceProvider services)
        {
            _services = services;
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
