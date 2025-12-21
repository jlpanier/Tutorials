using Tutorials.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Tutorials.ViewModels
{
    public class RefreshViewDemoPageViewModel : INotifyPropertyChanged
    {
        const int RefreshDuration = 2;
        int itemNumber = 1;
        readonly Random random;
        bool isRefreshing;

        public bool IsRefreshing
        {
            get { return isRefreshing; }
            set
            {
                isRefreshing = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<RefreshItem> Items { get; private set; }

        public ICommand RefreshCommand => new Command(async () => await RefreshItemsAsync());

        public RefreshViewDemoPageViewModel()
        {
            random = new Random();
            Items = new ObservableCollection<RefreshItem>();
            AddItems();
        }

        void AddItems()
        {
            for (int i = 0; i < 50; i++)
            {
                Items.Add(new RefreshItem
                {
                    Color = Color.FromRgb(random.NextDouble(), random.NextDouble(), random.NextDouble()),
                    Name = $"Item {itemNumber++}"
                });
            }
        }

        async Task RefreshItemsAsync()
        {
            IsRefreshing = true;
            await Task.Delay(TimeSpan.FromSeconds(RefreshDuration));
            AddItems();
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
