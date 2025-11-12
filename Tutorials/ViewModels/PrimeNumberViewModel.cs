using CommunityToolkit.Mvvm.ComponentModel;
using Maui.Tutorials.Models;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Maui.Tutorials.ViewModels
{
    public class PrimeNumberViewModel : INotifyPropertyChanged
    {
        public bool IsRefreshing
        {
            get { return isRefreshing; }
            set
            {
                if (isRefreshing != value)
                {
                    isRefreshing = value;
                    OnPropertyChanged();
                }
            }
        }
        bool isRefreshing;

        public ObservableCollection<PrimeNumber> Items 
        { 
            get => _items; 
            private set
            {
                _items = value;
                OnPropertyChanged();
            }
        }
        ObservableCollection<PrimeNumber> _items;

        public ICommand RefreshCommand => new Command(async () => await RefreshAsync());

        public PrimeNumberViewModel()
        {
            Items = new ObservableCollection<PrimeNumber>(PrimeNumbers.Instance.Get(15));
        }

        public void Refresh()
        {
            var maxvalue = Items.Max(_ => _.Number);
            var items = PrimeNumbers.Instance.Get(maxvalue + 50);
            Items = new ObservableCollection<PrimeNumber>(items);
        }

        public async Task RefreshAsync()
        {
            IsRefreshing = true;
            await Task.Delay(TimeSpan.FromSeconds(2));
            var maxvalue = Items.Max(_ => _.Number);
            var items = PrimeNumbers.Instance.Get(maxvalue + 128);
            Items = new ObservableCollection<PrimeNumber>(items);
            IsRefreshing = false;
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }

}
