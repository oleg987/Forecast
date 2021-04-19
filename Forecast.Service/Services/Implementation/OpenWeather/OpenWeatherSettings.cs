using Forecast.Service.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forecast.Service.Services.Implementation.OpenWeather
{
    public class OpenWeatherSettings : IWeatherServiceSettings
    {
        public string ApiKey { get; init; }
        public string BaseUrl { get; init; }

        public OpenWeatherSettings(string apiKey, string baseUrl)
        {
            ApiKey = apiKey;
            BaseUrl = baseUrl;
        }
    }
}
