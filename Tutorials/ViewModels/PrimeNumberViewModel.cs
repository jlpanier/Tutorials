using ExCSS;
using Tutorials.Models;
using Repository.Dbo;
using Repository.Entities;
using Syncfusion.Maui.DataSource.Extensions;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Tutorials.ViewModels
{
    public class PrimeNumberViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

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

        public ObservableCollection<Models.Number> Items 
        { 
            get => _items; 
            private set
            {
                _items = value;
                OnPropertyChanged();
            }
        }
        ObservableCollection<Models.Number>? _items;

        private string _textColor = "Green";
        public string TextColor
        {
            get { return _textColor; }
            set
            {
                _textColor = value;
                OnPropertyChanged();

            }
        }

        public ICommand RefreshCommand => new Command(async () => await RefreshAsync());

        public PrimeNumberViewModel()
        {
            Items = new ObservableCollection<Models.Number>();
        }

        public void Start()
        {
            var worker = new BackgroundWorker();
            worker.DoWork += OnWork;
            worker.RunWorkerCompleted += OnCompleted;  
            worker.RunWorkerAsync();
        }

        private void OnWork(object? sender, DoWorkEventArgs e)
        {
            try
            {
                e.Result = PrimeNumbers.Instance.Get();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void OnCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is List<Models.Number> data)
            {
                Items = new ObservableCollection<Models.Number>(data.Where(_ => _.Value < 100));
            }
        }

        public async Task RefreshAsync()
        {
            if (IsRefreshing) return;

            IsRefreshing = true;
            await Task.Delay(TimeSpan.FromMilliseconds(1));
            if (PrimeNumbers.Instance.Primes.Count == Items.Count)
            {
                PrimeNumbers.Instance.Next();
            }
            int maxvalue = Items.Max(_ => _.Value);
            Items = new ObservableCollection<Models.Number>(PrimeNumbers.Instance.Primes.Where(_ => _.Value < maxvalue+50));
            IsRefreshing = false;
        }

    }

}
