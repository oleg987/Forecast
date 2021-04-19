using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast.Service.Domain.OpenWeather
{

    public class OpenWeatherResponse
    {
        [JsonConstructor]
        public OpenWeatherResponse(
            [JsonProperty("coord")] Coordinates coord,
            [JsonProperty("weather")] List<Weather> weather,
            [JsonProperty("main")] WeatherParams main,
            [JsonProperty("visibility")] int visibility,
            [JsonProperty("wind")] Wind wind,
            [JsonProperty("clouds")] Clouds clouds,
            [JsonProperty("dt")] int dt,
            [JsonProperty("sys")] CountryInfo sys,
            [JsonProperty("timezone")] int timezone,
            [JsonProperty("id")] int id,
            [JsonProperty("name")] string name
        )
        {
            this.Coordinates = coord;
            this.Weather = weather;
            this.WeatherParams = main;
            this.Visibility = visibility;
            this.Wind = wind;
            this.Clouds = clouds;
            this.Date = dt;
            this.CountryInfo = sys;
            this.Timezone = timezone;
            this.Id = id;
            this.Name = name;
        }

        [JsonProperty("coord")]
        public Coordinates Coordinates { get; }

        [JsonProperty("weather")]
        public IReadOnlyList<Weather> Weather { get; }

        [JsonProperty("main")]
        public WeatherParams WeatherParams { get; }

        [JsonProperty("visibility")]
        public int Visibility { get; }

        [JsonProperty("wind")]
        public Wind Wind { get; }

        [JsonProperty("clouds")]
        public Clouds Clouds { get; }

        [JsonProperty("dt")]
        public int Date { get; }

        [JsonProperty("sys")]
        public CountryInfo CountryInfo { get; }

        [JsonProperty("timezone")]
        public int Timezone { get; }

        [JsonProperty("id")]
        public int Id { get; }

        [JsonProperty("name")]
        public string Name { get; }
    }


}
