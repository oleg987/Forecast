using System;
using System.Collections.Generic;
using System.Text;

namespace Forecast.Service.Domain
{
    public class WeatherForecast
    {
        public string City { get; set; }
        public DateTimeOffset Date { get; set; }
        public double Temperature { get; set; }
        public double MinTemperature { get; set; }
        public double MaxTemperature { get; set; }
        public double TemperatureFeelsLike { get; set; }
        public string Weather { get; set; }
        public string WeatherDescription { get; set; }
        public double WindSpeed { get; set; }
        public int WindDirection { get; set; }
        public DateTimeOffset Sunset { get; set; }
        public DateTimeOffset Sunrise { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public int Clouds { get; set; }
    }
}
