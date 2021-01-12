using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weatherForecastAppPOE
{
    public class ForecastData
    {
        public string cityName { get; set; }
        public DateTime forecastDate {get; set;}
        public double minTemp { get; set; }
        public double maxTemp { get; set; }
        public double precipitation { get; set; }
        public double humidity { get; set; }
        public double windSpeed { get; set; }
    }
}
