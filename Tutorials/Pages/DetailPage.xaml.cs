using CommunityToolkit.Mvvm.ComponentModel;
using Maui.Tutorials.ViewModels;

namespace Maui.Tutorials.Pages;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}