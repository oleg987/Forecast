using Forecast.Service.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast.CLI
{
    internal static class WeatherForecastConsolePresenter
    {
        public static void Show(WeatherForecast forecast)
        {
            var presentation = 
                $"Forecast:\n" +
                $"{forecast.City} {forecast.Date.ToString("d")}\n" +
                $"{forecast.Weather}\n" +
                $"{forecast.WeatherDescription}\n" +
                $"Temperature: {forecast.MinTemperature} - {forecast.MaxTemperature}, Now: {forecast.Temperature}, Feels like: {forecast.TemperatureFeelsLike}\n" +
                $"Wind Speed: {forecast.WindSpeed}, Direction: {forecast.WindDirection}\n" +
                $"Pressure: {forecast.Pressure}\n" +
                $"Humidity: {forecast.Humidity}\n" +
                $"Sunrise: {forecast.Sunrise.ToString("T")}; Sunset: {forecast.Sunset.ToString("T")}";

            Console.WriteLine(presentation);
        }
    }
}
