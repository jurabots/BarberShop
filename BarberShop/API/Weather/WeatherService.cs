using BarberShop.Models.ModelAPIWeather;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace BarberShop.API.Weather
{
    public class WeatherService
    {
        string urlCity = "http://api.openweathermap.org/data/2.5/weather?q=Kyiv&units=metric&appid=86e843ec06f0899bca0d3a770f3e9016";
        public async Task<WeatherViewModel> GetWeatherAsync()
        {

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(urlCity);

            string weatherStringJson = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<WeatherViewModel>(weatherStringJson);

            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlCity);
            //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //string textResponse;

            //using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            //{
            //    textResponse = reader.ReadToEnd();
            //}
            //WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(textResponse);
            //return weatherResponse;
        }
    }
}
