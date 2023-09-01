using HotelProject.WebUI.Dtos.BookingDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    public class BookingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public BookingController(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult AddBooking()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> AddBooking(CreateBookingDto createBookingDto)
        {
            createBookingDto.Status = "Onay Bekliyor";
            var client =_httpClientFactory.CreateClient();
            var jsonData=JsonConvert.SerializeObject(createBookingDto);
            StringContent content= new StringContent(jsonData,Encoding.UTF8,"application/json");
            var responseMessage = await client.PostAsync(_configuration["ApiContent:Booking"], content);
            if(responseMessage.IsSuccessStatusCode)
            {
                TempData["Success"] = "İşleminiz başarıyla alındı.";
                return RedirectToAction("Index", "Booking");
            }

            return View();
        }
    }
}
