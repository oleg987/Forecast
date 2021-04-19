using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast.Service.Services.Implementation.OpenWeather.Queries
{
    public class QueryByCityId : BaseQuery
    {
        public int CityId { get; set; }

        public QueryByCityId(int cityId, Units units = Units.metric, Langs langs = Langs.en) : base(units, langs)
        {
            CityId = cityId;
        }

        public override string GetQueryString()
        {
            return $"id={CityId}&" + base.GetQueryString();
        }
    }
}
