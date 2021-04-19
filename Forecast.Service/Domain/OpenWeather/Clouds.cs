using Newtonsoft.Json;

namespace Forecast.Service.Domain.OpenWeather
{
    public class Clouds
    {
        [JsonConstructor]
        public Clouds(
            [JsonProperty("all")] int all
        )
        {
            this.All = all;
        }

        [JsonProperty("all")]
        public int All { get; }
    }


}
