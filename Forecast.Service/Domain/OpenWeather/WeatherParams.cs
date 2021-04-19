using Newtonsoft.Json;

namespace Forecast.Service.Domain.OpenWeather
{
    public class WeatherParams
    {
        [JsonConstructor]
        public WeatherParams(
            [JsonProperty("temp")] double temp,
            [JsonProperty("feels_like")] double feelsLike,
            [JsonProperty("temp_min")] double tempMin,
            [JsonProperty("temp_max")] double tempMax,
            [JsonProperty("pressure")] int pressure,
            [JsonProperty("humidity")] int humidity
        )
        {
            this.Temp = temp;
            this.FeelsLike = feelsLike;
            this.TempMin = tempMin;
            this.TempMax = tempMax;
            this.Pressure = pressure;
            this.Humidity = humidity;
        }

        [JsonProperty("temp")]
        public double Temp { get; }

        [JsonProperty("feels_like")]
        public double FeelsLike { get; }

        [JsonProperty("temp_min")]
        public double TempMin { get; }

        [JsonProperty("temp_max")]
        public double TempMax { get; }

        [JsonProperty("pressure")]
        public int Pressure { get; }

        [JsonProperty("humidity")]
        public int Humidity { get; }
    }


}
