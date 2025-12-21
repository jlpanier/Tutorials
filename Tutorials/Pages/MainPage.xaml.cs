using System.Windows.Input;

namespace Tutorials.Pages
{
    public partial class MainPage : ContentPage
    {
        public ICommand NavigateCommand { get; private set; }

        public MainPage()
        {
            InitializeComponent();

            NavigateCommand = new Command<Type>(
                async (Type pageType) =>
                {
                    var objectPage = Activator.CreateInstance(pageType);
                    if (objectPage is Page page)
                    {
                        await Navigation.PushAsync(page);
                    }
                });

            BindingContext = this;
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