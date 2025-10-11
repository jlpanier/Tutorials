using Maui.Tutorials.ViewModels;

namespace Maui.Tutorials.Pages
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
    }
}