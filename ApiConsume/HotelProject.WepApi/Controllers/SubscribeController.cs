using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _subcribeService;
        public SubscribeController(ISubscribeService subcribeService)
        {
            _subcribeService = subcribeService;
        }
        [HttpGet]
        public IActionResult SubscribeList()
        {
            List<Subscribe> subscribelist = _subcribeService.TGetlist();
            return Ok(subscribelist);
        }
        [HttpPost]
        public IActionResult AddSubscribe(Subscribe subcribe)
        {
            _subcribeService.Tinsert(subcribe);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteSubscribe(int id)
        {
            _subcribeService.TDelete(_subcribeService.TGetById(id));
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateSubscribe(Subscribe subcribe)
        {
            _subcribeService.TUpdate(subcribe);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetSubscribe(int id)
        {
            var values = _subcribeService.TGetById(id);
            return Ok(values);
        }
    }
}
