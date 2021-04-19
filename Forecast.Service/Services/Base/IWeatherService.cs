using Forecast.Service.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forecast.Service.Services.Base
{
    public interface IWeatherService
    {
        WeatherForecast GetForecast(IWeatherQuery query);
    }
}
