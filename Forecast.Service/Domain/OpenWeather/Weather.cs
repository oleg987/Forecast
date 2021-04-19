using Newtonsoft.Json;

namespace Forecast.Service.Domain.OpenWeather
{
    public class Weather
    {
        [JsonConstructor]
        public Weather(
            [JsonProperty("id")] int id,
            [JsonProperty("main")] string main,
            [JsonProperty("description")] string description
        )
        {
            this.Id = id;
            this.Main = main;
            this.Description = description;
        }

        [JsonProperty("id")]
        public int Id { get; }

        [JsonProperty("main")]
        public string Main { get; }

        [JsonProperty("description")]
        public string Description { get; }
    }


}
