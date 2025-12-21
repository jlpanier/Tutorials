using Tutorials.ViewModels;

namespace Tutorials.Pages;

public partial class PrimeNumberPage : ContentPage
{
    public PrimeNumberPage()
    {
        InitializeComponent();
        BindingContext = new PrimeNumberViewModel();
        AppShell.SetNavBarIsVisible(this, false);
    }

    public PrimeNumberPage(PrimeNumberViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
        AppShell.SetNavBarIsVisible(this, false);
    }

    /// <summary>
    /// customize behavior immediately prior to the page becoming visible.
    /// </summary>
    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (BindingContext is PrimeNumberViewModel vm)
        {
            vm.Start();
        }
    }

    private void OnScrollViewScrolled(object sender, ScrolledEventArgs e) 
    {

          if (!(sender is ScrollView scrollView)) return;

          var scrollSpace =  scrollView.ContentSize.Height - scrollView.Height;

          if (scrollSpace > e.ScrollY) return;


        //load more items when coming to the end of the list of ScrollView 

        if (BindingContext is PrimeNumberViewModel vm)
        {
            Task.Run(async () =>
            {
                await vm.RefreshAsync();
            });
        }
    }
}