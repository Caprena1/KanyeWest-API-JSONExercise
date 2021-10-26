using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeRest_APIandJSONExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
                     
                      
            for (int i = 0; i < 5; i++)
            {
                var kanyeResponse = client.GetStringAsync("https://api.kanye.rest").Result;
                var ronResponse = client.GetStringAsync("https://ron-swanson-quotes.herokuapp.com/v2/quotes").Result;

                var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
                var kanyeQuote = JObject.Parse(kanyeResponse).ToString().Replace('{', ' ').Replace('}', ' ').Trim();

                Console.WriteLine($"Ron Quote: {ronQuote}");
                Console.WriteLine($"Kanye Quote: {kanyeQuote}");
                Console.WriteLine();
                Console.WriteLine();
            }
            
                

            
        }
    }
}
