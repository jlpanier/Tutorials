namespace Tutorials.Pages;

public partial class RadioButtonDemoPage : ContentPage
{
	public RadioButtonDemoPage()
	{
		InitializeComponent();
	}

    void OnColorsRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (sender is RadioButton button)
        {
            colorLabel.Text = $"You have chosen: {button.Content}";
        }
    }

    void OnFruitsRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (sender is RadioButton button)
        {
            fruitLabel.Text = $"You have chosen: {button.Content}";
        }
    }
}