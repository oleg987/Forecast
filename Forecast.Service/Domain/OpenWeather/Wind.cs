using Newtonsoft.Json;

namespace Forecast.Service.Domain.OpenWeather
{
    public class Wind
    {
        [JsonConstructor]
        public Wind(
            [JsonProperty("speed")] double speed,
            [JsonProperty("deg")] int deg
        )
        {
            this.Speed = speed;
            this.Deg = deg;
        }

        [JsonProperty("speed")]
        public double Speed { get; }

        [JsonProperty("deg")]
        public int Deg { get; }
    }


}
