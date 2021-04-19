using AutoMapper;
using Forecast.Service.Domain;
using Forecast.Service.Domain.OpenWeather;
using Forecast.Service.Mapping;
using Forecast.Service.Services.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Forecast.Service.Services.Implementation.OpenWeather
{
    public class OpenWeatherService : IWeatherService
    {
        private readonly HttpClient _client;
        private readonly IWeatherServiceSettings _settings;
        private readonly IMapper _mapper;

        public OpenWeatherService(IWeatherServiceSettings settings)
        {
            _client = new HttpClient();
            _settings = settings;
            _mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile(new WeatherForecastProfile())));
        }

        public WeatherForecast GetForecast(IWeatherQuery query)
        {
            var response = _client.GetAsync(_settings.BaseUrl + query.GetQueryString() + _settings.ApiKey).Result;

            if (response.IsSuccessStatusCode)
            {
                return _mapper.Map<WeatherForecast>(JsonConvert.DeserializeObject<OpenWeatherResponse>(response.Content.ReadAsStringAsync().Result));
            }
            else
            {
                return null;
            }
        }
    }
}
