using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static System.Net.Mime.MediaTypeNames;

namespace Tutorials.ViewModels
{
    public partial class MainViewModel: ObservableObject
    {
        public ICommand NavigateCommand { get; }

        public MainViewModel()
        {
            NavigateCommand = new Command<Type>(OnNavigate);
        }

        private async void OnNavigate(Type pageType)
        {
            if (pageType == null) return;

            // Instanciation dynamique de la page
            var page = (Page)Activator.CreateInstance(pageType);

            // Navigation
            await Shell.Current.Navigation.PushAsync(page);
        }

    }
}
