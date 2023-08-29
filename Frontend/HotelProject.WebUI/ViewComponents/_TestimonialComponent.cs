using HotelProject.WebUI.Dtos.TestimonialDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents
{
    public class _TestimonialComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _TestimonialComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5038/api/Testimonial");
            if(responseMessage.IsSuccessStatusCode)
            {
                var json =await responseMessage.Content.ReadAsStringAsync();
                var value=JsonConvert.DeserializeObject<List<ResultTestimonialDto>>(json);
                return View(value);
            }
            return View();
        }
    }
}
