using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        [HttpGet]
        public IActionResult ServiceList()
        {
            List<Booking> Bookinglist = _bookingService.TGetlist();
            return Ok(Bookinglist);
        }
        [HttpPost]
        public IActionResult AddService(Booking booking)
        {
            _bookingService.Tinsert(booking);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id)
        {
            _bookingService.TDelete(_bookingService.TGetById(id));
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateService(Booking booking)
        {
            _bookingService.TUpdate(booking);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var values = _bookingService.TGetById(id);
            return Ok(values);
        }
    }
}
