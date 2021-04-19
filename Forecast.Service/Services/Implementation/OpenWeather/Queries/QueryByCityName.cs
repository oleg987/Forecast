using Forecast.Service.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast.Service.Services.Implementation.OpenWeather.Queries
{
    public class QueryByCityName : BaseQuery
    {
        /// <summary>
        /// City name.
        /// </summary>
        public string CityName { get; set; }
        /// <summary>
        /// Only for USA.
        /// </summary>
        public string StateCode { get; set; }
        /// <summary>
        /// Country code ISO-3166 Standart.
        /// </summary>
        public string CountryCode { get; set; }        

        public QueryByCityName(
            string cityName,
            string stateCode = null,
            string countryCode = null,
            Units units = Units.metric,
            Langs langs = Langs.en) : base(units, langs)
        {
            CityName = cityName;
            StateCode = stateCode;
            CountryCode = countryCode;
        }

        public override string GetQueryString()
        {
            var query = $"q={CityName}";

            if (!string.IsNullOrEmpty(StateCode))
            {
                query += $",{StateCode}";
            }

            if (!string.IsNullOrEmpty(CountryCode))
            {
                query += $",{CountryCode}";
            }

            query += base.GetQueryString();

            return query;
        }
    }
}
