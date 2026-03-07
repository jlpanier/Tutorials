using CommunityToolkit.Maui.Converters;
using System.Reflection;

namespace Tutorials.Pages;

public partial class PickerDemoPage : ContentPage
{
	public PickerDemoPage()
	{
		InitializeComponent();
	}

    void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        Picker picker = (Picker)sender;

        if (picker.SelectedIndex == -1)
        {
            boxView.Color = Colors.Black;
        }
        else
        {
            string colorName = picker.Items[picker.SelectedIndex];
            FieldInfo? colorField = typeof(Colors).GetRuntimeField(colorName);
            if (colorField!=null && colorField.GetValue(null) is Color color)
            {
                boxView.Color = color;
            }
        }
    }
}