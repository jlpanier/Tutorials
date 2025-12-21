using CommunityToolkit.Mvvm.ComponentModel;
using Tutorials.ViewModels;

namespace Tutorials.Pages;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}