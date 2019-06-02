using System.Collections.Generic;
using vuemer.web.Models;

namespace vuemer.web.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}
