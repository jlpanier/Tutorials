using DevExpress.Maui.Charts;

namespace Tutorials.ViewModels
{
    public class FinancialChartViewModel
    {
        public StockPrices StockPrices { get; }
        public DateRange VisualRange { get; }

        public FinancialChartViewModel()
        {
            StockPrices = StockData.GetStockPrices();
            VisualRange = new DateRange()
            {
                VisualMin = new System.DateTime(2020, 04, 07),
                VisualMax = new System.DateTime(2020, 07, 07)
            };
        }
    }
}
