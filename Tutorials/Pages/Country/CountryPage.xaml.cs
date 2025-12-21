using Tutorials.ViewModels;

namespace Tutorials.Pages
{
	public partial class CountryPage : ContentPage
	{
		public CountryPage()
		{
			InitializeComponent();
            BindingContext = new CountryViewModel();
            AppShell.SetNavBarIsVisible(this, false);
        }

        public CountryPage(CountryViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
            AppShell.SetNavBarIsVisible(this, false);
        }

        /// <summary>
        /// customize behavior immediately prior to the page becoming visible.
        /// </summary>
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            if (BindingContext is CountryViewModel vm)
            {
                await vm.Load();
            }
        }

        void OnPickerSelectedCountry(object sender, EventArgs e)
        {
            if (sender is Picker picker && BindingContext is CountryViewModel vm)
            {
                if (picker.SelectedIndex == -1)
                {
                    vm.SelectAll();
                }
                else
                {
                    switch(picker.Items[picker.SelectedIndex])
                    {
                        case "Arab world":
                            vm.SelectArabWorld();
                            break;
                        case "Central Europe and Baltic":
                            vm.CentralEuropeAndBaltic();
                            break;
                        case "East Asia Pacific":
                            vm.EastAsiaPacific();
                            break;
                        case "Europe central Asia":
                            vm.EuropeCentralAsia();
                            break;
                        case "Latin America caribbean":
                            vm.LatinAmericaCaribbean();
                            break;
                        case "Middle East North Africa":
                            vm.MiddleEastNorthAfrica();
                            break;
                        case "North America":
                            vm.NorthAmerica();
                            break;
                        case "Sub Saharan African":
                            vm.SubSaharanAfrican();
                            break;
                        case "Bologne":
                            vm.Bologne();
                            break;
                        case "Euro area":
                            vm.EuroArea();
                            break;
                        case "European union":
                            vm.EuropeanUnion();
                            break;
                        case "OECD members":
                            vm.OedcMembers();
                            break;
                        case "UE27 member":
                            vm.UE27Member();
                            break;
                        case "G7 member":
                            vm.G7Member();
                            break;
                        case "G20 member":
                            vm.G20Member();
                            break;
                        case "High income":
                            vm.HighIncome();
                            break;
                        case "UpperMiddleIncome":
                            vm.UpperMiddleIncome();
                            break;
                        case "Lower middle income":
                            vm.LowerMiddleIncome();
                            break;
                        case "Low income":
                            vm.LowIncome();
                            break;
                        default:
                            vm.SelectAll();
                            break;
                    }
                }
            }
        }

    }
}