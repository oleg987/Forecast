using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast.Service.Services.Implementation.OpenWeather.Queries
{
    public class QueryByCoordinates : BaseQuery
    {
        public double Lon { get; set; }
        public double Lat { get; set; }

        public QueryByCoordinates(double lon, double lat, Units units = Units.metric, Langs langs = Langs.en) : base(units, langs)
        {
            Lon = lon;
            Lat = lat;
        }

        public override string GetQueryString()
        {
            return $"lat={Lon}&lon={Lat}&" + base.GetQueryString();
        }
    }
}
