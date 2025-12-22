using DevExpress.Maui.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials.ViewModels
{

    public class IndexBasedCustomPointColorizerViewModel
    {
        CountryStatisticsData data = new CountryStatisticsData();
        public List<CountryStatistics> CountryStatisticsData => this.data.SeriesData;
    }

    public class IndexBasedCustomPointCountryStatisticsData
    {
        readonly List<IndexBasedCustomPointCountryStatistics> data = new List<IndexBasedCustomPointCountryStatistics> {
            new IndexBasedCustomPointCountryStatistics("Argentina", 16011.6728032264, "America"),
            new IndexBasedCustomPointCountryStatistics("Australia", 38159.6336533223, "Australia"),
            new IndexBasedCustomPointCountryStatistics("Brazil", 11210.3908053823, "America"),
            new IndexBasedCustomPointCountryStatistics("Canada", 39050.1673163719, "America"),
            new IndexBasedCustomPointCountryStatistics("China", 7599, "Asia"),
            new IndexBasedCustomPointCountryStatistics("France", 34123.1966249035, "Europe"),
            new IndexBasedCustomPointCountryStatistics("Germany", 37402.2677660974, "Europe"),
            new IndexBasedCustomPointCountryStatistics("India", 3425.4489267524, "Asia"),
            new IndexBasedCustomPointCountryStatistics("Indonesia", 4325.2533282173, "Asia"),
            new IndexBasedCustomPointCountryStatistics("Italy", 31954.1751781228, "Europe"),
            new IndexBasedCustomPointCountryStatistics("Japan", 33732.8682226596, "Asia"),
            new IndexBasedCustomPointCountryStatistics("Mexico", 14563.884253986, "America"),
            new IndexBasedCustomPointCountryStatistics("Russia", 19891.3528339013, "Europe"),
            new IndexBasedCustomPointCountryStatistics("Saudi Arabia", 22713.4852913284, "Asia"),
            new IndexBasedCustomPointCountryStatistics("South Africa", 10565.1840563081, "Africa"),
            new IndexBasedCustomPointCountryStatistics("South Korea", 29101.0711400706, "Asia"),
            new IndexBasedCustomPointCountryStatistics("Turkey", 15686.860167575, "Africa"),
            new IndexBasedCustomPointCountryStatistics("United Kingdom", 35686.1997705521, "Europe"),
            new IndexBasedCustomPointCountryStatistics("Spain", 32230.3585974199, "Europe"),
            new IndexBasedCustomPointCountryStatistics("USA", 47153.0094273427, "America"),
        };
        public List<IndexBasedCustomPointCountryStatistics> SeriesData => this.data;
    }

    public class IndexBasedCustomPointCountryStatistics
    {
        public string Country { get; private set; }
        public double Gdp { get; private set; }
        public string Region { get; private set; }

        public IndexBasedCustomPointCountryStatistics(string country, double gdp, string region)
        {
            Country = country;
            Gdp = gdp;
            Region = region;
        }
    }

    public class IndexBasedCustomPointColorizerByRegion : IIndexBasedCustomPointColorizer, ILegendItemProvider
    {
        private IndexBasedCustomPointCountryStatisticsData data = new IndexBasedCustomPointCountryStatisticsData();
        private Dictionary<string, Color> colors = new Dictionary<string, Color> {
            {"Africa", Color.FromArgb("5b9bd5")},
            {"America",  Color.FromArgb("ed7d31")},
            {"Asia", Color.FromArgb("a5a5a5")},
            {"Australia", Color.FromArgb("ffc000")},
            {"Europe", Color.FromArgb("4472c4")}
        };
        private List<string> regions = new List<string> {
            "Africa", "America", "Asia", "Australia", "Europe"
        };

        public Color GetColor(int index)
        {
            return colors[data.SeriesData[index].Region];
        }

        public CustomLegendItem GetLegendItem(int index)
        {
            return new CustomLegendItem(regions[index], colors[regions[index]]);
        }

        public int GetLegendItemCount()
        {
            return regions.Count;
        }

        public ILegendItemProvider GetLegendItemProvider()
        {
            return this;
        }
    }
}
