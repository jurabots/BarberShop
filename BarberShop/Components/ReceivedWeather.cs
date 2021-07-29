using BarberShop.API.Weather;
using BarberShop.Models.ModelAPIWeather;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarberShop.Components
{
    public class ReceivedWeather : ViewComponent
    {
        private readonly WeatherService service;
        public ReceivedWeather(WeatherService service)
        {
            this.service = service;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            WeatherViewModel weatherModel = await service.GetWeatherAsync();
            return View(weatherModel);
        }
    }
}
