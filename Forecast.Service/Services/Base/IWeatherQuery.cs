using System;
using System.Collections.Generic;
using System.Text;

namespace Forecast.Service.Services.Base
{
    public interface IWeatherQuery
    {
        string GetQueryString();
    }
}
