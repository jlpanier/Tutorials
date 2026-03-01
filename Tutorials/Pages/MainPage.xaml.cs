using Tutorials.ViewModels;

namespace Tutorials.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

        /// <summary>
        /// customize behavior immediately prior to the page becoming visible.
        /// </summary>
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Tutorials.Instance.Init();
        }
    }
}