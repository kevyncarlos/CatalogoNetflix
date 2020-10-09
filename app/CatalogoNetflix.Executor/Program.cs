using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace CatalogoNetflix.Executor
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            List<object> catalogo = new List<object>();
            string[] lines = File.ReadAllLines(@$"{Directory.GetCurrentDirectory()}\CSV\netflix.csv");
            foreach (string line in lines.Skip(1))
            {
                string[] linhaSeparada = line.Split(";");
                if (linhaSeparada.Length == 7)
                {
                    catalogo.Add(new
                    {
                        Title = linhaSeparada[0],
                        Rating = linhaSeparada[1],
                        RantingDescription = linhaSeparada[2],
                        RatingLevel = linhaSeparada[3],
                        ReleaseYear = linhaSeparada[4],
                        UserRatingScore = linhaSeparada[5],
                        UserRatingSize = linhaSeparada[6]
                    });
                }
            }

            var jsonString = JsonSerializer.Serialize(catalogo);

            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5000/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var httpContent = new StringContent(jsonString, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("api/catalogo", httpContent);

            Console.WriteLine(response);
        }
    }
}
