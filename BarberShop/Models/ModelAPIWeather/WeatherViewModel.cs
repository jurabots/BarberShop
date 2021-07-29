using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BarberShop.Models.ModelAPIWeather
{
    [NotMapped]
    public class WeatherViewModel
    {
        public TemperatureInfo Main { get; set; }
        public string Name { get; set; }
    }
}
