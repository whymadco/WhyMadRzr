using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhyMad.Models;
using WhyMad.Services;

namespace WhyMad.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {   

        }
        [BindProperty]
        public string wind { get; set; }
        [BindProperty]
        public string region{ get; set; }
        [BindProperty]
        public string time { get; set; }
        [BindProperty]
        public string humidity { get; set; }
        [BindProperty]
        public string iconsrc { get; set; }
        [BindProperty]
        public string celcius { get; set; }
        [BindProperty]
        public string expression { get; set; }

        WeatherModel weatherModel;
        JsonWeatherServices jsonWeatherService;

        public void OnPost(JsonWeatherServices jsonWeatherService)
        {
            weatherModel = jsonWeatherService.GetWeatherModel(region);
            wind = weatherModel.currentConditions.wind.km.ToString();
            region = weatherModel.region;
            time = DateTime.Now.Hour.ToString();
            humidity = weatherModel.currentConditions.humidity.ToString();
            iconsrc = weatherModel.currentConditions.iconURL.ToString();
            celcius = weatherModel.currentConditions.temp.c.ToString();
            expression = weatherModel.currentConditions.comment.ToString();
        }


    }
}
