using Newtonsoft.Json;
using System;

namespace Forecast.Service.Domain.OpenWeather
{
    public class CountryInfo
    {
        [JsonConstructor]
        public CountryInfo(
            [JsonProperty("country")] string country,
            [JsonProperty("sunrise")] int sunrise,
            [JsonProperty("sunset")] int sunset
        )
        {
            this.Country = country;
            this.Sunrise = sunrise;
            this.Sunset = sunset;
        }

        [JsonProperty("country")]
        public string Country { get; }

        [JsonProperty("sunrise")]
        public int Sunrise { get; }

        [JsonProperty("sunset")]
        public int Sunset { get; }
    }


}
