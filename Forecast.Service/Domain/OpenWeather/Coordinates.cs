using Newtonsoft.Json;

namespace Forecast.Service.Domain.OpenWeather
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Coordinates
    {
        [JsonConstructor]
        public Coordinates(
            [JsonProperty("lon")] double lon,
            [JsonProperty("lat")] double lat
        )
        {
            this.Lon = lon;
            this.Lat = lat;
        }

        [JsonProperty("lon")]
        public double Lon { get; }

        [JsonProperty("lat")]
        public double Lat { get; }
    }


}
