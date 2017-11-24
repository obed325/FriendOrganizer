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
    static class WeatherReader
    {
        static WeatherReader()
        {
            httpClient.BaseAddress = new Uri("https://www.metaweather.com/api/");

            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


        }

        static HttpClient httpClient = new HttpClient();

        const string ImageUrlFormat = "https://www.metaweather.com/static/img/weather/png/64/{0}.png";





        //Weather weather = await GetWeatherAsync("location/890869/");
        //Console.WriteLine(weather.title); //Where
        //Console.WriteLine(weather.location_type);
        //Console.WriteLine(weather.time);
        //Console.WriteLine("Windspeed " + (Math.Round(weather.consolidated_weather[0].wind_speed, 2)));
        //Console.WriteLine("Temp " + (weather.consolidated_weather[0].the_temp));
        //Console.WriteLine(weather.consolidated_weather[0].weather_state_name);
        //Console.ReadKey();


        public static async Task<ConsolidatedWeather> GetWeatherAsync(DateTime dateTime)
        {
            string path = $"location/890869/{dateTime.Year}/{dateTime.Month}/{dateTime.Day}/";
            

            try
            {
                List<ConsolidatedWeather> weather = null;
                //ConsolidatedWeather _w = 
                HttpResponseMessage response = await httpClient.GetAsync(path);

               

                if (response.IsSuccessStatusCode)
                {
                    weather = await response.Content.ReadAsAsync<List<ConsolidatedWeather>>();
                    if (weather == null)
                    {
                        //weather.Clear();
                        weather[0].weather_state_name = "No forecast"; weather[0].ImageUrl = "";
                        //return weather[0];
                    }
                    if (weather != null)
                    {
                        weather[0].ImageUrl = string.Format(ImageUrlFormat, weather[0].weather_state_abbr);
                    }
                    
                }

                return weather[0];
                
            }
            catch (Exception e)
            {
               

                Console.WriteLine(e.Message);
                return null;
            }
            
        }
    }
}
