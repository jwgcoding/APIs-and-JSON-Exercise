using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using APIsAndJSON;



namespace APIsAndJSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var client = new HttpClient();
            //var quotes = new QuoteGenerator(client);

            //Console.WriteLine("Conversation between Kanye and Ron Swanson!!!!");

            //for (int i = 0; i < 5; i++)
            //{

            //    Console.WriteLine("----------------------------");
            //    Console.WriteLine($"Kanye: {quotes.Kanye()}");
            //    Console.WriteLine();
            //    Console.WriteLine($"Ron Swanson: {quotes.RonSwanson()}");
            //}


            string key = File.ReadAllText("appsettings.json");
            string APIKey = JObject.Parse(key).GetValue("APIKey").ToString();

            Console.WriteLine("Please enter your city.");
            var city = Console.ReadLine();

            var apiCall = $"https://api.openweathermap.org/data/2.5/weather?q={city}&units=imperial&appid={APIKey}";
            Console.WriteLine();

            Console.WriteLine($"It is currently {OpenWeatherMapAPI.GetTemp(apiCall)} degrees F in your location.");
        }
    }
}