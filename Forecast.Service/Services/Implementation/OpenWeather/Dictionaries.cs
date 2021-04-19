using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast.Service.Services.Implementation.OpenWeather
{
    /// <summary>
    /// Units for temperature and wind speed.
    /// </summary>
    public enum Units
    {
        /// <summary>
        /// Temperature: Kelvin, wind speed: meters/second.
        /// </summary>
        standart,
        /// <summary>
        /// Temperature: Celsius, wind speed: meters/second.
        /// </summary>
        metric,
        /// <summary>
        /// Temperature: Fahrenheit, wind speed: miles/hour.
        /// </summary>
        imperial
    }

    /// <summary>
    /// Available languages.
    /// </summary>
    public enum Langs
    {
        /// <summary>
        /// Russian.
        /// </summary>
        ru,
        /// <summary>
        /// Ukrainian.
        /// </summary>
        ua,
        /// <summary>
        /// English.
        /// </summary>
        en,
        /// <summary>
        /// German.
        /// </summary>
        de,
        /// <summary>
        /// French.
        /// </summary>
        fr,
        /// <summary>
        /// Italian.
        /// </summary>
        it,
    }
}
