namespace Tutorials.Pages.Popup;

public partial class ButtonPopup : CommunityToolkit.Maui.Views.Popup
{
    private readonly Action<object> OnClosing;

    public ButtonPopup(Action<object> onClosing)
    {
        InitializeComponent();
        OnClosing = onClosing;
    }

    private async void Button_Clicked(object? sender, EventArgs e)
    {
        OnClosing.Invoke("Ok");
        await CloseAsync();
    }

    private void OnOpened(object sender, EventArgs e)
    {
        // Do something else
    }

    private void OnClosed(object sender, EventArgs e)
    {
        // Do something else
    }
}