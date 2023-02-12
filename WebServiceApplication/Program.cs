using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebServiceApplication
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Please write a text:");
            string text = Console.ReadLine();
            Console.WriteLine("Calling WebAPI...");
            HttpClient client = new HttpClient();
            string apiUrl = "https://api.funtranslations.com/translate/yoda.json?text=" + text;
            var response = await client.GetAsync(apiUrl);
            if (response.IsSuccessStatusCode)
            {
                var message = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Message from web API: " + message);
                Console.ReadLine();
            }
        }
    }
}