using CommunityToolkit.Mvvm.ComponentModel;
using Tutorials.Models;
using System.Collections.ObjectModel;

namespace Tutorials.ViewModels
{
    public partial class CountryViewModel : ObservableObject
    {
        private List<Country> _countries = new List<Country>();

        [ObservableProperty]
        string nbr;

        [ObservableProperty]
        ObservableCollection<Country> items;

        public CountryViewModel()
        {
            Items = new ObservableCollection<Country>();
            Nbr = string.Empty;
        }

        public async Task Load()
        {
            _countries = await Country.Get();
            SelectAll();
        }

        public void SelectAll()
        {
            Items = new ObservableCollection<Country>(_countries.OrderBy(_ => _.Name));
            Nbr = $"({Items.Count()})";
        }

        public void SelectArabWorld()
        {
            Items = new ObservableCollection<Country>(_countries.Where(_=>_.Arab).OrderBy(_ => _.Name));
            Nbr = $"({Items.Count()})";
        }

        public void CentralEuropeAndBaltic()
        {
            Items = new ObservableCollection<Country>(_countries.Where(_ => _.EuroAndAsiaCentral).OrderBy(_ => _.Name));
            Nbr = $"({Items.Count()})";
        }

        public void EastAsiaPacific()
        {
            Items = new ObservableCollection<Country>(_countries.Where(_ => _.EastAsia).OrderBy(_ => _.Name));
            Nbr = $"({Items.Count()})";
        }

        public void EuroArea()
        {
            Items = new ObservableCollection<Country>(_countries.Where(_ => _.Euro).OrderBy(_ => _.Name));
            Nbr = $"({Items.Count()})";
        }

        public void EuropeCentralAsia()
        {
            Items = new ObservableCollection<Country>(_countries.Where(_ => _.CentralEurope).OrderBy(_ => _.Name));
            Nbr = $"({Items.Count()})";
        }

        public void EuropeanUnion()
        {
            Items = new ObservableCollection<Country>(_countries.Where(_ => _.EuropeUnion).OrderBy(_ => _.Name));
            Nbr = $"({Items.Count()})";
        }

        public void HighIncome()
        {
            Items = new ObservableCollection<Country>(_countries.Where(_ => _.HighIncome).OrderBy(_ => _.Name));
            Nbr = $"({Items.Count()})";
        }

        public void LatinAmericaCaribbean()
        {
            Items = new ObservableCollection<Country>(_countries.Where(_ => _.LatinAmericaCarribean).OrderBy(_ => _.Name));
            Nbr = $"({Items.Count()})";
        }

        public void LowIncome()
        {
            Items = new ObservableCollection<Country>(_countries.Where(_ => _.LowIncome).OrderBy(_ => _.Name));
            Nbr = $"({Items.Count()})";
        }

        public void LowerMiddleIncome()
        {
            Items = new ObservableCollection<Country>(_countries.Where(_ => _.LowMiddleIncome).OrderBy(_ => _.Name));
            Nbr = $"({Items.Count()})";
        }

        public void MiddleEastNorthAfrica()
        {
            Items = new ObservableCollection<Country>(_countries.Where(_ => _.MiddleEastNorthAfrica).OrderBy(_ => _.Name));
            Nbr = $"({Items.Count()})";
        }

        public void NorthAmerica()
        {
            Items = new ObservableCollection<Country>(_countries.Where(_ => _.NorthAmerica).OrderBy(_ => _.Name));
            Nbr = $"({Items.Count()})";
        }

        public void OedcMembers()
        {
            Items = new ObservableCollection<Country>(_countries.Where(_ => _.OecdMembers).OrderBy(_ => _.Name));
            Nbr = $"({Items.Count()})";
        }

        public void SubSaharanAfrican()
        {
            Items = new ObservableCollection<Country>(_countries.Where(_ => _.sub_saharan_africa).OrderBy(_ => _.Name));
            Nbr = $"({Items.Count()})";
        }

        public void UpperMiddleIncome()
        {
            Items = new ObservableCollection<Country>(_countries.Where(_ => _.upper_middle_income).OrderBy(_ => _.Name));
            Nbr = $"({Items.Count()})";
        }

        public void Bologne()
        {
            Items = new ObservableCollection<Country>(_countries.Where(_ => _.Bologne).OrderBy(_ => _.Name));
            Nbr = $"({Items.Count()})";
        }

        public void UE27Member()
        {
            Items = new ObservableCollection<Country>(_countries.Where(_ => _.ue27).OrderBy(_ => _.Name));
            Nbr = $"({Items.Count()})";
        }

        public void G7Member()
        {
            Items = new ObservableCollection<Country>(_countries.Where(_ => _.G7).OrderBy(_ => _.Name));
            Nbr = $"({Items.Count()})";
        }

        public void G20Member()
        {
            Items = new ObservableCollection<Country>(_countries.Where(_ => _.G20   ).OrderBy(_ => _.Name));
            Nbr = $"({Items.Count()})";
        }
    }
}
