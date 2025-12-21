using DevExpress.Maui.Charts;
using Tutorials.ViewModels;

namespace Tutorials.Pages;

public partial class BarSummaryOnSelection : ContentPage
{

    BarSummaryOnSelectionViewModel viewModel;

    public BarSummaryOnSelection()
	{
		InitializeComponent();

        this.BindingContext = viewModel = new BarSummaryOnSelectionViewModel();
    }

    private void ChartView_SelectionChanged(object sender, DevExpress.Maui.Charts.SelectionChangedEventArgs e)
    {
        if (e.SelectedObjects.Count > 0)
        {
            viewModel.SelectedDataItem = (ComponentReplyInfo)((DataSourceKey)e.SelectedObjects[0]).DataObject;
        }
        else
        {
            viewModel.SelectedDataItem = null;
        }
    }
}