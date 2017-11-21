using FriendOrganizer.Ui.Data.FinderFriendOrganizer.Ui.Data.Finder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FriendOrganizer.Ui.Data.Finder
{
    class WeatherReader
    {
        public WeatherReader()
        {
                httpClient.BaseAddress = new Uri("https://www.metaweather.com/api/");

                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        static HttpClient httpClient = new HttpClient();

       


            //Weather weather = await GetWeatherAsync("location/890869/");
            //Console.WriteLine(weather.title); //Where
            //Console.WriteLine(weather.location_type);
            //Console.WriteLine(weather.time);
            //Console.WriteLine("Windspeed " + (Math.Round(weather.consolidated_weather[0].wind_speed, 2)));
            //Console.WriteLine("Temp " + (weather.consolidated_weather[0].the_temp));
            //Console.WriteLine(weather.consolidated_weather[0].weather_state_name);
            //Console.ReadKey();


        public async Task<Weather> GetWeatherAsync(string path)
        {
            Weather product = null;
            HttpResponseMessage response = await httpClient.GetAsync(path);

            if (response.IsSuccessStatusCode)
            {
                try
                {
                    product = await response.Content.ReadAsAsync<Weather>();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return product;
        }
    }
}
