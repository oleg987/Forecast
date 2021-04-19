using AutoMapper;
using Forecast.Service.Domain;
using Forecast.Service.Domain.OpenWeather;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast.Service.Mapping
{
    internal class WeatherForecastProfile : Profile
    {
        public WeatherForecastProfile()
        {
            CreateMap<OpenWeatherResponse, WeatherForecast>()
                .ForMember(wf => wf.City, opt => opt.MapFrom(owr => owr.Name))
                .ForMember(wf => wf.Date, opt => opt.MapFrom(owr => DateTimeOffset.FromUnixTimeSeconds(owr.Date).Add(TimeSpan.FromSeconds(owr.Timezone))))
                .ForMember(wf => wf.Humidity, opt => opt.MapFrom(owr => owr.WeatherParams.Humidity))
                .ForMember(wf => wf.MaxTemperature, opt => opt.MapFrom(owr => owr.WeatherParams.TempMax))
                .ForMember(wf => wf.MinTemperature, opt => opt.MapFrom(owr => owr.WeatherParams.TempMin))
                .ForMember(wf => wf.Temperature, opt => opt.MapFrom(owr => owr.WeatherParams.Temp))
                .ForMember(wf => wf.Pressure, opt => opt.MapFrom(owr => owr.WeatherParams.Pressure))
                .ForMember(wf => wf.TemperatureFeelsLike, opt => opt.MapFrom(owr => owr.WeatherParams.FeelsLike))
                .ForMember(wf => wf.Sunrise, opt => opt.MapFrom(owr => DateTimeOffset.FromUnixTimeSeconds(owr.CountryInfo.Sunrise).Add(TimeSpan.FromSeconds(owr.Timezone))))
                .ForMember(wf => wf.Sunset, opt => opt.MapFrom(owr => DateTimeOffset.FromUnixTimeSeconds(owr.CountryInfo.Sunset).Add(TimeSpan.FromSeconds(owr.Timezone))))
                .ForMember(wf => wf.WindSpeed, opt => opt.MapFrom(owr => owr.Wind.Speed))
                .ForMember(wf => wf.WindDirection, opt => opt.MapFrom(owr => owr.Wind.Deg))
                .ForMember(wf => wf.Weather, opt => opt.MapFrom(owr => (string.Concat(owr.Weather.Select(w => w.Main + ", ")).TrimEnd(' ', ','))))
                .ForMember(wf => wf.WeatherDescription, opt => opt.MapFrom(owr => (string.Concat(owr.Weather.Select(w => w.Description + ", ")).TrimEnd(' ', ','))))
                .ForMember(wf => wf.Clouds, opt => opt.MapFrom(owr => owr.Clouds.All));

            
        }
    }
}
