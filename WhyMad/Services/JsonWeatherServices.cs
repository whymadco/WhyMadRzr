using System.Net;
using System.Net.Http;
using System.Text.Json;
using WhyMad.Models;

namespace WhyMad.Services
{
    public class JsonWeatherServices
    {
        public WeatherModel GetWeatherModel(string region)
        {
            string url = string.Concat("https://weatherdbi.herokuapp.com/data/weather/", region);
            //var json = new HttpClient()
            var json = new WebClient().DownloadString(url);
            return JsonSerializer.Deserialize<WeatherModel>(json);
        }
    }
}