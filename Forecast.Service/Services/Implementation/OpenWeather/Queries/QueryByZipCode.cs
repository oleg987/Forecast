using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast.Service.Services.Implementation.OpenWeather.Queries
{
    public class QueryByZipCode : BaseQuery
    {
        public int ZipCode { get; set; }
        /// <summary>
        /// If country code not specified search in USA by default.
        /// </summary>
        public string CountryCode { get; set; }

        public QueryByZipCode(int zipCode, string countryCode, Units units = Units.metric, Langs langs = Langs.en) : base(units, langs)
        {
            ZipCode = zipCode;
            CountryCode = countryCode;
        }

        public override string GetQueryString()
        {
            return $"zip={ZipCode},{CountryCode}" + base.GetQueryString();
        }
    }
}
