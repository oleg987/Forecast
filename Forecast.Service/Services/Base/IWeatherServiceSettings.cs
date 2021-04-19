using System;
using System.Collections.Generic;
using System.Text;

namespace Forecast.Service.Services.Base
{
    public interface IWeatherServiceSettings
    {
        string ApiKey { get; init; }
        string BaseUrl { get; init; }
    }
}
