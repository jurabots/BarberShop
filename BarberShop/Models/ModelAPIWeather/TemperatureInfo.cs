using System.ComponentModel.DataAnnotations.Schema;

namespace BarberShop.Models.ModelAPIWeather
{
    [NotMapped]
    public class TemperatureInfo
    {
        public float Temp { get; set; }
    }
}
