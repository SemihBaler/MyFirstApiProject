using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;

namespace RapidApiConsume.Controllers
{
    public class ExchangeController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ExchangeController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {

            var client = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com13.p.rapidapi.com/currencies?language_code=en-us"),
                Headers =
    {
        { "X-RapidAPI-Key", "e6080bf214mshb942ed050116116p1257b5jsn7f9d16424690" },
        { "X-RapidAPI-Host", "booking-com13.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<ExchangeVM>(body);
                return View(value.data.ToList());
            }

        }
    }
}
