using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Tutorials.Data
{
    [XmlRoot(ElementName = "StockPrices")]
    public class StockPrices : List<StockPrice> { }

    public class StockPrice
    {
        public DateTime Date { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Open { get; set; }
        public double Close { get; set; }
        public double Volume { get; set; }
    }

    public class StockData
    {
        public static StockPrices GetStockPrices()
        {
            StockPrices stockPrices;
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("GoogleStock"))
            {
                var serializer = new XmlSerializer(typeof(StockPrices));
                stockPrices = (StockPrices)serializer.Deserialize(stream);
            }
            return stockPrices;
        }
    }
}
