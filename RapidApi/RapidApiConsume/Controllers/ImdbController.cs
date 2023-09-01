using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Net.Http;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using RapidApiConsume.Models;

namespace RapidApiConsume.Controllers
{
    public class ImdbController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ImdbController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                Headers =
                {
                    { "X-RapidAPI-Key", "e6080bf214mshb942ed050116116p1257b5jsn7f9d16424690" },
                    { "X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var value=JsonConvert.DeserializeObject<List<ApiMovieVM>>(body);
                return View(value);
            }
        }

    }
}
