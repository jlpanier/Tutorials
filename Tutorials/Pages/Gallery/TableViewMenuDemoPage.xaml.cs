using System.Windows.Input;
using Tutorials.ViewModels;

namespace Tutorials.Pages;

public partial class TableViewMenuDemoPage : ContentPage
{
    public TableViewMenuDemoPage()
    {
        InitializeComponent();
        BindingContext = new TableViewMenuDemoViewModel();
     }

}