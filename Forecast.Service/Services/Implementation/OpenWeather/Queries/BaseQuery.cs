using Forecast.Service.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast.Service.Services.Implementation.OpenWeather.Queries
{
    public abstract class BaseQuery : IWeatherQuery
    {
        public Units Units { get; set; }
        public Langs Langs { get; set; }

        protected BaseQuery(Units units = Units.metric, Langs langs = Langs.en)
        {
            Units = units;
            Langs = langs;
        }

        public virtual string GetQueryString()
        {
            return $"&units={Units}&lang={Langs}&appid=";
        }
    }
}
