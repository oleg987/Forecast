using System;
using System.Linq;
using Forecast.Service.Services.Base;
using Forecast.Service.Services.Implementation.OpenWeather;
using Forecast.Service.Services.Implementation.OpenWeather.Queries;

namespace Forecast.CLI
{
    class Program
    {
        public static string key = "c16337ebad8860ce112d59b2d00ff139";
        public static string url = @"http://api.openweathermap.org/data/2.5/weather?";

        public enum City
        {
            Odessa = 698740,
            Chornomorsk = 707688,
            Kyiv = 703448,
            Amsterdam = 2759794,
            London = 2643743,
            Berlin = 2950159,
            Costa_Rica = 3465303
        }

        static void Main(string[] args)
        {
            IWeatherServiceSettings settings = new OpenWeatherSettings(key, url);
            IWeatherService service = new OpenWeatherService(settings);

            // View Component

            var cities = Enum.GetValues(typeof(City)).Cast<City>().ToArray();

            while (true)
            {
                Console.WriteLine("Select city:");

                for (int i = 0; i < cities.Length; i++)
                {
                    Console.WriteLine($"{i+1}. {cities[i]}");
                }

                Console.Write("Enter city number: ");

                if (!int.TryParse(Console.ReadLine(), out int cityNumber) || (cityNumber - 1) < 0 || (cityNumber - 1) >= cities.Length)
                {
                    Console.Clear();
                    Console.WriteLine("Wrong city number. Enter one more time.");
                    continue;
                }

                var city = cities[cityNumber - 1];

                var query = new QueryByCityId((int)city);

                //var query = new QueryByCityName("London");

                var weather = service.GetForecast(query);

                Console.Clear();

                WeatherForecastConsolePresenter.Show(weather);
                
                Console.WriteLine("\nOne more time? \"Y\" - yes, other input or empty string - no.");

                var input = Console.ReadLine();

                if (input.ToLower() == "y")
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
