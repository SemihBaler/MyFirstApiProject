using HotelProject.WebUI.Areas.Admin.Dtos.BookingDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace HotelProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookingAdminController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public BookingAdminController(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync(_configuration["ApiContent:Booking"]);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);
                return View(value);
            }
            return View();
        }
        public async Task<IActionResult> ApprovedRezervation(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5038/api/Booking/BookingApproved?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["Success"] = "İşleminiz tamamlandı.";
                return RedirectToAction("Index", "Admin");
            }
            return View();
        }
        public async Task<IActionResult> CancelRezervation(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5038/api/Booking/BookingCancel?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["Success"] = "İşleminiz tamamlandı.";
                return RedirectToAction("Index","Admin");
            }
            return View();
        }
        public async Task<IActionResult> HoldRezervation(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5038/api/Booking/BookingHold?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["Success"] = "İşleminiz tamamlandı.";
                return RedirectToAction("Index", "Admin");
            }
            return View();
        }
    }


}


