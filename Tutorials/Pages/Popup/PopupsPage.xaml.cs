using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Extensions;
using CommunityToolkit.Maui.Services;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls.Shapes;
using Tutorials.Pages.Base;
using Tutorials.Pages.Popup;
using Tutorials.ViewModels;

namespace Tutorials.Pages;

public partial class PopupsPage : ContentPage
{
    //readonly IPopupService PopupService;

    public PopupsPage()
    {
        InitializeComponent();
        BindingContext = new PopupsViewModel();
    }

    private async void HandleSimplePopupButtonClicked(object sender, EventArgs e)
    {
        var queryAttributes = new Dictionary<string, object>
        {
            ["DescriptionLabel"] = "This is a popup where this text is being passed in using IQueryAttributable"
        };

        await this.ShowPopupAsync(new ButtonPopup(OnClosed));
    }

    private void OnClosed(object data)
    {
        // Do something else
    }
}
